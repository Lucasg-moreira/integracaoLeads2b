using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Interfaces
{
    public interface ILeadsRepository
    {
        public void Add(Leads leads);
        public int SaveChanges();
    }
}
