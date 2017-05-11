using Net.Chdk.Model.Software;
using System.Collections.Generic;

namespace Net.Chdk.Providers.Software
{
    public interface IProductSourceProvider
    {
        IEnumerable<KeyValuePair<string, SoftwareSourceInfo>> GetSources(SoftwareProductInfo product);
        IEnumerable<SoftwareSourceInfo> GetSources(SoftwareProductInfo product, string sourceName);
    }
}
