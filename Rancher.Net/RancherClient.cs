using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Rancher.Net.API;

namespace Rancher.Net
{
    public class RancherClient
    {
        private HttpClient _httpClient;
        private String _rancherUrl;
        private String _rancherApiVersion;
        
        public RancherClient(String rancherUrl, String bearerToken, String apiVersion="v3")
        {
            _rancherUrl = rancherUrl;
            _rancherApiVersion = apiVersion;
            
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        }

        private String GetRancherApiBaseUrl()
        {
            var baseUri = new Uri(_rancherUrl);
            return new Uri(baseUri, _rancherApiVersion).AbsoluteUri;
        }

        public Cluster Clusters()
        {
            return new Cluster(_httpClient, GetRancherApiBaseUrl());
        }
    }
}