using Net.Chdk.Model.Category;
using Net.Chdk.Model.Software;
using System.Collections.Generic;

namespace Net.Chdk.Providers.Software
{
    public interface IProductSourceProvider
    {
        string ProductName { get; }
        IEnumerable<KeyValuePair<string, SoftwareSourceInfo>> GetSources(CategoryInfo category);
        IEnumerable<KeyValuePair<string, SoftwareSourceInfo>> GetSources(SoftwareProductInfo product);
        IEnumerable<SoftwareSourceInfo> GetSources(SoftwareProductInfo product, string sourceName);
    }
}
