using integracaoLeads2b.Entities;
using integracaoLeads2b.Helpers;
using integracaoLeads2b.Interfaces;

namespace integracaoLeads2b.Services
{
    public class OpportunityService : IOpportunityService
    {
        private IOpportunityRepository _opportunityRepository;
        private IIntegracaoHelper _integracaoHelper;

        public OpportunityService(
            IOpportunityRepository opportunityRepository,
            IIntegracaoHelper integracaoHelper
           ) { 
            _opportunityRepository = opportunityRepository;
            _integracaoHelper = integracaoHelper;
        }
        public int InsertRowsDb(string startAt, string finishAt, string token)
        {
            List<Opportunity> list = _integracaoHelper.GetOpportunities(startAt, finishAt, token);
             _opportunityRepository.AddRange(list);

            int result = _opportunityRepository.SaveChanges();

            if (result == 0)
                throw new Exception("Não foi possível inserir os registros no banco.");

            return result;
        }
    }
}
