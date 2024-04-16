using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Interfaces
{
    public interface IOpportunityRepository
    {
        public void Add(Opportunity opportunity);
        public int SaveChanges();
        public void AddRange(List<Opportunity> opportunityList);
    }
}
