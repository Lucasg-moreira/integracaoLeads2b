namespace integracaoLeads2b.Interfaces
{
    public interface IProspectService
    {
        public int InsertRowsDb(string startAt, string endAt, string token);
    }
}