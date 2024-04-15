using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Interfaces
{
    public interface IOpportunityService
    {
        public void InsertRowsDb(string startAt, string endAt, string token);
    }
}
