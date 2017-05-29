using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public interface IEncodingProvider
    {
        SoftwareEncodingInfo GetEncoding(SoftwareProductInfo product, SoftwareCameraInfo camera);
    }
}
