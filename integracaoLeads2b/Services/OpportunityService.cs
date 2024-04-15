using integracaoLeads2b.Entities;
using integracaoLeads2b.Helpers;
using integracaoLeads2b.Interfaces;

namespace integracaoLeads2b.Services
{
    public class OpportunityService : IOpportunityService
    {
        private IntegracaoHelper _helper = new IntegracaoHelper();
        private IOpportunityRepository _opportunityRepository;

        public OpportunityService(IOpportunityRepository opportunityRepository) { 
            _opportunityRepository = opportunityRepository;
        }
        public int InsertRowsDb(string startAt, string finishAt, string token)
        {
            List<Opportunity> list = new List<Opportunity>();

            HttpContent content = _helper.GetOpportunities(startAt, finishAt, token);

            // add logica dos dados com api up

            Opportunity opportunity_1 = new Opportunity
            {
                Opportunity_id = "3",
                Rdstation_uuid = "123456",
                Lead_id = "789",
                Pipeline = "Vendas",
                Pipeline_step = "Negociação",
                Contact_name = "João",
                Contact_email = "joao@example.com",
                Contact_state = "SP",
                Contact_city = "São Paulo",
                Contact_address = "Rua Exemplo, 123",
                Contact_street = "Rua Exemplo",
                Contact_neighborhood = "Centro",
                Contact_number = "123456789",
                Contact_complement = "Apto 101",
                Contact_cnpj = "12345678901234",
                Contact_list_id = "987",
                Customer_id = "456",
                Customer_address = "Av. Principal, 456",
                Customer_neighborhood = "Bairro Novo",
                Customer_number = "987654321",
                Customer_complement = "Casa",
                Customer_city = "Curitiba",
                Customer_state = "PR",
                Lead_status = "Em andamento",
                Opportunity_responsible = "Maria",
                Origin = "Site",
                Lead_responsible = "Pedro",
                Lead_responsible_id = "123",
                Opportunity_created_at = DateTime.Now,
                Opportunity_created_by = "Alice",
                Opportunity_updated_at = DateTime.Now,
                Expected_close_date = "2023-12-31",
                Reactived_at = DateTime.Now,
                Opportunity_status = "Em andamento",
                Lost_at = DateTime.Now,
                Loss_reason = "Perda",
                Loss_details = "Detalhes da perda"
            };

            Opportunity opportunity_2 = new Opportunity
            {
                Opportunity_id = "4",
                Rdstation_uuid = "654321",
                Lead_id = "987",
                Pipeline = "Marketing",
                Pipeline_step = "Análise",
                Contact_name = "Maria",
                Contact_email = "maria@example.com",
                Contact_state = "RJ",
                Contact_city = "Rio de Janeiro",
                Contact_address = "Av. Rio, 456",
                Contact_street = "Av. Rio",
                Contact_neighborhood = "Copacabana",
                Contact_number = "987654321",
                Contact_complement = "Loja 2",
                Contact_cnpj = "98765432109876",
                Contact_list_id = "654",
                Customer_id = "789",
                Customer_address = "Rua Central, 789",
                Customer_neighborhood = "Centro",
                Customer_number = "123456789",
                Customer_complement = "Sala 101",
                Customer_city = "Belo Horizonte",
                Customer_state = "MG",
                Lead_status = "Concluído",
                Opportunity_responsible = "Pedro",
                Origin = "Telefone",
                Lead_responsible = "João",
                Lead_responsible_id = "456",
                Opportunity_created_at = DateTime.Now,
                Opportunity_created_by = "Alice",
                Opportunity_updated_at = DateTime.Now,
                Expected_close_date = "2023-11-30",
                Reactived_at = DateTime.Now,
                Opportunity_status = "Concluído",
                Lost_at = DateTime.Now,
                Loss_reason = "Outro",
                Loss_details = "Detalhes da perda"
            };

            _opportunityRepository.Add(opportunity_1);
            _opportunityRepository.Add(opportunity_2);

            int result = _opportunityRepository.SaveChanges();

            if (result == 0)
                throw new Exception("Não foi possível inserir os registros no banco.");

            return result;
        }
    }
}
