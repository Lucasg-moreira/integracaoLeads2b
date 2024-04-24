namespace integracaoLeads2b.Entities
{
    public class Leads
    {
        public string Lead_id { get; set; }
        public string Lead_name { get; set; }
        public string Cnpj { get; set; }
        public string Main_contact { get; set; }
        public string Main_email { get; set; }
        public string Main_phone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Origin { get; set; }
        public string Lead_created_at { get; set; }
        public string City { get; set; }
        public string? State { get; set; }
        public string Lead_responsable { get; set; }
        public string Lead_responsable_id { get; set; }
        public string Lead_status { get; set; }
        public int? Fk_id { get; set; }
        public int? List_id { get; set; }
        public string Pipeline { get; set; }
        public string Pipeline_step { get; set; }
        public string? Lost_at { get; set; }
        public string? Loss_reason { get; set; }
        public string? Opportunity_created_at { get; set; }
        public string? Opportunity_id { get; set; }
        public string? Opportunity_status { get; set; }
        public string? Order_date { get; set; }
        public decimal? Order_total { get; set; }
        public string Customer_id { get; set; }
        public string Customer_name { get; set; }
        public string Customer_company_name { get; set; }
    }
}
