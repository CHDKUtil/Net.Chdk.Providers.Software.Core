using Net.Chdk.Model.Category;
using Net.Chdk.Model.Software;
using System;
using System.Collections.Generic;

namespace Net.Chdk.Providers.Software
{
    public interface ISourceProvider
    {
        IEnumerable<Tuple<string, string, SoftwareSourceInfo>> GetSources(CategoryInfo category);
        IEnumerable<Tuple<string, string, SoftwareSourceInfo>> GetSources(SoftwareProductInfo product);
        IEnumerable<SoftwareSourceInfo> GetSources(SoftwareProductInfo product, string sourceName);
    }
}
