using Net.Chdk.Model.Camera;
using Net.Chdk.Model.CameraModel;
using Net.Chdk.Model.Software;

namespace Net.Chdk.Providers.Software
{
    public sealed class CameraModel
    {
        public CameraInfo Info { get; set; }
        public CameraModelInfo Model { get; set; }
        public SoftwareEncodingInfo Encoding { get; set; }
    }
}
