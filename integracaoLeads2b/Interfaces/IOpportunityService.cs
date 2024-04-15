using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Interfaces
{
    public interface IOpportunityService
    {
        public int InsertRowsDb(string startAt, string endAt, string token);
    }
}
