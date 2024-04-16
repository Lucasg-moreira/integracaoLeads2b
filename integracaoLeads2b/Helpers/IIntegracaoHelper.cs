using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Helpers
{
    public interface IIntegracaoHelper
    {
        public List<Leads> GetLeads(string startAt, string finishAt, string token);
        public List<Opportunity> GetOpportunities(string startAt, string finishAt, string token);
        public List<Prospect> GetProspects(string startAt, string finishAt, string token);
    }
}
