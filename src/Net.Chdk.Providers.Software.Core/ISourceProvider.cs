using Net.Chdk.Model.Software;
using System.Collections.Generic;

namespace Net.Chdk.Providers.Software
{
    public interface ISourceProvider
    {
        IEnumerable<KeyValuePair<string, SoftwareSourceInfo>> GetSources(SoftwareCategoryInfo category);
        IEnumerable<KeyValuePair<string, SoftwareSourceInfo>> GetSources(SoftwareProductInfo product);
        IEnumerable<SoftwareSourceInfo> GetSources(SoftwareProductInfo product, string sourceName);
    }
}
