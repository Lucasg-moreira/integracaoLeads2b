﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using integracaoLeads2b.Persistence;

#nullable disable

namespace integracaoLeads2b.Persistence.Migrations
{
    [DbContext(typeof(LeadsDbContext))]
    partial class LeadsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("integracaoLeads2b.Entities.Item", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fk_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opportunity_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Opportunity_id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Leads", b =>
                {
                    b.Property<int>("Lead_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lead_id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Customer_company_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Customer_id")
                        .HasColumnType("int");

                    b.Property<string>("Customer_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Fk_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Lead_created_at")
                        .HasColumnType("datetime")
                        .HasColumnName("Lead_Created_at");

                    b.Property<string>("Lead_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lead_responsable")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Lead_responsable_id")
                        .HasColumnType("int");

                    b.Property<string>("Lead_status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("List_id")
                        .HasColumnType("int");

                    b.Property<string>("Loss_reason")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lost_at")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Main_contact")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Main_email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Main_phone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("Opportunity_created_at")
                        .HasColumnType("datetime");

                    b.Property<int>("Opportunity_id")
                        .HasColumnType("int");

                    b.Property<string>("Opportunity_status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Order_total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Pipeline")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pipeline_step")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.HasKey("Lead_id");

                    b.ToTable("Leads");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Opportunity", b =>
                {
                    b.Property<string>("Opportunity_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contact_address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_city")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Contact_complement")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_list_id")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Contact_number")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Contact_state")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Contact_street")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Customer_address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Customer_city")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Customer_complement")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Customer_id")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Customer_neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Customer_number")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Customer_state")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Expected_close_date")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lead_id")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lead_responsible")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lead_responsible_id")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lead_status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Loss_details")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Loss_reason")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Lost_at")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Opportunity_created_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Opportunity_created_by")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Opportunity_responsible")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Opportunity_status")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Opportunity_updated_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pipeline")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pipeline_step")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Rdstation_uuid")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Reactived_at")
                        .HasColumnType("datetime");

                    b.HasKey("Opportunity_id");

                    b.ToTable("Opportunity");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Prospect", b =>
                {
                    b.Property<int>("Prospect_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Prospect_id"));

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Company_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Custom_fields")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Deleted_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Enriched")
                        .HasColumnType("int");

                    b.Property<string>("Exclusion_reason")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Fk_id")
                        .HasColumnType("int");

                    b.Property<int>("List_id")
                        .HasColumnType("int");

                    b.Property<string>("Loss_reason")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Lost_at")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Main_contact")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Main_email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Main_phone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Pipeline")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pipeline_step")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Prospect_name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Prospect_responsable")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Prospect_responsable_id")
                        .HasColumnType("int");

                    b.Property<string>("Social_reason")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("Prospect_id");

                    b.ToTable("Prospects");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Quotation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Approved")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id_customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opportunity_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Opportunity_id");

                    b.ToTable("Quotation");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.QuotationItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fk_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuotationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Total")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuotationId");

                    b.ToTable("QuotationItem");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Tag", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opportunity_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Opportunity_id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Item", b =>
                {
                    b.HasOne("integracaoLeads2b.Entities.Opportunity", null)
                        .WithMany("Items")
                        .HasForeignKey("Opportunity_id");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Quotation", b =>
                {
                    b.HasOne("integracaoLeads2b.Entities.Opportunity", null)
                        .WithMany("Quotations")
                        .HasForeignKey("Opportunity_id");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.QuotationItem", b =>
                {
                    b.HasOne("integracaoLeads2b.Entities.Quotation", null)
                        .WithMany("Items")
                        .HasForeignKey("QuotationId");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Tag", b =>
                {
                    b.HasOne("integracaoLeads2b.Entities.Opportunity", null)
                        .WithMany("Tags")
                        .HasForeignKey("Opportunity_id");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Opportunity", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Quotations");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("integracaoLeads2b.Entities.Quotation", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}