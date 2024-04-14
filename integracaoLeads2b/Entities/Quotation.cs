namespace integracaoLeads2b.Entities
{
    public class Quotation
    {
        public string Id { get; set; }
        public DateTime Created_at { get; set; }
        public string Id_customer { get; set; }
        public string Approved { get; set; }
        public List<QuotationItem> Items { get; set; }
    }
}
