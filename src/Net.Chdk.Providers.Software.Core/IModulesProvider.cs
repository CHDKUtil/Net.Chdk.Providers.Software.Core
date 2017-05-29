using System.Collections.Generic;

namespace Net.Chdk.Providers.Software
{
    public interface IModulesProvider
    {
        string Path { get; }
        string Extension { get; }
        IDictionary<string, ModuleData> Children { get; }
    }
}
