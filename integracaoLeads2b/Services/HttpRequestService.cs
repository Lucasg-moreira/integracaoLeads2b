using integracaoLeads2b.Interfaces;
using System.Net.Http.Headers;

namespace integracaoLeads2b.Services
{
    public class HttpRequestService : IHttpRequest
    {
        public string Get(string url, string token)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            HttpResponseMessage response = client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
