using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationDotNetCore.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: false),
                    RegisterationNo = table.Column<string>(nullable: false),
                    CompanyType = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    NoOfEmployees = table.Column<string>(nullable: false),
                    CompanyNtNnO = table.Column<string>(nullable: false),
                    CompanyWebsite = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
