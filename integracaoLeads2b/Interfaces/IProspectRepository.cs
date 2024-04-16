using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Interfaces
{
    public interface IProspectRepository
    {
        public void Add(Prospect prospect);
        public int SaveChanges();
        public void AddRange(List<Prospect> prospectList);
    }
}