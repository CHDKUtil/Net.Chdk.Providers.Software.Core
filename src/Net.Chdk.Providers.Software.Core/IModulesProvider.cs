namespace Net.Chdk.Providers.Software
{
    public interface IModulesProvider
    {
        string Path { get; }
        string Extension { get; }
    }
}
