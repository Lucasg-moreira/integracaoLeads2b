using integracaoLeads2b.Entities;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Repository;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Identity.Client;
using System.Net;
using System.Net.Http.Headers;

namespace integracaoLeads2b.Services
{

    public class LeadsService : ILeadsService
    {
        private readonly ILeadsRepository _leadsRepository;

        private string url = "https://app.leads2b.com/api/v1";
        private string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJuYmYiOjE3MTI2MDYzMDMsImlhdCI6MTcxMjYwNjMwMywiY2giOiJxM21vcHFDVUlVWVRITHZkOU85V2Zqa3JUUkpQRWdkRSIsInVoIjpudWxsfQ.ivFx55wZjgkUM9SiaOf21vswc6b1T2O3t-69yE0FhA0";

        public LeadsService(ILeadsRepository leadsRepository)
        {
            _leadsRepository = leadsRepository;
        }

        public List<Leads> insertRowsDb(DateTime startAt, DateTime finishAt)
        {
            List<Leads> list = new List<Leads>();

            var leads_1 = new Leads
            {
                Lead_name = "Exemplo",
                Cnpj = "00000000000000",
                Main_contact = "Contato Principal",
                Main_email = "contato@exemplo.com",
                Main_phone = "(00) 0000-0000",
                Phone = "(00) 0000-0000",
                Email = "email@exemplo.com",
                Origin = "Origem",
                Lead_created_at = DateTime.Now,
                City = "Cidade",
                State = "GO",
                Lead_responsable = "Responsável",
                Lead_responsable_id = 1,
                Lead_status = "Status",
                Fk_id = 1,
                List_id = 1,
                Pipeline = "Pipeline",
                Pipeline_step = "Step",
                Lost_at = "Data de Perda",
                Loss_reason = "Motivo da Perda",
                Opportunity_created_at = DateTime.Now,
                Opportunity_id = 1,
                Opportunity_status = "Status da Oportunidade",
                Order_date = DateTime.Now,
                Order_total = 1000.00m,
                Customer_id = 1,
                Customer_name = "Nome do Cliente",
                Customer_company_name = "Empresa do Cliente"
            };

            Leads leads_2 = new Leads
            {
                Lead_name = "Exemplo2",
                Cnpj = "00000000000001",
                Main_contact = "Contato Secunbdario",
                Main_email = "contato@exemplo.com",
                Main_phone = "(00) 0000-0000",
                Phone = "(00) 0000-0000",
                Email = "email@exemplo.com",
                Origin = "Origem",
                Lead_created_at = DateTime.Now,
                City = "goiania",
                State = "GO",
                Lead_responsable = "Responsável",
                Lead_responsable_id = 1,
                Lead_status = "Ativo",
                Fk_id = 2,
                List_id = 2,
                Pipeline = "Pipeline",
                Pipeline_step = "Step",
                Lost_at = "Data de Perda",
                Loss_reason = "Motivo da Perda",
                Opportunity_created_at = DateTime.Now,
                Opportunity_id = 2,
                Opportunity_status = "Status da Oportunidade",
                Order_date = DateTime.Now,
                Order_total = 1000.00m,
                Customer_id = 2,
                Customer_name = "Nome do Cliente",
                Customer_company_name = "Empresa do Cliente"
            };

            //HttpContent content = getLeadsByApi(startAt, finishAt);

            //if (content == null)
            //    return new List<Leads>() ;

            _leadsRepository.Add(leads_1);
            _leadsRepository.Add(leads_2);

            _leadsRepository.SaveChanges();

            list.Add(leads_1);
            list.Add(leads_2);

            return list;
        }

        public HttpContent getLeadsByApi(DateTime startAt, DateTime finishAt)
        {
            HttpClient client = new HttpClient();

            string urlFormatted = $"{this.url}/leads/list?start_at={startAt}&finish_at={finishAt}";

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.token);

            HttpResponseMessage response = client.GetAsync(urlFormatted).GetAwaiter().GetResult();

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            return response.Content;
        }

    }
}
