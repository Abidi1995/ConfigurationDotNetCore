using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationDotNetCore.Migrations
{
    public partial class student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: true),
                    RollNo = table.Column<string>(nullable: true),
                    Domicile = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CNIC = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    FatherCnic = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    PresentAddress = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    FatherOccupation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
