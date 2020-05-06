using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    public interface ISettings
    {
        Dictionary<string, string> GetSettings();
        string SetSettings(Dictionary<string, string> settings);
    }
}
