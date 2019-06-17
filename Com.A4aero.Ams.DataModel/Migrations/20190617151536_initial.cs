using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.A4aero.Ams.DataModel.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarkupPlans",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnUtc = table.Column<DateTime>(nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(nullable: false),
                    MarkupPlanName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkupPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEntities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOnUtc = table.Column<DateTime>(nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    ReferredBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    LoginUrl = table.Column<string>(nullable: true),
                    SecurityCode = table.Column<string>(nullable: true),
                    SMTPServer = table.Column<string>(nullable: true),
                    SMTPPort = table.Column<int>(nullable: false),
                    SMTPUsername = table.Column<string>(nullable: true),
                    SMTPPassword = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false),
                    CurrentBalance = table.Column<decimal>(nullable: false),
                    AgentType = table.Column<string>(nullable: true),
                    MarkupPlanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessEntities_MarkupPlans_MarkupPlanId",
                        column: x => x.MarkupPlanId,
                        principalTable: "MarkupPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEntities_MarkupPlanId",
                table: "BusinessEntities",
                column: "MarkupPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessEntities");

            migrationBuilder.DropTable(
                name: "MarkupPlans");
        }
    }
}
