using System.Collections.Generic;

namespace Net.Chdk.Providers.Software
{
    public sealed class ModuleData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public IDictionary<string, ModuleData> Children { get; set; }
        public string[] Files { get; set; }
    }
}