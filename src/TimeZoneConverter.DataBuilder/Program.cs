using System.IO.Compression;

namespace TimeZoneConverter.DataBuilder;

internal static class Program
{
    public static void Main(string[] args)
    {
        var tempDir = Downloader.GetTempDir();

        try
        {
            var cldrPath = Path.Combine(tempDir, "cldr");
            var tzdbPath = Path.Combine(tempDir, "tzdb");
            var railsPath = Path.Combine(tempDir, "rails");

            // Download Data
            if (!Directory.Exists(tempDir))
            {
                var t1 = Downloader.DownloadCldrAsync(cldrPath);
                var t2 = Downloader.DownloadTzdbAsync(tzdbPath);
                var t3 = Downloader.DownloadRailsTzMappingAsync(railsPath);
                Task.WaitAll(t1, t2, t3);
            }

            // Extract links and territories from TZDB
            var links = DataExtractor.LoadTzdbLinks(tzdbPath);
            var territories = DataExtractor.LoadTzdbTerritories(tzdbPath);

            // Fixup UTC equivalencies.  Prefer Etc/UTC.
            links.Add("Etc/GMT", "Etc/UTC");
            foreach (var tzdbLink in links.ToList())
            {
                if (tzdbLink.Value == "Etc/GMT")
                {
                    links[tzdbLink.Key] = "Etc/UTC";
                }
            }

            // Extract mappings and aliases from CLDR
            var mapping = DataExtractor.LoadMapping(cldrPath);
            var aliases = DataExtractor.LoadAliases(cldrPath, links);

            // Extract Rails mappings and aliases from Rails data
            var railsMapping = DataExtractor.LoadRailsMapping(railsPath);

            // Apply override mappings for zones not yet in the CLDR trunk we pulled in
            mapping.Remove("Mountain Standard Time (Mexico),001,America/Chihuahua");
            mapping.Add("Mountain Standard Time (Mexico),001,America/Mazatlan");

            mapping.Remove("Mountain Standard Time (Mexico),MX,America/Chihuahua America/Mazatlan");
            mapping.Add("Mountain Standard Time (Mexico),MX,America/Mazatlan");

            mapping.Remove("Central Standard Time (Mexico),MX,America/Mexico_City America/Bahia_Banderas America/Merida America/Monterrey");
            mapping.Add("Central Standard Time (Mexico),MX,America/Mexico_City America/Bahia_Banderas America/Merida America/Monterrey America/Chihuahua");

            mapping.Remove("Mountain Standard Time,MX,America/Ojinaga");
            mapping.Add("Mountain Standard Time,MX,America/Ciudad_Juarez");

            mapping.Remove("Central Standard Time,MX,America/Matamoros");
            mapping.Add("Central Standard Time,MX,America/Matamoros America/Ojinaga");

            // Add missing Rails mappings where they make sense
            railsMapping.Remove("Arizona,America/Phoenix");
            railsMapping.Add("Arizona,America/Phoenix America/Whitehorse");

            // Add mappings for ISO country codes that aren't used in CLDR
            mapping.Add("Romance Standard Time,EA,Africa/Ceuta");
            mapping.Add("GMT Standard Time,IC,Atlantic/Canary");
            mapping.Add("Greenwich Standard Time,AC,Atlantic/St_Helena");
            mapping.Add("Greenwich Standard Time,TA,Atlantic/St_Helena");
            mapping.Add("Central Europe Standard Time,XK,Europe/Belgrade");
            mapping.Add("Central Asia Standard Time,DG,Indian/Chagos");

            // Add a few aliases for IANA abbreviated zones not tracked by CLDR
            aliases.Add("Europe/Paris,CET");
            aliases.Add("Europe/Bucharest,EET");
            aliases.Add("Europe/Berlin,MET");
            aliases.Add("Atlantic/Canary,WET");

            mapping.Sort(StringComparer.Ordinal);
            aliases.Sort(StringComparer.Ordinal);

            // Support mapping deprecated Windows zones, but after sorting so they are not used as primary results
            mapping.Add("Kamchatka Standard Time,001,Asia/Kamchatka");
            mapping.Add("Mid-Atlantic Standard Time,001,Etc/GMT+2");

            // Write to source files in the main library
            WriteAllLinesToCodeFiles(aliases, territories, mapping, railsMapping);
        }
        finally
        {
            // Cleanup Data
            Directory.Delete(tempDir, true);
        }
    }

