using integracaoLeads2b.Entities;
using integracaoLeads2b.Helpers;
using integracaoLeads2b.Interfaces;

namespace integracaoLeads2b.Services
{
    public class ProspectService : IProspectService
    {
        private IIntegracaoHelper _integracaoHelper;
        private IProspectRepository _prospectRepository;

        public ProspectService(
            IProspectRepository prospectRepository,
            IIntegracaoHelper  integracaoHelper
            )
        {
            _integracaoHelper = integracaoHelper;
            _prospectRepository = prospectRepository;
        }
        public int InsertRowsDb(string startAt, string finishAt, string token)
        {
            Prospect prospect_1 = new Prospect
            {
                Prospect_name = "ABC Company",
                Company_name = "ABC Company Ltd.",
                Cnpj = "12345678901234",
                Main_contact = "John Doe",
                Main_email = "john@example.com",
                Main_phone = "123-456-7890",
                Phone = "987-654-3210",
                Email = "info@abccompany.com",
                Created_at = DateTime.UtcNow,
                City = "New York",
                State = "NY",
                Origin = "Website",
                Prospect_responsable = "Jane Smith",
                Prospect_responsable_id = 2,
                Pipeline = "Sales Pipeline",
                Pipeline_step = "Initial Contact",
                Lost_at = "2023-01-15",
                Loss_reason = "Lost Reason",
                Active = 1,
                Tags = "tag1, tag2, tag3",
                Exclusion_reason = "Exclusion Reason",
                Deleted_at = DateTime.UtcNow,
                Updated_at = DateTime.UtcNow,
                Enriched = 1,
                Social_reason = "Social Reason",
                Fk_id = 3,
                List_id = 4,
                Country = "USA",
                Zipcode = "10001",
                Street = "123 Main St",
                Complement = "Apt 101",
                Neighborhood = "Downtown",
                Department = "Sales",
                Custom_fields = "{\"Label\": \"Custom Label\", \"Value\": \"Custom Value\"}"
            };

            Prospect prospect_2 = new Prospect
            {
                Prospect_name = "ProspectName2",
                Company_name = "CompanyName2",
                Cnpj = "12345678901234",
                Main_contact = "MainContact2",
                Main_email = "maincontact2@example.com",
                Main_phone = "987654321",
                Phone = "12345678",
                Email = "email2@example.com",
                Created_at = DateTime.UtcNow,
                City = "City2",
                State = "ST",
                Origin = "Origin2",
                Prospect_responsable = "ProspectResponsible2",
                Prospect_responsable_id = 2,
                Pipeline = "Pipeline2",
                Pipeline_step = "PipelineStep2",
                Lost_at = "LostAt2",
                Loss_reason = "LossReason2",
                Active = 1,
                Tags = "Tags2",
                Exclusion_reason = "ExclusionReason2",
                Deleted_at = DateTime.UtcNow,
                Updated_at = DateTime.UtcNow,
                Enriched = 1,
                Social_reason = "SocialReason2",
                Fk_id = 2,
                List_id = 2,
                Country = "Country2",
                Zipcode = "12345678",
                Street = "Street2",
                Complement = "Complement2",
                Neighborhood = "Neighborhood2",
                Department = "Department2",
                Custom_fields = "{\"Label\": \"Custom Label\", \"Value\": \"Custom Value\"}"
            };

            // List<Prospect> list = _integracaoHelper.GetProspects(startAt, finishAt, token);
            // _prospectRepository.AddRange(list);

            _prospectRepository.Add(prospect_1);
            _prospectRepository.Add(prospect_2);

            int result = _prospectRepository.SaveChanges();

            if (result == 0)
                throw new Exception("Não foi possível inserir os registros no banco.");

            return result;
        }
    }
}
