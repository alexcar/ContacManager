using System;
using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    // public class SectionSettings : ISettings 
    public class SectionSettings : IReadableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            // fetches the settings from the database
            settings.Add("Title", "Sports");

            return settings;
        }

        public string SetSettings(Dictionary<string, string> settings)
        {
            foreach (var item in settings)
            {
                // save to database
            }

            return "Global settings saved on " + DateTime.Now;
        }
    }
}
