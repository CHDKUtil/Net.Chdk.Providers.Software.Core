using Net.Chdk.Model.Software;
using System.IO;

namespace Net.Chdk.Providers.Software
{
    public interface ISoftwareHashProvider
    {
        SoftwareHashInfo GetHash(Stream stream, string fileName, string hashName);
        SoftwareHashInfo GetHash(byte[] buffer, string fileName, string hashName);
    }
}
