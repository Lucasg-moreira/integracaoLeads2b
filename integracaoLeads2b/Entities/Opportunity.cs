namespace integracaoLeads2b.Entities
{
    public class Opportunity
    {
        public string Opportunity_id { get; set; }
        public string Rdstation_uuid { get; set; }
        public string Lead_id { get; set; }
        public string Pipeline { get; set; }
        public string Pipeline_step { get; set; }
        public string Contact_name { get; set; }
        public string Contact_email { get; set; }
        public string Contact_state { get; set; }
        public string Contact_city { get; set; }
        public string Contact_address { get; set; }
        public string Contact_street { get; set; }
        public string Contact_neighborhood { get; set; }
        public string Contact_number { get; set; }
        public string Contact_complement { get; set; }
        public string Contact_cnpj { get; set; }
        public string Contact_list_id { get; set; }
        public string Customer_id { get; set; }
        public string Customer_address { get; set; }
        public string Customer_neighborhood { get; set; }
        public string Customer_number { get; set; }
        public string Customer_complement { get; set; }
        public string Customer_city { get; set; }
        public string Customer_state { get; set; }
        public string Lead_status { get; set; }
        public string Opportunity_responsible { get; set; }
        public string Origin { get; set; }
        public string Lead_responsible { get; set; }
        public string Lead_responsible_id { get; set; }
        public DateTime Opportunity_created_at { get; set; }
        public string Opportunity_created_by { get; set; }
        public DateTime Opportunity_updated_at { get; set; }
        public string Expected_close_date { get; set; }
        public DateTime Reactived_at { get; set; }
        public string Opportunity_status { get; set; }
        public DateTime Lost_at { get; set; }
        public string Loss_reason { get; set; }
        public string Loss_details { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Item> Items { get; set; }
        public List<Quotation> Quotations { get; set; }
    }
}
