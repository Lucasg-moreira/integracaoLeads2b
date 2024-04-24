
using System.Text.Json;
using integracaoLeads2b.Entities;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Dtos;


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
            List <Leads> list = new List<Leads>();

            string urlFormatted = $"{url}/leads/list?start_at={startAt}&finish_at={finishAt}";

            string content = _httpRequestService.Get(urlFormatted, token);

            JsonSerializerOptions options = CreateJsonMapOptions();

            ReadLeadsDto contentMapped = JsonSerializer.Deserialize<ReadLeadsDto>(content, options)!;

            if (contentMapped.Result != null)
            {
                list.AddRange(contentMapped.Result);
            }

            return list;
        }

        private JsonSerializerOptions CreateJsonMapOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            return options;
        }

        public List<Opportunity> GetOpportunities(string startAt, string finishAt, string token)
        {
            List<Opportunity> list = new List<Opportunity>();

            string urlFormatted = $"{url}/opportunities/list?start_at={startAt}&finish_at={finishAt}";

            string content = _httpRequestService.Get(urlFormatted, token);

            JsonSerializerOptions options = CreateJsonMapOptions();

            ReadOpportunityDto contentMapped = JsonSerializer.Deserialize<ReadOpportunityDto>(content, options);

            if (contentMapped.Result != null)
            {
                list.AddRange(contentMapped.Result);
            }

            return list;
        }

        public List<Prospect> GetProspects(string startAt, string finishAt, string token)
        {

            string urlFormatted = $"{url}/prospect/list?start_at={startAt}&finish_at={finishAt}";

            var content = _httpRequestService.Get(urlFormatted, token);


           //List<Prospect>? contentMapped = JsonSerializer.Deserialize<List<Prospect>>(content.Result);

                //return contentMapped;

            return new List<Prospect> { };


        }

    }
}
