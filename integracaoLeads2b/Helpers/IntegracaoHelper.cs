using System.Net.Http.Headers;
using System.Net;
using integracaoLeads2b.Services;
using System.Text.Json;
using integracaoLeads2b.Entities;
using Newtonsoft.Json.Linq;
using integracaoLeads2b.Interfaces;

namespace integracaoLeads2b.Helpers
{
    public class IntegracaoHelper : IIntegracaoHelper
    {
        private string url = "https://app.leads2b.com/api/v1";
        private IHttpRequest _httpRequestService;
        public IntegracaoHelper(IHttpRequest httpRequest) {
            _httpRequestService = httpRequest;
        }

        public List<Leads> GetLeads(string startAt, string finishAt, string token)
        {
            string urlFormatted = $"{url}/leads/list?start_at={startAt}&finish_at={finishAt}";

            string content = _httpRequestService.Get(urlFormatted, token);

            List<Leads>? contentMapped = JsonSerializer.Deserialize<List<Leads>>(content);

            return contentMapped;
        }

        public List<Opportunity> GetOpportunities(string startAt, string finishAt, string token)
        {
            string urlFormatted = $"{url}/opportunities/list?start_at={startAt}&finish_at={finishAt}";

            string content = _httpRequestService.Get(urlFormatted, token);
           
            List<Opportunity>? contentMapped = JsonSerializer.Deserialize<List<Opportunity>>(content);

            return contentMapped;
        }

        public List<Prospect> GetProspects(string startAt, string finishAt, string token)
        {

            string urlFormatted = $"{url}/prospects/list?start_at={startAt}&finish_at={finishAt}";

            string content = _httpRequestService.Get(urlFormatted, token);

            List<Prospect>? contentMapped = JsonSerializer.Deserialize<List<Prospect>>(content);

            return contentMapped;
        }

    }
}
