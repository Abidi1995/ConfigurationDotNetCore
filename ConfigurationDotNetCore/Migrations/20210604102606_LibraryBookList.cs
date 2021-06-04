using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationDotNetCore.Migrations
{
    public partial class LibraryBookList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibrarayBookLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessionNo = table.Column<string>(nullable: true),
                    ClassificationNo = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    Edition = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    YearOfPublishing = table.Column<DateTime>(nullable: false),
                    VolumeNo = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Pages = table.Column<string>(nullable: true),
                    PresentPosition = table.Column<string>(nullable: true),
                    IsIssuable = table.Column<bool>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    TranslatorCorner = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrarayBookLists", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibrarayBookLists");
        }
    }
}
