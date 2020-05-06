using System;
using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    // public class GuestSettings : ISettings
    public class GuestSettings : IReadableSettings
    {
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settings = new Dictionary<string, string>();

            // fetches the settings from the database
            settings.Add("GuestName", "John");

            return settings;
        }

        //public string SetSettings(Dictionary<string, string> settings)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
