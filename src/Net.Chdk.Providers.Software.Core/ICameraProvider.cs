using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public interface ICameraProvider
    {
        CameraInfo GetCamera(Model.Camera.CameraInfo cameraInfo, Model.CameraModel.CameraModelInfo cameraModelInfo);
    }
}
