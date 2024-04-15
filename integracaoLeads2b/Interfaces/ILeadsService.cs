using integracaoLeads2b.Entities;
using integracaoLeads2b.Repository;

namespace integracaoLeads2b.Interfaces
{
    public interface ILeadsService
    {
        public List<Leads> InsertRowsDb(DateTime startAt, DateTime finishAt);

    }
}