    private static void WriteAllLinesToCodeFiles(IList<string> aliases, IList<string> territories, IList<string> mapping, IList<string> railsMapping)
    {
        var projectPath = Path.GetFullPath(".");
        while (!File.Exists(Path.Combine(projectPath, "TimeZoneConverter.sln")))
        {
            projectPath = Path.GetFullPath(Path.Combine(projectPath, ".."));
        }
        var dataPath = Path.Combine(projectPath, "src", "TimeZoneConverter", "Data");
        IDictionary<string, string> ianaMap = new Dictionary<string, string>();
        IDictionary<string, string> windowsMap = new Dictionary<string, string>();
        IDictionary<string, string> railsMap = new Dictionary<string, string>();
        IDictionary<string, IList<string>> inverseRailsMap = new Dictionary<string, IList<string>>();
        IDictionary<string, string> links = new Dictionary<string, string>();
        IDictionary<string, IList<string>> ianaTerritoryZones = new Dictionary<string, IList<string>>();

        foreach (var link in aliases)
        {
            var parts = link.Split(',');
            var value = parts[0];
            foreach (var key in parts[1].Split())
            {
                links.Add(key, value);
            }
        }

        foreach (var item in territories)
        {
            var parts = item.Split(',');
            var territory = parts[0];
            var zones = new List<string>(parts[1].Split(' '));
            ianaTerritoryZones.Add(territory, zones);
        }

        var similarIanaZones = new Dictionary<string, IList<string>>();
        foreach (var item in mapping)
        {
            var parts = item.Split(',');
            var windowsZone = parts[0];        // e.g. "Pacific Standard Time"
            var territory = parts[1];          // e.g. "US"
            var ianaZones = parts[2].Split();  // e.g. "America/Vancouver America/Dawson America/Whitehorse" -> `new String[] { "America/Vancouver", "America/Dawson", "America/Whitehorse" }`

            // Create the Windows map entry
            var key = $"{territory}|{windowsZone}";
            if (!windowsMap.ContainsKey(key))
            {
                windowsMap.Add(key, ianaZones[0]);
            }
            else
            {
                Console.WriteLine($"Encountered duplicate key '${key}'");
            }

            // Create the IANA map entries
            foreach (var ianaZone in ianaZones)
            {
                if (!ianaMap.ContainsKey(ianaZone))
                {
                    ianaMap.Add(ianaZone, windowsZone);
                }
            }

            if (ianaZones.Length > 1)
            {
                foreach (var ianaZone in ianaZones)
                {
                    if (!similarIanaZones.ContainsKey(ianaZone))
                    {
                        similarIanaZones.Add(ianaZone, ianaZones.Except(new[] { ianaZone }).ToArray());
                    }
                    else
                    {
                        Console.WriteLine($"Encountered duplicate key '${key}'");
                    }
                }
            }
        }

        // Expand the IANA map to include all links (both directions)
        var linksToMap = links.ToList();
        while (linksToMap.Count > 0)
        {
            var retry = new List<KeyValuePair<string, string>>();
            foreach (var link in linksToMap)
            {
                var hasMapFromKey = ianaMap.TryGetValue(link.Key, out var mapFromKey);
                var hasMapFromValue = ianaMap.TryGetValue(link.Value, out var mapFromValue);

                if (hasMapFromKey && hasMapFromValue)
                {
                    // There are already mappings in both directions
                    continue;
                }

                if (!hasMapFromKey && hasMapFromValue)
                {
                    // Forward mapping
                    ianaMap.Add(link.Key, mapFromValue!);
                }
                else if (!hasMapFromValue && hasMapFromKey)
                {
                    // Reverse mapping
                    ianaMap.Add(link.Value, mapFromKey!);
                }
                else
                {
                    // Not found yet, but we can try again
                    retry.Add(link);
                }
            }

            linksToMap = retry;
        }

        foreach (var item in railsMapping)
        {
            var parts = item.Split(',');
            var railsZone = parts[0];
            var ianaZones = parts[1].Split();

            for (var i = 0; i < ianaZones.Length; i++)
            {
                var ianaZone = ianaZones[i];
                if (i == 0)
                {
                    railsMap.Add(railsZone, ianaZone);
                }
                else
                {
                    inverseRailsMap.Add(ianaZone, new[] { railsZone });
                }
            }
        }

        foreach (var grouping in railsMap.GroupBy(x => x.Value, x => x.Key))
        {
            inverseRailsMap.Add(grouping.Key, grouping.ToList());
        }

        // Expand the Inverse Rails map to include similar IANA zones
        foreach (var ianaZone in ianaMap.Keys)
        {
            if (inverseRailsMap.ContainsKey(ianaZone) || links.ContainsKey(ianaZone))
            {
                continue;
            }

            if (similarIanaZones.TryGetValue(ianaZone, out var similarZones))
            {
                foreach (var otherZone in similarZones)
                {
                    if (inverseRailsMap.TryGetValue(otherZone, out var railsZones))
                    {
                        inverseRailsMap.Add(ianaZone, railsZones);
                        break;
                    }
                }
            }
        }

        // Expand the Inverse Rails map to include links (in either direction)
        foreach (var link in links)
        {
            if (!inverseRailsMap.ContainsKey(link.Key))
            {
                if (inverseRailsMap.TryGetValue(link.Value, out var railsZone))
                {
                    inverseRailsMap.Add(link.Key, railsZone);
                }
            }
            else if (!inverseRailsMap.ContainsKey(link.Value))
            {
                if (inverseRailsMap.TryGetValue(link.Key, out var railsZone))
                {
                    inverseRailsMap.Add(link.Value, railsZone);
                }
            }
        }

        // Expand the Inverse Rails map to use CLDR golden zones
        foreach (var ianaZone in ianaMap.Keys)
        {
            if (!inverseRailsMap.ContainsKey(ianaZone) &&
                ianaMap.TryGetValue(ianaZone, out var windowsZone) &&
                windowsMap.TryGetValue("001|" + windowsZone, out var goldenZone) &&
                inverseRailsMap.TryGetValue(goldenZone, out var railsZones))
            {
                inverseRailsMap.Add(ianaZone, railsZones);
            }
        }

        WriteCodeFile(dataPath, ianaMap, "IanaMap");
        WriteCodeFile(dataPath, windowsMap, "WindowsMap");
        WriteCodeFile(dataPath, links, "Links");
        WriteCodeFile(dataPath, railsMap, "RailsMap");
        WriteCodeFile(dataPath, similarIanaZones, "SimilarIanaZones");
        WriteCodeFile(dataPath, inverseRailsMap, "InverseRailsMap");
    }

