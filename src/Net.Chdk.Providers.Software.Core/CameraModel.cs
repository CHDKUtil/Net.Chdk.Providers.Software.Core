using Net.Chdk.Model.Camera;
using Net.Chdk.Model.CameraModel;

namespace Net.Chdk.Providers.Software
{
    public sealed class CameraModel
    {
        public CameraInfo Info { get; set; }
        public CameraModelInfo Model { get; set; }
        public int? EncodingVersion { get; set; }
    }
}
