using integracaoLeads2b.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json.Serialization;

namespace integracaoLeads2b.Persistence
{
    public class LeadsDbContext : DbContext
    {
        public LeadsDbContext(DbContextOptions<LeadsDbContext> options) : base(options)
        { }

        public DbSet<Leads> Leads { get; set; }
        public DbSet<Prospect> Prospects { get; set; }
        public DbSet<Opportunity> Opportunity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Leads>(lead =>
            {
                lead.HasKey(l => l.Lead_id);

                lead.Property(l => l.Lead_name).IsRequired().HasColumnType("varchar(100)");
                lead.Property(l => l.Cnpj).HasColumnType("varchar(14)");
                lead.Property(l => l.Main_contact).IsRequired().HasColumnType("varchar(100)");
                lead.Property(l => l.Main_email).IsRequired().HasColumnType("varchar(100)");
                lead.Property(l => l.Main_phone).IsRequired().HasColumnType("varchar(20)");
                lead.Property(l => l.Phone).HasColumnType("varchar(20)");
                lead.Property(l => l.Email).IsRequired().HasColumnType("varchar(100)");
                lead.Property(l => l.Origin).HasColumnType("varchar(50)");
                lead.Property(l => l.Lead_created_at).IsRequired().HasColumnName("Lead_Created_at").HasColumnType("varchar(30)");
                lead.Property(l => l.City).HasColumnType("varchar(100)");
                lead.Property(l => l.State).HasColumnType("varchar(2)");
                lead.Property(l => l.Lead_responsable).HasColumnType("varchar(100)");
                lead.Property(l => l.Lead_responsable_id).HasColumnType("varchar(10)");
                lead.Property(l => l.Lead_status).HasColumnType("varchar(50)");
                lead.Property(l => l.Fk_id).HasColumnType("varchar(10)");
                lead.Property(l => l.List_id).HasColumnType("varchar(10)");
                lead.Property(l => l.Pipeline).HasColumnType("varchar(50)");
                lead.Property(l => l.Pipeline_step).HasColumnType("varchar(50)");
                lead.Property(l => l.Lost_at).HasColumnType("varchar(100)");
                lead.Property(l => l.Loss_reason).HasColumnType("varchar(100)");
                lead.Property(l => l.Opportunity_created_at).HasColumnType("varchar(30)");
                lead.Property(l => l.Opportunity_id).HasColumnType("varchar(10)");
                lead.Property(l => l.Opportunity_status).HasColumnType("varchar(50)");
                lead.Property(l => l.Order_date).HasColumnType("varchar(30)");
                lead.Property(l => l.Order_total).HasColumnType("decimal(18,2)");
                lead.Property(l => l.Customer_id).HasColumnType("varchar(10)");
                lead.Property(l => l.Customer_name).HasColumnType("varchar(100)");
                lead.Property(l => l.Customer_company_name).HasColumnType("varchar(100)");
            });


            modelBuilder.Entity<Prospect>(prospect =>
            {
                prospect.HasKey(p => p.Prospect_id);

                prospect.Property(p => p.Prospect_name).IsRequired().HasColumnType("varchar(100)");
                prospect.Property(p => p.Company_name).HasColumnType("varchar(100)");
                prospect.Property(p => p.Cnpj).HasColumnType("varchar(14)");
                prospect.Property(p => p.Main_contact).IsRequired().HasColumnType("varchar(100)");
                prospect.Property(p => p.Main_email).IsRequired().HasColumnType("varchar(100)");
                prospect.Property(p => p.Main_phone).IsRequired().HasColumnType("varchar(20)");
                prospect.Property(p => p.Phone).HasColumnType("varchar(20)");
                prospect.Property(p => p.Email).IsRequired().HasColumnType("varchar(100)");
                prospect.Property(p => p.Created_at).IsRequired().HasColumnType("varchar(20)");
                prospect.Property(p => p.City).HasColumnType("varchar(100)");
                prospect.Property(p => p.State).HasColumnType("varchar(2)");
                prospect.Property(p => p.Origin).HasColumnType("varchar(50)");
                prospect.Property(p => p.Prospect_responsable).HasColumnType("varchar(100)");
                prospect.Property(p => p.Prospect_responsable_id);
                prospect.Property(p => p.Pipeline).HasColumnType("varchar(50)");
                prospect.Property(p => p.Pipeline_step).HasColumnType("varchar(50)");
                prospect.Property(p => p.Lost_at).HasColumnType("varchar(100)");
                prospect.Property(p => p.Loss_reason).HasColumnType("varchar(100)");
                prospect.Property(p => p.Active);
                prospect.Property(p => p.Tags).HasColumnType("varchar(max)");
                prospect.Property(p => p.Exclusion_reason).HasColumnType("varchar(100)");
                prospect.Property(p => p.Deleted_at).HasColumnType("varchar(20)");
                prospect.Property(p => p.Updated_at).HasColumnType("varchar(20)");
                prospect.Property(p => p.Enriched);
                prospect.Property(p => p.Social_reason).HasColumnType("varchar(100)");
                prospect.Property(p => p.Fk_id);
                prospect.Property(p => p.List_id);
                prospect.Property(p => p.Country).HasColumnType("varchar(100)");
                prospect.Property(p => p.Zipcode).HasColumnType("varchar(8)");
                prospect.Property(p => p.Street).HasColumnType("varchar(100)");
                prospect.Property(p => p.Complement).HasColumnType("varchar(100)");
                prospect.Property(p => p.Neighborhood).HasColumnType("varchar(100)");
                prospect.Property(p => p.Department).HasColumnType("varchar(100)");
                prospect.Property(p => p.Custom_fields);
            });

            modelBuilder.Entity<Opportunity>(opportunity =>
            {
                opportunity.HasKey(o => o.Opportunity_id);

                opportunity.Property(o => o.Rdstation_uuid).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Lead_id).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Pipeline).HasColumnType("varchar(50)");
                opportunity.Property(o => o.Pipeline_step).HasColumnType("varchar(50)");
                opportunity.Property(o => o.Contact_name).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_email).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_state).HasColumnType("varchar(2)");
                opportunity.Property(o => o.Contact_city).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_address).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_street).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_neighborhood).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_number).HasColumnType("varchar(20)");
                opportunity.Property(o => o.Contact_complement).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Contact_cnpj).HasColumnType("varchar(14)");
                opportunity.Property(o => o.Contact_list_id).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Customer_id).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Customer_address).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Customer_neighborhood).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Customer_number).HasColumnType("varchar(20)");
                opportunity.Property(o => o.Customer_complement).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Customer_city).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Customer_state).HasColumnType("varchar(2)");
                opportunity.Property(o => o.Lead_status).HasColumnType("varchar(50)");
                opportunity.Property(o => o.Opportunity_responsible).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Origin).HasColumnType("varchar(50)");
                opportunity.Property(o => o.Lead_responsible).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Lead_responsible_id).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Opportunity_created_at).HasColumnType("varchar(20)");
                opportunity.Property(o => o.Opportunity_created_by).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Opportunity_updated_at).HasColumnType("varchar(20)");
                opportunity.Property(o => o.Expected_close_date).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Reactived_at).HasColumnType("varchar(20)");
                opportunity.Property(o => o.Opportunity_status).HasColumnType("varchar(50)");
                opportunity.Property(o => o.Lost_at).HasColumnType("varchar(20)");
                opportunity.Property(o => o.Loss_reason).HasColumnType("varchar(100)");
                opportunity.Property(o => o.Loss_details).HasColumnType("varchar(max)");
            });
        }
    }
}
