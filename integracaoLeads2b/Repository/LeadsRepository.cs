using integracaoLeads2b.Entities;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Persistence;
using Microsoft.EntityFrameworkCore;

namespace integracaoLeads2b.Repository
{
    public class LeadsRepository : ILeadsRepository
    {
        private readonly LeadsDbContext _context;
        public LeadsRepository(LeadsDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Leads leads)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            Console.WriteLine(leads);
            _context.Leads.Add(leads);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void AddRange(List<Leads> leadsList)
        {
            _context.Leads.AddRange(leadsList);
        }
    }
}
