using System.Collections.Generic;

namespace ContactManager.Models.LSP
{
    public interface IReadableSettings
    {
        Dictionary<string, string> GetSettings();
    }
}
