using System;
using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    // public class GlobalSettings : ISettings
    public class GlobalSettings : IReadableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            // fetches the settings from the database
            settings.Add("Theme", "Summer");

            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach(var item in settings)
            {
                // save to database
            }

            return "Global settings saved on " + DateTime.Now;
        }
    }
}
