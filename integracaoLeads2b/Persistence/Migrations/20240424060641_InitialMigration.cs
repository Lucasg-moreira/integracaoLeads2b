using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace integracaoLeads2b.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fk_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Lead_id = table.Column<string>(type: "varchar(20)", nullable: false),
                    Lead_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    Main_contact = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Origin = table.Column<string>(type: "varchar(50)", nullable: true),
                    Lead_Created_at = table.Column<string>(type: "varchar(30)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: true),
                    State = table.Column<string>(type: "varchar(30)", nullable: true),
                    Lead_responsable = table.Column<string>(type: "varchar(100)", nullable: false),
                    Lead_responsable_id = table.Column<string>(type: "varchar(10)", nullable: false),
                    Lead_status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Fk_id = table.Column<string>(type: "varchar(10)", nullable: true),
                    List_id = table.Column<string>(type: "varchar(10)", nullable: true),
                    Pipeline = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pipeline_step = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lost_at = table.Column<string>(type: "varchar(100)", nullable: true),
                    Loss_reason = table.Column<string>(type: "varchar(100)", nullable: true),
                    Opportunity_created_at = table.Column<string>(type: "varchar(30)", nullable: true),
                    Opportunity_id = table.Column<string>(type: "varchar(10)", nullable: true),
                    Opportunity_status = table.Column<string>(type: "varchar(50)", nullable: true),
                    Order_date = table.Column<string>(type: "varchar(30)", nullable: true),
                    Order_total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Customer_id = table.Column<string>(type: "varchar(10)", nullable: true),
                    Customer_name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_company_name = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Opportunity_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rdstation_uuid = table.Column<string>(type: "varchar(100)", nullable: true),
                    Lead_id = table.Column<string>(type: "varchar(100)", nullable: true),
                    Pipeline = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pipeline_step = table.Column<string>(type: "varchar(50)", nullable: false),
                    Contact_name = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_email = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_state = table.Column<string>(type: "varchar(2)", nullable: true),
                    Contact_city = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_address = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_street = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_neighborhood = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_number = table.Column<string>(type: "varchar(20)", nullable: true),
                    Contact_complement = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contact_cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    Contact_list_id = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_id = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_address = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_neighborhood = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_number = table.Column<string>(type: "varchar(20)", nullable: true),
                    Customer_complement = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_city = table.Column<string>(type: "varchar(100)", nullable: true),
                    Customer_state = table.Column<string>(type: "varchar(2)", nullable: true),
                    Lead_status = table.Column<string>(type: "varchar(50)", nullable: true),
                    Opportunity_responsible = table.Column<string>(type: "varchar(100)", nullable: true),
                    Origin = table.Column<string>(type: "varchar(50)", nullable: true),
                    Lead_responsible = table.Column<string>(type: "varchar(100)", nullable: true),
                    Lead_responsible_id = table.Column<string>(type: "varchar(100)", nullable: true),
                    Opportunity_created_at = table.Column<string>(type: "varchar(20)", nullable: true),
                    Opportunity_created_by = table.Column<string>(type: "varchar(100)", nullable: true),
                    Opportunity_updated_at = table.Column<string>(type: "varchar(20)", nullable: true),
                    Expected_close_date = table.Column<string>(type: "varchar(100)", nullable: true),
                    Reactived_at = table.Column<string>(type: "varchar(20)", nullable: true),
                    Opportunity_status = table.Column<string>(type: "varchar(50)", nullable: true),
                    Lost_at = table.Column<string>(type: "varchar(20)", nullable: true),
                    Loss_reason = table.Column<string>(type: "varchar(100)", nullable: true),
                    Loss_details = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prospects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prospect_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prospect_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Company_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_contact = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_phone = table.Column<string>(type: "varchar(30)", nullable: false),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "varchar(14)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(100)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Tags = table.Column<string>(type: "varchar(max)", nullable: true),
                    Custom_fields = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exclusion_reason = table.Column<string>(type: "varchar(100)", nullable: true),
                    Deleted_at = table.Column<string>(type: "varchar(20)", nullable: true),
                    Created_at = table.Column<string>(type: "varchar(20)", nullable: false),
                    Updated_at = table.Column<string>(type: "varchar(20)", nullable: false),
                    Enriched = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enriched_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Social_reason = table.Column<string>(type: "varchar(100)", nullable: true),
                    Fk_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    List_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "varchar(100)", nullable: true),
                    State = table.Column<string>(type: "varchar(2)", nullable: true),
                    Country = table.Column<string>(type: "varchar(100)", nullable: true),
                    Zipcode = table.Column<string>(type: "varchar(20)", nullable: true),
                    Street = table.Column<string>(type: "varchar(100)", nullable: true),
                    Complement = table.Column<string>(type: "varchar(100)", nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(100)", nullable: true),
                    Department = table.Column<string>(type: "varchar(100)", nullable: true),
                    Origin = table.Column<string>(type: "varchar(50)", nullable: true),
                    Prospect_responsable = table.Column<string>(type: "varchar(100)", nullable: true),
                    Prospect_responsable_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pipeline = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pipeline_step = table.Column<string>(type: "varchar(50)", nullable: true),
                    Lost_at = table.Column<string>(type: "varchar(100)", nullable: true),
                    Loss_reason = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospects", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Opportunity");

            migrationBuilder.DropTable(
                name: "Prospects");
        }
    }
}
