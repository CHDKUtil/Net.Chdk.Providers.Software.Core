using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public interface ISourceProvider
    {
        SoftwareSourceInfo GetSource(string productName, string sourceName, string channelName);
    }
}
