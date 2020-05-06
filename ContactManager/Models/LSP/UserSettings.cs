using System;
using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    // public class UserSettings : ISettings
    public class UserSettings : IReadableSettings, IWritableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            // fetches the settings from the database
            settings.Add("DisplayName", "AlexCar");

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
