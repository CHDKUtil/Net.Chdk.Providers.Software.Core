using Net.Chdk.Model.Software;
using System.IO;

namespace Net.Chdk.Providers.Software
{
    public interface ISoftwareHashProvider
    {
        SoftwareHashInfo GetHash(Stream stream, string fileName, string hashName);
    }
}
