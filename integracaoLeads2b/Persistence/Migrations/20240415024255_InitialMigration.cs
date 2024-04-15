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
                name: "Leads",
                columns: table => new
                {
                    Lead_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lead_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    Main_contact = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Origin = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lead_Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    State = table.Column<string>(type: "varchar(2)", nullable: false),
                    Lead_responsable = table.Column<string>(type: "varchar(100)", nullable: false),
                    Lead_responsable_id = table.Column<int>(type: "int", nullable: false),
                    Lead_status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Fk_id = table.Column<int>(type: "int", nullable: false),
                    List_id = table.Column<int>(type: "int", nullable: false),
                    Pipeline = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pipeline_step = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lost_at = table.Column<string>(type: "varchar(100)", nullable: false),
                    Loss_reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    Opportunity_created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Opportunity_id = table.Column<int>(type: "int", nullable: false),
                    Opportunity_status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Order_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Order_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Customer_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_company_name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Lead_id);
                });

            migrationBuilder.CreateTable(
                name: "Opportunity",
                columns: table => new
                {
                    Opportunity_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rdstation_uuid = table.Column<string>(type: "varchar(100)", nullable: false),
                    Lead_id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Pipeline = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pipeline_step = table.Column<string>(type: "varchar(50)", nullable: false),
                    Contact_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_state = table.Column<string>(type: "varchar(2)", nullable: false),
                    Contact_city = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_address = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_neighborhood = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_number = table.Column<string>(type: "varchar(20)", nullable: false),
                    Contact_complement = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contact_cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    Contact_list_id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_address = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_neighborhood = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_number = table.Column<string>(type: "varchar(20)", nullable: false),
                    Customer_complement = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_city = table.Column<string>(type: "varchar(100)", nullable: false),
                    Customer_state = table.Column<string>(type: "varchar(2)", nullable: false),
                    Lead_status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Opportunity_responsible = table.Column<string>(type: "varchar(100)", nullable: false),
                    Origin = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lead_responsible = table.Column<string>(type: "varchar(100)", nullable: false),
                    Lead_responsible_id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Opportunity_created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Opportunity_created_by = table.Column<string>(type: "varchar(100)", nullable: false),
                    Opportunity_updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Expected_close_date = table.Column<string>(type: "varchar(100)", nullable: false),
                    Reactived_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Opportunity_status = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lost_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Loss_reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    Loss_details = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opportunity", x => x.Opportunity_id);
                });

            migrationBuilder.CreateTable(
                name: "Prospects",
                columns: table => new
                {
                    Prospect_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prospect_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Company_name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cnpj = table.Column<string>(type: "varchar(14)", nullable: false),
                    Main_contact = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Main_phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    State = table.Column<string>(type: "varchar(2)", nullable: false),
                    Origin = table.Column<string>(type: "varchar(50)", nullable: false),
                    Prospect_responsable = table.Column<string>(type: "varchar(100)", nullable: false),
                    Prospect_responsable_id = table.Column<int>(type: "int", nullable: false),
                    Pipeline = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pipeline_step = table.Column<string>(type: "varchar(50)", nullable: false),
                    Lost_at = table.Column<string>(type: "varchar(100)", nullable: false),
                    Loss_reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "varchar(max)", nullable: false),
                    Custom_fields = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exclusion_reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    Deleted_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enriched = table.Column<int>(type: "int", nullable: false),
                    Social_reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    Fk_id = table.Column<int>(type: "int", nullable: false),
                    List_id = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "varchar(100)", nullable: false),
                    Zipcode = table.Column<string>(type: "varchar(8)", nullable: false),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Complement = table.Column<string>(type: "varchar(100)", nullable: false),
                    Neighborhood = table.Column<string>(type: "varchar(100)", nullable: false),
                    Department = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospects", x => x.Prospect_id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fk_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opportunity_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Opportunity_Opportunity_id",
                        column: x => x.Opportunity_id,
                        principalTable: "Opportunity",
                        principalColumn: "Opportunity_id");
                });

            migrationBuilder.CreateTable(
                name: "Quotation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opportunity_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotation_Opportunity_Opportunity_id",
                        column: x => x.Opportunity_id,
                        principalTable: "Opportunity",
                        principalColumn: "Opportunity_id");
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opportunity_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_Opportunity_Opportunity_id",
                        column: x => x.Opportunity_id,
                        principalTable: "Opportunity",
                        principalColumn: "Opportunity_id");
                });

            migrationBuilder.CreateTable(
                name: "QuotationItem",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fk_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuotationId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuotationItem_Quotation_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_Opportunity_id",
                table: "Item",
                column: "Opportunity_id");

            migrationBuilder.CreateIndex(
                name: "IX_Quotation_Opportunity_id",
                table: "Quotation",
                column: "Opportunity_id");

            migrationBuilder.CreateIndex(
                name: "IX_QuotationItem_QuotationId",
                table: "QuotationItem",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_Opportunity_id",
                table: "Tag",
                column: "Opportunity_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "Prospects");

            migrationBuilder.DropTable(
                name: "QuotationItem");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Quotation");

            migrationBuilder.DropTable(
                name: "Opportunity");
        }
    }
}
