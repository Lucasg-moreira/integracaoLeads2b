using integracaoLeads2b.Entities;
using integracaoLeads2b.Repository;

namespace integracaoLeads2b.Interfaces
{
    public interface ILeadsService
    {
        public int InsertRowsDb(string startAt, string finishAt, string token);
    }
}
