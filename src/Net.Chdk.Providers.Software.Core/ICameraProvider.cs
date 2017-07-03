using Net.Chdk.Model.Camera;
using Net.Chdk.Model.CameraModel;
using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public interface ICameraProvider
    {
        SoftwareCameraInfo GetCamera(string productName, CameraInfo cameraInfo, CameraModelInfo cameraModelInfo);
        SoftwareEncodingInfo GetEncoding(SoftwareProductInfo productInfo, SoftwareCameraInfo cameraInfo);
    }
}
