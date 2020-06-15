using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rancher.Net.API.Response.Cluster;

namespace Rancher.Net.API
{
    public class Cluster
    {
        private HttpClient _httpClient;
        private String _rancherApiBaseUrl;
        
        public Cluster(HttpClient httpClient, String rancherApiBaseUrl)
        {
            _httpClient = httpClient;
            _rancherApiBaseUrl = rancherApiBaseUrl;
        }
        
        public async Task<ClusterResponse> List()
        {
            using (var response = await _httpClient.GetAsync(_rancherApiBaseUrl + "/clusters"))
            {
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                ClusterResponse a = JsonConvert.DeserializeObject<ClusterResponse>(content);

                return a;
            }
        }
    }
}
