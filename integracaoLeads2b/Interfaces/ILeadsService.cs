using integracaoLeads2b.Entities;
using integracaoLeads2b.Repository;

namespace integracaoLeads2b.Interfaces
{
    public interface ILeadsService
    {
        public List<Leads> insertRowsDb(DateTime startAt, DateTime finishAt);
        public HttpContent getLeadsByApi(DateTime startAt, DateTime finishAt);

    }
}
