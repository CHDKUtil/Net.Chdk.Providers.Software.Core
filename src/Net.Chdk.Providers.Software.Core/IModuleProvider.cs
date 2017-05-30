namespace Net.Chdk.Providers.Software
{
    public interface IModuleProvider
    {
        string Path { get; }
        string Extension { get; }

        string GetModuleName(string filePath);
        string GetModuleTitle(string name);
        string GetModuleId(string name);
    }
}
