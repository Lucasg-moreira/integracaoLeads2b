using integracaoLeads2b.Entities;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Persistence;

namespace integracaoLeads2b.Repository
{
    public class ProspectRepository : IProspectRepository
    {
        private LeadsDbContext _context;
        public ProspectRepository(LeadsDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Prospect prospect)
        {
            if (prospect == null)
                return;

            _context.Prospects.Add(prospect);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
