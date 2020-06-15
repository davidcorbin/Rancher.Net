using Newtonsoft.Json;

namespace Rancher.Net.API.Response.Cluster
{
    public partial class GenerateKubeconfigResponse
    {
        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("config")]
        public string Config { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
