namespace Net.Chdk.Providers.Software
{
    public interface IModulesProviderResolver
    {
        IModulesProvider GetModulesProvider(string productName);
    }
}
