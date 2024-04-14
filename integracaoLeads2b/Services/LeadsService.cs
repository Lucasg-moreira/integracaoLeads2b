using integracaoLeads2b.Entities;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Identity.Client;
using System.Net;
using System.Net.Http.Headers;

namespace integracaoLeads2b.Services
{

    public class LeadsService
    {
        private string url = "https://app.leads2b.com/api/v1";
        private string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJuYmYiOjE3MTI2MDYzMDMsImlhdCI6MTcxMjYwNjMwMywiY2giOiJxM21vcHFDVUlVWVRITHZkOU85V2Zqa3JUUkpQRWdkRSIsInVoIjpudWxsfQ.ivFx55wZjgkUM9SiaOf21vswc6b1T2O3t-69yE0FhA0";

        public List<Leads> getLeadsByApi(DateTime startAt, DateTime finishAt)
        {
            Leads leads = new Leads();
            List<Leads> list = new List<Leads>();

            HttpClient client = new HttpClient();
            string urlFormatted = $"{this.url}/leads/list?start_at={startAt}&finish_at={finishAt}";
            
            Console.WriteLine(urlFormatted);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.token);

            var response = client.GetAsync(urlFormatted).GetAwaiter().GetResult();
               
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            Console.WriteLine(response);

            return list;
        }


    }
}
