namespace TimeZoneConverter.Data;

public static class Links
{
    public static IReadOnlyDictionary<string, string> Mappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
        { "Iceland","Africa/Abidjan" },
        { "Africa/Timbuktu","Africa/Abidjan" },
        { "Africa/Accra","Africa/Abidjan" },
        { "Africa/Bamako","Africa/Abidjan" },
        { "Africa/Banjul","Africa/Abidjan" },
        { "Africa/Conakry","Africa/Abidjan" },
        { "Africa/Dakar","Africa/Abidjan" },
        { "Africa/Freetown","Africa/Abidjan" },
        { "Africa/Lome","Africa/Abidjan" },
        { "Africa/Nouakchott","Africa/Abidjan" },
        { "Africa/Ouagadougou","Africa/Abidjan" },
        { "Atlantic/Reykjavik","Africa/Abidjan" },
        { "Atlantic/St_Helena","Africa/Abidjan" },
        { "Egypt","Africa/Cairo" },
        { "Africa/Maseru","Africa/Johannesburg" },
        { "Africa/Mbabane","Africa/Johannesburg" },
        { "Africa/Bangui","Africa/Lagos" },
        { "Africa/Brazzaville","Africa/Lagos" },
        { "Africa/Douala","Africa/Lagos" },
        { "Africa/Kinshasa","Africa/Lagos" },
        { "Africa/Libreville","Africa/Lagos" },
        { "Africa/Luanda","Africa/Lagos" },
        { "Africa/Malabo","Africa/Lagos" },
        { "Africa/Niamey","Africa/Lagos" },
        { "Africa/Porto-Novo","Africa/Lagos" },
        { "Africa/Blantyre","Africa/Maputo" },
        { "Africa/Bujumbura","Africa/Maputo" },
        { "Africa/Gaborone","Africa/Maputo" },
        { "Africa/Harare","Africa/Maputo" },
        { "Africa/Kigali","Africa/Maputo" },
        { "Africa/Lubumbashi","Africa/Maputo" },
        { "Africa/Lusaka","Africa/Maputo" },
        { "Africa/Asmara","Africa/Nairobi" },
        { "Africa/Addis_Ababa","Africa/Nairobi" },
        { "Africa/Dar_es_Salaam","Africa/Nairobi" },
        { "Africa/Djibouti","Africa/Nairobi" },
        { "Africa/Kampala","Africa/Nairobi" },
        { "Africa/Mogadishu","Africa/Nairobi" },
        { "Indian/Antananarivo","Africa/Nairobi" },
        { "Indian/Comoro","Africa/Nairobi" },
        { "Indian/Mayotte","Africa/Nairobi" },
        { "Africa/Asmera","Africa/Nairobi" },
        { "Libya","Africa/Tripoli" },
        { "America/Atka","America/Adak" },
        { "US/Aleutian","America/Adak" },
        { "US/Alaska","America/Anchorage" },
        { "America/Buenos_Aires","America/Argentina/Buenos_Aires" },
        { "America/Catamarca","America/Argentina/Catamarca" },
        { "America/Argentina/ComodRivadavia","America/Argentina/Catamarca" },
        { "America/Cordoba","America/Argentina/Cordoba" },
        { "America/Rosario","America/Argentina/Cordoba" },
        { "America/Jujuy","America/Argentina/Jujuy" },
        { "America/Mendoza","America/Argentina/Mendoza" },
        { "US/Central","America/Chicago" },
        { "America/Shiprock","America/Denver" },
        { "Navajo","America/Denver" },
        { "US/Mountain","America/Denver" },
        { "US/Michigan","America/Detroit" },
        { "Canada/Mountain","America/Edmonton" },
        { "America/Yellowknife","America/Edmonton" },
        { "Canada/Atlantic","America/Halifax" },
        { "Cuba","America/Havana" },
        { "America/Fort_Wayne","America/Indiana/Indianapolis" },
        { "America/Indianapolis","America/Indiana/Indianapolis" },
        { "US/East-Indiana","America/Indiana/Indianapolis" },
        { "America/Knox_IN","America/Indiana/Knox" },
        { "US/Indiana-Starke","America/Indiana/Knox" },
        { "America/Pangnirtung","America/Iqaluit" },
        { "Jamaica","America/Jamaica" },
        { "America/Louisville","America/Kentucky/Louisville" },
        { "US/Pacific","America/Los_Angeles" },
        { "US/Pacific-New","America/Los_Angeles" },
        { "Brazil/West","America/Manaus" },
        { "Mexico/BajaSur","America/Mazatlan" },
        { "Mexico/General","America/Mexico_City" },
        { "US/Eastern","America/New_York" },
        { "Brazil/DeNoronha","America/Noronha" },
        { "America/Godthab","America/Nuuk" },
        { "America/Atikokan","America/Panama" },
        { "America/Cayman","America/Panama" },
        { "America/Coral_Harbour","America/Panama" },
        { "US/Arizona","America/Phoenix" },
        { "America/Creston","America/Phoenix" },
        { "America/Virgin","America/Puerto_Rico" },
        { "America/Anguilla","America/Puerto_Rico" },
        { "America/Antigua","America/Puerto_Rico" },
        { "America/Aruba","America/Puerto_Rico" },
        { "America/Blanc-Sablon","America/Puerto_Rico" },
        { "America/Curacao","America/Puerto_Rico" },
        { "America/Dominica","America/Puerto_Rico" },
        { "America/Grenada","America/Puerto_Rico" },
        { "America/Guadeloupe","America/Puerto_Rico" },
        { "America/Kralendijk","America/Puerto_Rico" },
        { "America/Lower_Princes","America/Puerto_Rico" },
        { "America/Marigot","America/Puerto_Rico" },
        { "America/Montserrat","America/Puerto_Rico" },
        { "America/Port_of_Spain","America/Puerto_Rico" },
        { "America/St_Barthelemy","America/Puerto_Rico" },
        { "America/St_Kitts","America/Puerto_Rico" },
        { "America/St_Lucia","America/Puerto_Rico" },
        { "America/St_Thomas","America/Puerto_Rico" },
        { "America/St_Vincent","America/Puerto_Rico" },
        { "America/Tortola","America/Puerto_Rico" },
        { "Canada/East-Saskatchewan","America/Regina" },
        { "Canada/Saskatchewan","America/Regina" },
        { "America/Porto_Acre","America/Rio_Branco" },
        { "Brazil/Acre","America/Rio_Branco" },
        { "Chile/Continental","America/Santiago" },
        { "Brazil/East","America/Sao_Paulo" },
        { "Canada/Newfoundland","America/St_Johns" },
        { "America/Ensenada","America/Tijuana" },
        { "Mexico/BajaNorte","America/Tijuana" },
        { "America/Santa_Isabel","America/Tijuana" },
        { "America/Montreal","America/Toronto" },
        { "Canada/Eastern","America/Toronto" },
        { "America/Nassau","America/Toronto" },
        { "America/Nipigon","America/Toronto" },
        { "America/Thunder_Bay","America/Toronto" },
        { "Canada/Pacific","America/Vancouver" },
        { "Canada/Yukon","America/Whitehorse" },
        { "Canada/Central","America/Winnipeg" },
        { "America/Rainy_River","America/Winnipeg" },
        { "Asia/Ashkhabad","Asia/Ashgabat" },
        { "Asia/Phnom_Penh","Asia/Bangkok" },
        { "Asia/Vientiane","Asia/Bangkok" },
        { "Indian/Christmas","Asia/Bangkok" },
        { "Asia/Dacca","Asia/Dhaka" },
        { "Asia/Muscat","Asia/Dubai" },
        { "Indian/Mahe","Asia/Dubai" },
        { "Indian/Reunion","Asia/Dubai" },
        { "Asia/Saigon","Asia/Ho_Chi_Minh" },
        { "Hongkong","Asia/Hong_Kong" },
        { "Asia/Tel_Aviv","Asia/Jerusalem" },
        { "Israel","Asia/Jerusalem" },
        { "Asia/Katmandu","Asia/Kathmandu" },
        { "Asia/Calcutta","Asia/Kolkata" },
        { "Asia/Brunei","Asia/Kuching" },
        { "Asia/Macao","Asia/Macau" },
        { "Asia/Ujung_Pandang","Asia/Makassar" },
        { "Europe/Nicosia","Asia/Nicosia" },
        { "Asia/Bahrain","Asia/Qatar" },
        { "Antarctica/Syowa","Asia/Riyadh" },
        { "Asia/Aden","Asia/Riyadh" },
        { "Asia/Kuwait","Asia/Riyadh" },
        { "ROK","Asia/Seoul" },
        { "Asia/Chongqing","Asia/Shanghai" },
        { "Asia/Chungking","Asia/Shanghai" },
        { "Asia/Harbin","Asia/Shanghai" },
        { "PRC","Asia/Shanghai" },
        { "Singapore","Asia/Singapore" },
        { "Asia/Kuala_Lumpur","Asia/Singapore" },
        { "ROC","Asia/Taipei" },
        { "Iran","Asia/Tehran" },
        { "Asia/Thimbu","Asia/Thimphu" },
        { "Japan","Asia/Tokyo" },
        { "Asia/Ulan_Bator","Asia/Ulaanbaatar" },
        { "Asia/Kashgar","Asia/Urumqi" },
        { "Antarctica/Vostok","Asia/Urumqi" },
        { "Asia/Rangoon","Asia/Yangon" },
        { "Indian/Cocos","Asia/Yangon" },
        { "WET","Atlantic/Canary" },
        { "Atlantic/Faeroe","Atlantic/Faroe" },
        { "Australia/South","Australia/Adelaide" },
        { "Australia/Queensland","Australia/Brisbane" },
        { "Australia/Yancowinna","Australia/Broken_Hill" },
        { "Australia/North","Australia/Darwin" },
        { "Australia/Tasmania","Australia/Hobart" },
        { "Australia/Currie","Australia/Hobart" },
        { "Australia/LHI","Australia/Lord_Howe" },
        { "Australia/Victoria","Australia/Melbourne" },
        { "Australia/West","Australia/Perth" },
        { "Australia/ACT","Australia/Sydney" },
        { "Australia/Canberra","Australia/Sydney" },
        { "Australia/NSW","Australia/Sydney" },
        { "HST","Etc/GMT+10" },
        { "EST","Etc/GMT+5" },
        { "MST","Etc/GMT+7" },
        { "Etc/GMT+0","Etc/UTC" },
        { "Etc/GMT-0","Etc/UTC" },
        { "Etc/GMT0","Etc/UTC" },
        { "Etc/Greenwich","Etc/UTC" },
        { "GMT","Etc/UTC" },
        { "GMT+0","Etc/UTC" },
        { "GMT-0","Etc/UTC" },
        { "GMT0","Etc/UTC" },
        { "Greenwich","Etc/UTC" },
        { "Etc/UCT","Etc/UTC" },
        { "Etc/Universal","Etc/UTC" },
        { "Etc/Zulu","Etc/UTC" },
        { "UCT","Etc/UTC" },
        { "UTC","Etc/UTC" },
        { "Universal","Etc/UTC" },
        { "Zulu","Etc/UTC" },
        { "Etc/GMT","Etc/UTC" },
        { "Europe/Ljubljana","Europe/Belgrade" },
        { "Europe/Podgorica","Europe/Belgrade" },
        { "Europe/Sarajevo","Europe/Belgrade" },
        { "Europe/Skopje","Europe/Belgrade" },
        { "Europe/Zagreb","Europe/Belgrade" },
        { "Atlantic/Jan_Mayen","Europe/Berlin" },
        { "Arctic/Longyearbyen","Europe/Berlin" },
        { "Europe/Copenhagen","Europe/Berlin" },
        { "Europe/Oslo","Europe/Berlin" },
        { "Europe/Stockholm","Europe/Berlin" },
        { "MET","Europe/Berlin" },
        { "Europe/Amsterdam","Europe/Brussels" },
        { "Europe/Luxembourg","Europe/Brussels" },
        { "EET","Europe/Bucharest" },
        { "Europe/Tiraspol","Europe/Chisinau" },
        { "Eire","Europe/Dublin" },
        { "Europe/Mariehamn","Europe/Helsinki" },
        { "Asia/Istanbul","Europe/Istanbul" },
        { "Turkey","Europe/Istanbul" },
        { "Europe/Kiev","Europe/Kyiv" },
        { "Europe/Uzhgorod","Europe/Kyiv" },
        { "Europe/Zaporozhye","Europe/Kyiv" },
        { "Portugal","Europe/Lisbon" },
        { "Europe/Belfast","Europe/London" },
        { "GB","Europe/London" },
        { "GB-Eire","Europe/London" },
        { "Europe/Guernsey","Europe/London" },
        { "Europe/Isle_of_Man","Europe/London" },
        { "Europe/Jersey","Europe/London" },
        { "W-SU","Europe/Moscow" },
        { "CET","Europe/Paris" },
        { "Europe/Monaco","Europe/Paris" },
        { "Europe/Bratislava","Europe/Prague" },
        { "Europe/San_Marino","Europe/Rome" },
        { "Europe/Vatican","Europe/Rome" },
        { "Poland","Europe/Warsaw" },
        { "Europe/Busingen","Europe/Zurich" },
        { "Europe/Vaduz","Europe/Zurich" },
        { "Indian/Kerguelen","Indian/Maldives" },
        { "Antarctica/South_Pole","Pacific/Auckland" },
        { "NZ","Pacific/Auckland" },
        { "Antarctica/McMurdo","Pacific/Auckland" },
        { "NZ-CHAT","Pacific/Chatham" },
        { "Chile/EasterIsland","Pacific/Easter" },
        { "Pacific/Pohnpei","Pacific/Guadalcanal" },
        { "Pacific/Ponape","Pacific/Guadalcanal" },
        { "Pacific/Saipan","Pacific/Guam" },
        { "US/Hawaii","Pacific/Honolulu" },
        { "Pacific/Johnston","Pacific/Honolulu" },
        { "Pacific/Enderbury","Pacific/Kanton" },
        { "Kwajalein","Pacific/Kwajalein" },
        { "Pacific/Samoa","Pacific/Pago_Pago" },
        { "US/Samoa","Pacific/Pago_Pago" },
        { "Pacific/Midway","Pacific/Pago_Pago" },
        { "Pacific/Chuuk","Pacific/Port_Moresby" },
        { "Pacific/Yap","Pacific/Port_Moresby" },
        { "Antarctica/DumontDUrville","Pacific/Port_Moresby" },
        { "Pacific/Truk","Pacific/Port_Moresby" },
        { "Pacific/Funafuti","Pacific/Tarawa" },
        { "Pacific/Majuro","Pacific/Tarawa" },
        { "Pacific/Wake","Pacific/Tarawa" },
        { "Pacific/Wallis","Pacific/Tarawa" },
    };
}

