namespace Net.Chdk.Providers.Software
{
    public interface IModuleProviderResolver
    {
        IModuleProvider GetModuleProvider(string productName);
    }
}
