using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public sealed class ProductSource
    {
        public ProductSource(string productName, string sourceName, SoftwareSourceInfo source)
        {
            ProductName = productName;
            SourceName = sourceName;
            Source = source;
        }

        public string ProductName { get; }
        public string SourceName { get; }
        public SoftwareSourceInfo Source { get; }
    }
}
