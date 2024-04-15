using System.Net.Http.Headers;
using System.Net;

namespace integracaoLeads2b.Helpers
{
    public class IntegracaoHelper
    {
        private string token = "tmp";
        private string url = "https://app.leads2b.com/api/v1";
        public IntegracaoHelper() { }

        public HttpContent GetLeads(DateTime startAt, DateTime finishAt)
        {
            HttpClient client = new HttpClient();

            string urlFormatted = $"{this.url}/leads/list?start_at={startAt}&finish_at={finishAt}";

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.token);

            HttpResponseMessage response = client.GetAsync(urlFormatted).GetAwaiter().GetResult();

            // tratamento da response

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return response.Content;
        }

        public HttpContent GetOpportunities(string startAt, string finishAt)
        {
            HttpClient client = new HttpClient();

            string urlFormatted = $"{url}/opportunities/list?start_at={startAt}&finish_at={finishAt}";

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.token);

            HttpResponseMessage response = client.GetAsync(urlFormatted).GetAwaiter().GetResult();

            //tratamento da response

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return response.Content;
        }

    }
}
