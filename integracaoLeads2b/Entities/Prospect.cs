namespace integracaoLeads2b.Entities
{
    public class CustomField
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class Prospect
    {
        public int Prospect_id { get; set; }
        public string Prospect_name { get; set; }
        public string Company_name { get; set; }
        public string Cnpj { get; set; }
        public string Main_contact { get; set; }
        public string Main_email { get; set; }
        public string Main_phone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Created_at { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Origin { get; set; }
        public string Prospect_responsable { get; set; }
        public int Prospect_responsable_id { get; set; }
        public string Pipeline { get; set; }
        public string Pipeline_step { get; set; }
        public string Lost_at { get; set; }
        public string Loss_reason { get; set; }
        public int Active { get; set; }
        public string Tags { get; set; }
        public string Custom_fields { get; set; }
        public string Exclusion_reason { get; set; }
        public DateTime Deleted_at { get; set; }
        public DateTime Updated_at { get; set; }
        public int Enriched { get; set; }
        public string Social_reason { get; set; }
        public int Fk_id { get; set; }
        public int List_id { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string Department { get; set; }
    }
}