    private static void WriteCodeFile(string path, IDictionary<string, string> mappings, string className)
    {
        var fileName = Path.Combine(path, $"{className}.cs");
        using var stream = File.Create(fileName);
        using var writer = new StreamWriter(stream);
        writer.WriteLine("namespace TimeZoneConverter.Data;");
        writer.WriteLine(string.Empty);
        writer.WriteLine($"public static class {className}");
        writer.WriteLine("{");
        writer.WriteLine("    public static IReadOnlyDictionary<string, string> Mappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {");
        foreach (var mapping in mappings)
        {
            writer.WriteLine($"        {{ \"{mapping.Key}\",\"{mapping.Value}\" }},");
        }
        writer.WriteLine("    };");
        writer.WriteLine("}");
        writer.WriteLine(string.Empty);
    }

    private static void WriteCodeFile(string path, IDictionary<string, IList<string>> mappings, string className)
    {
        var fileName = Path.Combine(path, $"{className}.cs");
        using var stream = File.Create(fileName);
        using var writer = new StreamWriter(stream);
        writer.WriteLine("namespace TimeZoneConverter.Data;");
        writer.WriteLine(string.Empty);
        writer.WriteLine($"public static class {className}");
        writer.WriteLine("{");
        writer.WriteLine("    public static IReadOnlyDictionary<string, IReadOnlyList<string>> Mappings = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase) {");
        foreach (var mapping in mappings)
        {
            writer.WriteLine($"        {{ \"{mapping.Key}\",");
            writer.WriteLine("            new List<string> { ");
            foreach(var entry in mapping.Value)
            {
                writer.WriteLine($"                \"{entry}\", ");
            }
            writer.WriteLine("         }},");
        }
        writer.WriteLine("    };");
        writer.WriteLine("}");
        writer.WriteLine(string.Empty);
    }
}
