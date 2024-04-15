namespace integracaoLeads2b.Interfaces
{
    public interface IProspectService
    {
        public void InsertRowsDb(string startAt, string endAt, string token);
    }
}