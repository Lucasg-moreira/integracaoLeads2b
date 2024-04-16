using integracaoLeads2b.Entities;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Persistence;

namespace integracaoLeads2b.Repository
{
    public class OpportunityRepository : IOpportunityRepository
    {
        private LeadsDbContext _context; 
        public OpportunityRepository(LeadsDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Opportunity opportunity)
        {
            if (opportunity == null)
                return;

            _context.Opportunity.Add(opportunity);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void AddRange(List<Opportunity> opportunityList)
        {
             _context.Opportunity.AddRange(opportunityList);
        }
    }
}
