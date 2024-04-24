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
            List<Prospect> list = _integracaoHelper.GetProspects(startAt, finishAt, token);
            _prospectRepository.AddRange(list);

            int result = _prospectRepository.SaveChanges();

            if (result == 0)
                throw new Exception("Não foi possível inserir os registros no banco.");

            return result;
        }
    }
}
