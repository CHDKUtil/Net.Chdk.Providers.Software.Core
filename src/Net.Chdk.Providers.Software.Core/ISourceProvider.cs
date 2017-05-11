using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public interface ISourceProvider
    {
        SoftwareSourceInfo GetSource(SoftwareProductInfo product, string sourceName, string channelName);
    }
}
