namespace TimeZoneConverter.Data;

public static class InverseRailsMap
{
    public static IReadOnlyDictionary<string, IReadOnlyList<string>> Mappings = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase) {
        { "America/Whitehorse",
            new List<string> { 
                "Arizona", 
         }},
        { "Etc/GMT+12",
            new List<string> { 
                "International Date Line West", 
         }},
        { "Pacific/Midway",
            new List<string> { 
                "Midway Island", 
         }},
        { "Pacific/Pago_Pago",
            new List<string> { 
                "American Samoa", 
         }},
        { "Pacific/Honolulu",
            new List<string> { 
                "Hawaii", 
         }},
        { "America/Juneau",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Los_Angeles",
            new List<string> { 
                "Pacific Time (US & Canada)", 
         }},
        { "America/Tijuana",
            new List<string> { 
                "Tijuana", 
         }},
        { "America/Denver",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "America/Chihuahua",
            new List<string> { 
                "Chihuahua", 
         }},
        { "America/Mazatlan",
            new List<string> { 
                "Mazatlan", 
         }},
        { "America/Chicago",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Regina",
            new List<string> { 
                "Saskatchewan", 
         }},
        { "America/Mexico_City",
            new List<string> { 
                "Guadalajara", 
                "Mexico City", 
         }},
        { "America/Monterrey",
            new List<string> { 
                "Monterrey", 
         }},
        { "America/Guatemala",
            new List<string> { 
                "Central America", 
         }},
        { "America/New_York",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Indiana/Indianapolis",
            new List<string> { 
                "Indiana (East)", 
         }},
        { "America/Bogota",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Lima",
            new List<string> { 
                "Lima", 
                "Quito", 
         }},
        { "America/Halifax",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Caracas",
            new List<string> { 
                "Caracas", 
         }},
        { "America/La_Paz",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Santiago",
            new List<string> { 
                "Santiago", 
         }},
        { "America/St_Johns",
            new List<string> { 
                "Newfoundland", 
         }},
        { "America/Sao_Paulo",
            new List<string> { 
                "Brasilia", 
         }},
        { "America/Argentina/Buenos_Aires",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Montevideo",
            new List<string> { 
                "Montevideo", 
         }},
        { "America/Guyana",
            new List<string> { 
                "Georgetown", 
         }},
        { "America/Puerto_Rico",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Godthab",
            new List<string> { 
                "Greenland", 
         }},
        { "Atlantic/South_Georgia",
            new List<string> { 
                "Mid-Atlantic", 
         }},
        { "Atlantic/Azores",
            new List<string> { 
                "Azores", 
         }},
        { "Atlantic/Cape_Verde",
            new List<string> { 
                "Cape Verde Is.", 
         }},
        { "Europe/Dublin",
            new List<string> { 
                "Dublin", 
         }},
        { "Europe/London",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Europe/Lisbon",
            new List<string> { 
                "Lisbon", 
         }},
        { "Africa/Casablanca",
            new List<string> { 
                "Casablanca", 
         }},
        { "Africa/Monrovia",
            new List<string> { 
                "Monrovia", 
         }},
        { "Etc/UTC",
            new List<string> { 
                "UTC", 
         }},
        { "Europe/Belgrade",
            new List<string> { 
                "Belgrade", 
         }},
        { "Europe/Bratislava",
            new List<string> { 
                "Bratislava", 
         }},
        { "Europe/Budapest",
            new List<string> { 
                "Budapest", 
         }},
        { "Europe/Ljubljana",
            new List<string> { 
                "Ljubljana", 
         }},
        { "Europe/Prague",
            new List<string> { 
                "Prague", 
         }},
        { "Europe/Sarajevo",
            new List<string> { 
                "Sarajevo", 
         }},
        { "Europe/Skopje",
            new List<string> { 
                "Skopje", 
         }},
        { "Europe/Warsaw",
            new List<string> { 
                "Warsaw", 
         }},
        { "Europe/Zagreb",
            new List<string> { 
                "Zagreb", 
         }},
        { "Europe/Brussels",
            new List<string> { 
                "Brussels", 
         }},
        { "Europe/Copenhagen",
            new List<string> { 
                "Copenhagen", 
         }},
        { "Europe/Madrid",
            new List<string> { 
                "Madrid", 
         }},
        { "Europe/Paris",
            new List<string> { 
                "Paris", 
         }},
        { "Europe/Amsterdam",
            new List<string> { 
                "Amsterdam", 
         }},
        { "Europe/Berlin",
            new List<string> { 
                "Berlin", 
         }},
        { "Europe/Zurich",
            new List<string> { 
                "Bern", 
                "Zurich", 
         }},
        { "Europe/Rome",
            new List<string> { 
                "Rome", 
         }},
        { "Europe/Stockholm",
            new List<string> { 
                "Stockholm", 
         }},
        { "Europe/Vienna",
            new List<string> { 
                "Vienna", 
         }},
        { "Africa/Algiers",
            new List<string> { 
                "West Central Africa", 
         }},
        { "Europe/Bucharest",
            new List<string> { 
                "Bucharest", 
         }},
        { "Africa/Cairo",
            new List<string> { 
                "Cairo", 
         }},
        { "Europe/Helsinki",
            new List<string> { 
                "Helsinki", 
         }},
        { "Europe/Kiev",
            new List<string> { 
                "Kyiv", 
         }},
        { "Europe/Riga",
            new List<string> { 
                "Riga", 
         }},
        { "Europe/Sofia",
            new List<string> { 
                "Sofia", 
         }},
        { "Europe/Tallinn",
            new List<string> { 
                "Tallinn", 
         }},
        { "Europe/Vilnius",
            new List<string> { 
                "Vilnius", 
         }},
        { "Europe/Athens",
            new List<string> { 
                "Athens", 
         }},
        { "Europe/Istanbul",
            new List<string> { 
                "Istanbul", 
         }},
        { "Europe/Minsk",
            new List<string> { 
                "Minsk", 
         }},
        { "Asia/Jerusalem",
            new List<string> { 
                "Jerusalem", 
         }},
        { "Africa/Harare",
            new List<string> { 
                "Harare", 
         }},
        { "Africa/Johannesburg",
            new List<string> { 
                "Pretoria", 
         }},
        { "Europe/Kaliningrad",
            new List<string> { 
                "Kaliningrad", 
         }},
        { "Europe/Moscow",
            new List<string> { 
                "Moscow", 
                "St. Petersburg", 
         }},
        { "Europe/Volgograd",
            new List<string> { 
                "Volgograd", 
         }},
        { "Europe/Samara",
            new List<string> { 
                "Samara", 
         }},
        { "Asia/Kuwait",
            new List<string> { 
                "Kuwait", 
         }},
        { "Asia/Riyadh",
            new List<string> { 
                "Riyadh", 
         }},
        { "Africa/Nairobi",
            new List<string> { 
                "Nairobi", 
         }},
        { "Asia/Baghdad",
            new List<string> { 
                "Baghdad", 
         }},
        { "Asia/Tehran",
            new List<string> { 
                "Tehran", 
         }},
        { "Asia/Muscat",
            new List<string> { 
                "Abu Dhabi", 
                "Muscat", 
         }},
        { "Asia/Baku",
            new List<string> { 
                "Baku", 
         }},
        { "Asia/Tbilisi",
            new List<string> { 
                "Tbilisi", 
         }},
        { "Asia/Yerevan",
            new List<string> { 
                "Yerevan", 
         }},
        { "Asia/Kabul",
            new List<string> { 
                "Kabul", 
         }},
        { "Asia/Yekaterinburg",
            new List<string> { 
                "Ekaterinburg", 
         }},
        { "Asia/Karachi",
            new List<string> { 
                "Islamabad", 
                "Karachi", 
         }},
        { "Asia/Tashkent",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Kolkata",
            new List<string> { 
                "Chennai", 
                "Kolkata", 
                "Mumbai", 
                "New Delhi", 
         }},
        { "Asia/Kathmandu",
            new List<string> { 
                "Kathmandu", 
         }},
        { "Asia/Dhaka",
            new List<string> { 
                "Astana", 
                "Dhaka", 
         }},
        { "Asia/Colombo",
            new List<string> { 
                "Sri Jayawardenepura", 
         }},
        { "Asia/Almaty",
            new List<string> { 
                "Almaty", 
         }},
        { "Asia/Novosibirsk",
            new List<string> { 
                "Novosibirsk", 
         }},
        { "Asia/Rangoon",
            new List<string> { 
                "Rangoon", 
         }},
        { "Asia/Bangkok",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Asia/Jakarta",
            new List<string> { 
                "Jakarta", 
         }},
        { "Asia/Krasnoyarsk",
            new List<string> { 
                "Krasnoyarsk", 
         }},
        { "Asia/Shanghai",
            new List<string> { 
                "Beijing", 
         }},
        { "Asia/Chongqing",
            new List<string> { 
                "Chongqing", 
         }},
        { "Asia/Hong_Kong",
            new List<string> { 
                "Hong Kong", 
         }},
        { "Asia/Urumqi",
            new List<string> { 
                "Urumqi", 
         }},
        { "Asia/Kuala_Lumpur",
            new List<string> { 
                "Kuala Lumpur", 
         }},
        { "Asia/Singapore",
            new List<string> { 
                "Singapore", 
         }},
        { "Asia/Taipei",
            new List<string> { 
                "Taipei", 
         }},
        { "Australia/Perth",
            new List<string> { 
                "Perth", 
         }},
        { "Asia/Irkutsk",
            new List<string> { 
                "Irkutsk", 
         }},
        { "Asia/Ulaanbaatar",
            new List<string> { 
                "Ulaanbaatar", 
         }},
        { "Asia/Seoul",
            new List<string> { 
                "Seoul", 
         }},
        { "Asia/Tokyo",
            new List<string> { 
                "Osaka", 
                "Sapporo", 
                "Tokyo", 
         }},
        { "Asia/Yakutsk",
            new List<string> { 
                "Yakutsk", 
         }},
        { "Australia/Darwin",
            new List<string> { 
                "Darwin", 
         }},
        { "Australia/Adelaide",
            new List<string> { 
                "Adelaide", 
         }},
        { "Australia/Canberra",
            new List<string> { 
                "Canberra", 
         }},
        { "Australia/Melbourne",
            new List<string> { 
                "Melbourne", 
         }},
        { "Australia/Sydney",
            new List<string> { 
                "Sydney", 
         }},
        { "Australia/Brisbane",
            new List<string> { 
                "Brisbane", 
         }},
        { "Australia/Hobart",
            new List<string> { 
                "Hobart", 
         }},
        { "Asia/Vladivostok",
            new List<string> { 
                "Vladivostok", 
         }},
        { "Pacific/Guam",
            new List<string> { 
                "Guam", 
         }},
        { "Pacific/Port_Moresby",
            new List<string> { 
                "Port Moresby", 
         }},
        { "Asia/Magadan",
            new List<string> { 
                "Magadan", 
         }},
        { "Asia/Srednekolymsk",
            new List<string> { 
                "Srednekolymsk", 
         }},
        { "Pacific/Guadalcanal",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "Pacific/Noumea",
            new List<string> { 
                "New Caledonia", 
         }},
        { "Pacific/Fiji",
            new List<string> { 
                "Fiji", 
         }},
        { "Asia/Kamchatka",
            new List<string> { 
                "Kamchatka", 
         }},
        { "Pacific/Majuro",
            new List<string> { 
                "Marshall Is.", 
         }},
        { "Pacific/Auckland",
            new List<string> { 
                "Auckland", 
                "Wellington", 
         }},
        { "Pacific/Tongatapu",
            new List<string> { 
                "Nuku'alofa", 
         }},
        { "Pacific/Fakaofo",
            new List<string> { 
                "Tokelau Is.", 
         }},
        { "Pacific/Chatham",
            new List<string> { 
                "Chatham Is.", 
         }},
        { "Pacific/Apia",
            new List<string> { 
                "Samoa", 
         }},
        { "America/Phoenix",
            new List<string> { 
                "Arizona", 
         }},
        { "America/Anchorage",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Metlakatla",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Nome",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Sitka",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Yakutat",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Glace_Bay",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Goose_Bay",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Moncton",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Swift_Current",
            new List<string> { 
                "Saskatchewan", 
         }},
        { "Australia/Broken_Hill",
            new List<string> { 
                "Adelaide", 
         }},
        { "Asia/Qostanay",
            new List<string> { 
                "Almaty", 
         }},
        { "America/Bahia_Banderas",
            new List<string> { 
                "Guadalajara", 
                "Mexico City", 
         }},
        { "America/Merida",
            new List<string> { 
                "Guadalajara", 
                "Mexico City", 
         }},
        { "America/Indiana/Knox",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Indiana/Tell_City",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Menominee",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/North_Dakota/Beulah",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/North_Dakota/Center",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/North_Dakota/New_Salem",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "Australia/Lindeman",
            new List<string> { 
                "Brisbane", 
         }},
        { "America/Detroit",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Indiana/Petersburg",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Indiana/Vincennes",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Indiana/Winamac",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Kentucky/Monticello",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "Atlantic/Madeira",
            new List<string> { 
                "Lisbon", 
         }},
        { "America/Boise",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "Asia/Novokuznetsk",
            new List<string> { 
                "Krasnoyarsk", 
         }},
        { "Africa/Ceuta",
            new List<string> { 
                "Madrid", 
         }},
        { "Asia/Anadyr",
            new List<string> { 
                "Kamchatka", 
         }},
        { "Europe/Kirov",
            new List<string> { 
                "Moscow", 
                "St. Petersburg", 
         }},
        { "Asia/Pontianak",
            new List<string> { 
                "Jakarta", 
         }},
        { "Asia/Kuching",
            new List<string> { 
                "Kuala Lumpur", 
         }},
        { "Antarctica/Macquarie",
            new List<string> { 
                "Hobart", 
         }},
        { "Pacific/Kwajalein",
            new List<string> { 
                "Marshall Is.", 
         }},
        { "Asia/Choibalsan",
            new List<string> { 
                "Ulaanbaatar", 
         }},
        { "Asia/Ust-Nera",
            new List<string> { 
                "Vladivostok", 
         }},
        { "Asia/Samarkand",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Khandyga",
            new List<string> { 
                "Yakutsk", 
         }},
        { "America/Dawson",
            new List<string> { 
                "Arizona", 
         }},
        { "Egypt",
            new List<string> { 
                "Cairo", 
         }},
        { "Africa/Maseru",
            new List<string> { 
                "Pretoria", 
         }},
        { "Africa/Mbabane",
            new List<string> { 
                "Pretoria", 
         }},
        { "Africa/Maputo",
            new List<string> { 
                "Harare", 
         }},
        { "Africa/Kigali",
            new List<string> { 
                "Harare", 
         }},
        { "Africa/Lubumbashi",
            new List<string> { 
                "Harare", 
         }},
        { "Africa/Lusaka",
            new List<string> { 
                "Harare", 
         }},
        { "Africa/Asmara",
            new List<string> { 
                "Nairobi", 
         }},
        { "Africa/Addis_Ababa",
            new List<string> { 
                "Nairobi", 
         }},
        { "Africa/Dar_es_Salaam",
            new List<string> { 
                "Nairobi", 
         }},
        { "Africa/Djibouti",
            new List<string> { 
                "Nairobi", 
         }},
        { "Africa/Kampala",
            new List<string> { 
                "Nairobi", 
         }},
        { "Africa/Mogadishu",
            new List<string> { 
                "Nairobi", 
         }},
        { "Indian/Antananarivo",
            new List<string> { 
                "Nairobi", 
         }},
        { "Indian/Comoro",
            new List<string> { 
                "Nairobi", 
         }},
        { "Indian/Mayotte",
            new List<string> { 
                "Nairobi", 
         }},
        { "Africa/Asmera",
            new List<string> { 
                "Nairobi", 
         }},
        { "US/Alaska",
            new List<string> { 
                "Alaska", 
         }},
        { "America/Buenos_Aires",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "US/Central",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Shiprock",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "Navajo",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "US/Mountain",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "US/Michigan",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "Canada/Atlantic",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Fort_Wayne",
            new List<string> { 
                "Indiana (East)", 
         }},
        { "America/Indianapolis",
            new List<string> { 
                "Indiana (East)", 
         }},
        { "US/East-Indiana",
            new List<string> { 
                "Indiana (East)", 
         }},
        { "America/Knox_IN",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "US/Indiana-Starke",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "US/Pacific",
            new List<string> { 
                "Pacific Time (US & Canada)", 
         }},
        { "US/Pacific-New",
            new List<string> { 
                "Pacific Time (US & Canada)", 
         }},
        { "Mexico/BajaSur",
            new List<string> { 
                "Mazatlan", 
         }},
        { "Mexico/General",
            new List<string> { 
                "Guadalajara", 
                "Mexico City", 
         }},
        { "US/Eastern",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Nuuk",
            new List<string> { 
                "Greenland", 
         }},
        { "US/Arizona",
            new List<string> { 
                "Arizona", 
         }},
        { "America/Creston",
            new List<string> { 
                "Arizona", 
         }},
        { "America/Virgin",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Anguilla",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Antigua",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Aruba",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Blanc-Sablon",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Curacao",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Dominica",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Grenada",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Guadeloupe",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Kralendijk",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Lower_Princes",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Marigot",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Montserrat",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Port_of_Spain",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/St_Barthelemy",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/St_Kitts",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/St_Lucia",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/St_Thomas",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/St_Vincent",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "America/Tortola",
            new List<string> { 
                "Puerto Rico", 
         }},
        { "Canada/East-Saskatchewan",
            new List<string> { 
                "Saskatchewan", 
         }},
        { "Canada/Saskatchewan",
            new List<string> { 
                "Saskatchewan", 
         }},
        { "Chile/Continental",
            new List<string> { 
                "Santiago", 
         }},
        { "Brazil/East",
            new List<string> { 
                "Brasilia", 
         }},
        { "Canada/Newfoundland",
            new List<string> { 
                "Newfoundland", 
         }},
        { "America/Ensenada",
            new List<string> { 
                "Tijuana", 
         }},
        { "Mexico/BajaNorte",
            new List<string> { 
                "Tijuana", 
         }},
        { "America/Santa_Isabel",
            new List<string> { 
                "Tijuana", 
         }},
        { "Canada/Yukon",
            new List<string> { 
                "Arizona", 
         }},
        { "Asia/Phnom_Penh",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Asia/Vientiane",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Indian/Christmas",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Asia/Dacca",
            new List<string> { 
                "Astana", 
                "Dhaka", 
         }},
        { "Asia/Dubai",
            new List<string> { 
                "Abu Dhabi", 
                "Muscat", 
         }},
        { "Indian/Mahe",
            new List<string> { 
                "Abu Dhabi", 
                "Muscat", 
         }},
        { "Indian/Reunion",
            new List<string> { 
                "Abu Dhabi", 
                "Muscat", 
         }},
        { "Hongkong",
            new List<string> { 
                "Hong Kong", 
         }},
        { "Asia/Tel_Aviv",
            new List<string> { 
                "Jerusalem", 
         }},
        { "Israel",
            new List<string> { 
                "Jerusalem", 
         }},
        { "Asia/Katmandu",
            new List<string> { 
                "Kathmandu", 
         }},
        { "Asia/Calcutta",
            new List<string> { 
                "Chennai", 
                "Kolkata", 
                "Mumbai", 
                "New Delhi", 
         }},
        { "Asia/Brunei",
            new List<string> { 
                "Kuala Lumpur", 
         }},
        { "Antarctica/Syowa",
            new List<string> { 
                "Riyadh", 
         }},
        { "Asia/Aden",
            new List<string> { 
                "Riyadh", 
         }},
        { "ROK",
            new List<string> { 
                "Seoul", 
         }},
        { "Asia/Chungking",
            new List<string> { 
                "Beijing", 
         }},
        { "Asia/Harbin",
            new List<string> { 
                "Beijing", 
         }},
        { "PRC",
            new List<string> { 
                "Beijing", 
         }},
        { "Singapore",
            new List<string> { 
                "Singapore", 
         }},
        { "ROC",
            new List<string> { 
                "Taipei", 
         }},
        { "Iran",
            new List<string> { 
                "Tehran", 
         }},
        { "Japan",
            new List<string> { 
                "Osaka", 
                "Sapporo", 
                "Tokyo", 
         }},
        { "Asia/Ulan_Bator",
            new List<string> { 
                "Ulaanbaatar", 
         }},
        { "Asia/Kashgar",
            new List<string> { 
                "Urumqi", 
         }},
        { "Antarctica/Vostok",
            new List<string> { 
                "Urumqi", 
         }},
        { "Asia/Yangon",
            new List<string> { 
                "Rangoon", 
         }},
        { "Indian/Cocos",
            new List<string> { 
                "Rangoon", 
         }},
        { "Australia/South",
            new List<string> { 
                "Adelaide", 
         }},
        { "Australia/Queensland",
            new List<string> { 
                "Brisbane", 
         }},
        { "Australia/Yancowinna",
            new List<string> { 
                "Adelaide", 
         }},
        { "Australia/North",
            new List<string> { 
                "Darwin", 
         }},
        { "Australia/Tasmania",
            new List<string> { 
                "Hobart", 
         }},
        { "Australia/Currie",
            new List<string> { 
                "Hobart", 
         }},
        { "Australia/Victoria",
            new List<string> { 
                "Melbourne", 
         }},
        { "Australia/West",
            new List<string> { 
                "Perth", 
         }},
        { "Australia/ACT",
            new List<string> { 
                "Sydney", 
         }},
        { "Australia/NSW",
            new List<string> { 
                "Sydney", 
         }},
        { "Etc/GMT+0",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/GMT-0",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/GMT0",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/Greenwich",
            new List<string> { 
                "UTC", 
         }},
        { "GMT",
            new List<string> { 
                "UTC", 
         }},
        { "GMT+0",
            new List<string> { 
                "UTC", 
         }},
        { "GMT-0",
            new List<string> { 
                "UTC", 
         }},
        { "GMT0",
            new List<string> { 
                "UTC", 
         }},
        { "Greenwich",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/UCT",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/Universal",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/Zulu",
            new List<string> { 
                "UTC", 
         }},
        { "UCT",
            new List<string> { 
                "UTC", 
         }},
        { "UTC",
            new List<string> { 
                "UTC", 
         }},
        { "Universal",
            new List<string> { 
                "UTC", 
         }},
        { "Zulu",
            new List<string> { 
                "UTC", 
         }},
        { "Etc/GMT",
            new List<string> { 
                "UTC", 
         }},
        { "Europe/Podgorica",
            new List<string> { 
                "Belgrade", 
         }},
        { "Atlantic/Jan_Mayen",
            new List<string> { 
                "Berlin", 
         }},
        { "Arctic/Longyearbyen",
            new List<string> { 
                "Berlin", 
         }},
        { "Europe/Oslo",
            new List<string> { 
                "Berlin", 
         }},
        { "MET",
            new List<string> { 
                "Berlin", 
         }},
        { "Europe/Luxembourg",
            new List<string> { 
                "Brussels", 
         }},
        { "EET",
            new List<string> { 
                "Bucharest", 
         }},
        { "Eire",
            new List<string> { 
                "Dublin", 
         }},
        { "Europe/Mariehamn",
            new List<string> { 
                "Helsinki", 
         }},
        { "Asia/Istanbul",
            new List<string> { 
                "Istanbul", 
         }},
        { "Turkey",
            new List<string> { 
                "Istanbul", 
         }},
        { "Europe/Kyiv",
            new List<string> { 
                "Kyiv", 
         }},
        { "Europe/Uzhgorod",
            new List<string> { 
                "Kyiv", 
         }},
        { "Europe/Zaporozhye",
            new List<string> { 
                "Kyiv", 
         }},
        { "Portugal",
            new List<string> { 
                "Lisbon", 
         }},
        { "Europe/Belfast",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "GB",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "GB-Eire",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Europe/Guernsey",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Europe/Isle_of_Man",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Europe/Jersey",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "W-SU",
            new List<string> { 
                "Moscow", 
                "St. Petersburg", 
         }},
        { "CET",
            new List<string> { 
                "Paris", 
         }},
        { "Europe/Monaco",
            new List<string> { 
                "Paris", 
         }},
        { "Europe/San_Marino",
            new List<string> { 
                "Rome", 
         }},
        { "Europe/Vatican",
            new List<string> { 
                "Rome", 
         }},
        { "Poland",
            new List<string> { 
                "Warsaw", 
         }},
        { "Europe/Busingen",
            new List<string> { 
                "Bern", 
                "Zurich", 
         }},
        { "Europe/Vaduz",
            new List<string> { 
                "Bern", 
                "Zurich", 
         }},
        { "Antarctica/South_Pole",
            new List<string> { 
                "Auckland", 
                "Wellington", 
         }},
        { "NZ",
            new List<string> { 
                "Auckland", 
                "Wellington", 
         }},
        { "Antarctica/McMurdo",
            new List<string> { 
                "Auckland", 
                "Wellington", 
         }},
        { "NZ-CHAT",
            new List<string> { 
                "Chatham Is.", 
         }},
        { "Pacific/Pohnpei",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "Pacific/Ponape",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "Pacific/Saipan",
            new List<string> { 
                "Guam", 
         }},
        { "US/Hawaii",
            new List<string> { 
                "Hawaii", 
         }},
        { "Pacific/Johnston",
            new List<string> { 
                "Hawaii", 
         }},
        { "Kwajalein",
            new List<string> { 
                "Marshall Is.", 
         }},
        { "Pacific/Samoa",
            new List<string> { 
                "American Samoa", 
         }},
        { "US/Samoa",
            new List<string> { 
                "American Samoa", 
         }},
        { "Pacific/Chuuk",
            new List<string> { 
                "Port Moresby", 
         }},
        { "Pacific/Yap",
            new List<string> { 
                "Port Moresby", 
         }},
        { "Antarctica/DumontDUrville",
            new List<string> { 
                "Port Moresby", 
         }},
        { "Pacific/Truk",
            new List<string> { 
                "Port Moresby", 
         }},
        { "Pacific/Tarawa",
            new List<string> { 
                "Marshall Is.", 
         }},
        { "Pacific/Wake",
            new List<string> { 
                "Marshall Is.", 
         }},
        { "Pacific/Wallis",
            new List<string> { 
                "Marshall Is.", 
         }},
        { "Asia/Bahrain",
            new List<string> { 
                "Riyadh", 
         }},
        { "Asia/Qatar",
            new List<string> { 
                "Riyadh", 
         }},
        { "Etc/GMT-4",
            new List<string> { 
                "Abu Dhabi", 
                "Muscat", 
         }},
        { "America/Argentina/La_Rioja",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Rio_Gallegos",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Salta",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/San_Juan",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/San_Luis",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Tucuman",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Ushuaia",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Catamarca",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Cordoba",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Jujuy",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Mendoza",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "Atlantic/Bermuda",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Thule",
            new List<string> { 
                "Atlantic Time (Canada)", 
         }},
        { "America/Scoresbysund",
            new List<string> { 
                "Azores", 
         }},
        { "Asia/Thimphu",
            new List<string> { 
                "Astana", 
                "Dhaka", 
         }},
        { "Etc/GMT+1",
            new List<string> { 
                "Cape Verde Is.", 
         }},
        { "America/Belize",
            new List<string> { 
                "Central America", 
         }},
        { "America/Costa_Rica",
            new List<string> { 
                "Central America", 
         }},
        { "Pacific/Galapagos",
            new List<string> { 
                "Central America", 
         }},
        { "America/Tegucigalpa",
            new List<string> { 
                "Central America", 
         }},
        { "America/Managua",
            new List<string> { 
                "Central America", 
         }},
        { "America/El_Salvador",
            new List<string> { 
                "Central America", 
         }},
        { "Etc/GMT+6",
            new List<string> { 
                "Central America", 
         }},
        { "Indian/Chagos",
            new List<string> { 
                "Almaty", 
         }},
        { "Asia/Bishkek",
            new List<string> { 
                "Almaty", 
         }},
        { "Etc/GMT-6",
            new List<string> { 
                "Almaty", 
         }},
        { "Europe/Tirane",
            new List<string> { 
                "Budapest", 
         }},
        { "Antarctica/Casey",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "Pacific/Kosrae",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "Pacific/Efate",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "Etc/GMT-11",
            new List<string> { 
                "Solomon Is.", 
         }},
        { "America/Winnipeg",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Rainy_River",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Rankin_Inlet",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Resolute",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Matamoros",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "America/Ojinaga",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "CST6CDT",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "Asia/Macau",
            new List<string> { 
                "Beijing", 
         }},
        { "Etc/GMT-3",
            new List<string> { 
                "Nairobi", 
         }},
        { "America/Nassau",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Toronto",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Iqaluit",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Montreal",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Nipigon",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Pangnirtung",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Thunder_Bay",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "America/Louisville",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "EST5EDT",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "Atlantic/Canary",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Atlantic/Faeroe",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Asia/Nicosia",
            new List<string> { 
                "Bucharest", 
         }},
        { "Asia/Famagusta",
            new List<string> { 
                "Bucharest", 
         }},
        { "Pacific/Rarotonga",
            new List<string> { 
                "Hawaii", 
         }},
        { "Pacific/Tahiti",
            new List<string> { 
                "Hawaii", 
         }},
        { "Etc/GMT+10",
            new List<string> { 
                "Hawaii", 
         }},
        { "Africa/El_Aaiun",
            new List<string> { 
                "Casablanca", 
         }},
        { "America/Edmonton",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "America/Cambridge_Bay",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "America/Inuvik",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "America/Yellowknife",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "America/Ciudad_Juarez",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "MST7MDT",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "America/Vancouver",
            new List<string> { 
                "Pacific Time (US & Canada)", 
         }},
        { "PST8PDT",
            new List<string> { 
                "Pacific Time (US & Canada)", 
         }},
        { "Europe/Simferopol",
            new List<string> { 
                "Moscow", 
                "St. Petersburg", 
         }},
        { "America/Rio_Branco",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Eirunepe",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Coral_Harbour",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Guayaquil",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Jamaica",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Cayman",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Panama",
            new List<string> { 
                "Bogota", 
         }},
        { "Etc/GMT+5",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Barbados",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Manaus",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Boa_Vista",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Porto_Velho",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Santo_Domingo",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Martinique",
            new List<string> { 
                "La Paz", 
         }},
        { "Etc/GMT+4",
            new List<string> { 
                "La Paz", 
         }},
        { "Antarctica/Davis",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Asia/Saigon",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Etc/GMT-7",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Asia/Makassar",
            new List<string> { 
                "Singapore", 
         }},
        { "Asia/Manila",
            new List<string> { 
                "Singapore", 
         }},
        { "Etc/GMT-8",
            new List<string> { 
                "Singapore", 
         }},
        { "Africa/Bujumbura",
            new List<string> { 
                "Pretoria", 
         }},
        { "Africa/Gaborone",
            new List<string> { 
                "Pretoria", 
         }},
        { "Africa/Blantyre",
            new List<string> { 
                "Pretoria", 
         }},
        { "Etc/GMT-2",
            new List<string> { 
                "Pretoria", 
         }},
        { "Asia/Jayapura",
            new List<string> { 
                "Osaka", 
                "Sapporo", 
                "Tokyo", 
         }},
        { "Pacific/Palau",
            new List<string> { 
                "Osaka", 
                "Sapporo", 
                "Tokyo", 
         }},
        { "Asia/Dili",
            new List<string> { 
                "Osaka", 
                "Sapporo", 
                "Tokyo", 
         }},
        { "Etc/GMT-9",
            new List<string> { 
                "Osaka", 
                "Sapporo", 
                "Tokyo", 
         }},
        { "America/Indiana/Marengo",
            new List<string> { 
                "Indiana (East)", 
         }},
        { "America/Indiana/Vevay",
            new List<string> { 
                "Indiana (East)", 
         }},
        { "America/Dawson_Creek",
            new List<string> { 
                "Arizona", 
         }},
        { "America/Fort_Nelson",
            new List<string> { 
                "Arizona", 
         }},
        { "America/Hermosillo",
            new List<string> { 
                "Arizona", 
         }},
        { "Etc/GMT+7",
            new List<string> { 
                "Arizona", 
         }},
        { "Europe/Andorra",
            new List<string> { 
                "Berlin", 
         }},
        { "Europe/Gibraltar",
            new List<string> { 
                "Berlin", 
         }},
        { "Europe/Malta",
            new List<string> { 
                "Berlin", 
         }},
        { "Antarctica/Mawson",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Oral",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Aqtau",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Aqtobe",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Atyrau",
            new List<string> { 
                "Tashkent", 
         }},
        { "Indian/Maldives",
            new List<string> { 
                "Tashkent", 
         }},
        { "Indian/Kerguelen",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Dushanbe",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Ashgabat",
            new List<string> { 
                "Tashkent", 
         }},
        { "Etc/GMT-5",
            new List<string> { 
                "Tashkent", 
         }},
        { "Etc/GMT-10",
            new List<string> { 
                "Port Moresby", 
         }},
        { "America/Argentina/Catamarca",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/ComodRivadavia",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Cordoba",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Rosario",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Jujuy",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "America/Argentina/Mendoza",
            new List<string> { 
                "Buenos Aires", 
         }},
        { "Canada/Mountain",
            new List<string> { 
                "Mountain Time (US & Canada)", 
         }},
        { "Jamaica",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Kentucky/Louisville",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "Brazil/West",
            new List<string> { 
                "La Paz", 
         }},
        { "America/Atikokan",
            new List<string> { 
                "Bogota", 
         }},
        { "America/Porto_Acre",
            new List<string> { 
                "Bogota", 
         }},
        { "Brazil/Acre",
            new List<string> { 
                "Bogota", 
         }},
        { "Canada/Eastern",
            new List<string> { 
                "Eastern Time (US & Canada)", 
         }},
        { "Canada/Pacific",
            new List<string> { 
                "Pacific Time (US & Canada)", 
         }},
        { "Canada/Central",
            new List<string> { 
                "Central Time (US & Canada)", 
         }},
        { "Asia/Ashkhabad",
            new List<string> { 
                "Tashkent", 
         }},
        { "Asia/Ho_Chi_Minh",
            new List<string> { 
                "Bangkok", 
                "Hanoi", 
         }},
        { "Asia/Macao",
            new List<string> { 
                "Beijing", 
         }},
        { "Asia/Ujung_Pandang",
            new List<string> { 
                "Singapore", 
         }},
        { "Europe/Nicosia",
            new List<string> { 
                "Bucharest", 
         }},
        { "Asia/Thimbu",
            new List<string> { 
                "Astana", 
                "Dhaka", 
         }},
        { "WET",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "Atlantic/Faroe",
            new List<string> { 
                "Edinburgh", 
                "London", 
         }},
        { "HST",
            new List<string> { 
                "Hawaii", 
         }},
        { "EST",
            new List<string> { 
                "Bogota", 
         }},
        { "MST",
            new List<string> { 
                "Arizona", 
         }},
    };
}

