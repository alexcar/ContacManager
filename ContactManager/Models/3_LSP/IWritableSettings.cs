using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    public interface IWritableSettings
    {
        string SetSettings(Dictionary<string, string> settings);
    }
}
