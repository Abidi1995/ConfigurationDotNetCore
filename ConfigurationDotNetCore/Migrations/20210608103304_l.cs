using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationDotNetCore.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admissions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsExpell = table.Column<bool>(nullable: false),
                    ClassSectionID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    Session = table.Column<decimal>(nullable: false),
                    CampuseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admissions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentAttendanceType",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceName = table.Column<string>(nullable: true),
                    Fine = table.Column<double>(nullable: false),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendanceType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HostelAdmission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(nullable: false),
                    HostelId = table.Column<int>(nullable: false),
                    AdmissionId = table.Column<int>(nullable: false),
                    Fee = table.Column<int>(nullable: false),
                    IsExpel = table.Column<bool>(nullable: false),
                    RoomsId = table.Column<int>(nullable: true),
                    StudentAttendanceTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostelAdmission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostelAdmission_Admissions_AdmissionId",
                        column: x => x.AdmissionId,
                        principalTable: "Admissions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HostelAdmission_Hostels_HostelId",
                        column: x => x.HostelId,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HostelAdmission_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HostelAdmission_StudentAttendanceType_StudentAttendanceTypeID",
                        column: x => x.StudentAttendanceTypeID,
                        principalTable: "StudentAttendanceType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentAttendance",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceDate = table.Column<DateTime>(nullable: false),
                    AdmissionID = table.Column<int>(nullable: false),
                    FineAmount = table.Column<double>(nullable: false),
                    AttendanceTypeID = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    Sendmessage = table.Column<bool>(nullable: true),
                    Manual = table.Column<bool>(nullable: true),
                    StudentAttendanceTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_Admissions_AdmissionID",
                        column: x => x.AdmissionID,
                        principalTable: "Admissions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_StudentAttendanceType_StudentAttendanceTypeID",
                        column: x => x.StudentAttendanceTypeID,
                        principalTable: "StudentAttendanceType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HostelAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    AttendanceTypeId = table.Column<int>(nullable: false),
                    HostelId = table.Column<int>(nullable: false),
                    HostleAdmId = table.Column<int>(nullable: false),
                    HostelAdmissionId = table.Column<int>(nullable: true),
                    StudentAttendanceTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostelAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostelAttendance_HostelAdmission_HostelAdmissionId",
                        column: x => x.HostelAdmissionId,
                        principalTable: "HostelAdmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HostelAttendance_Hostels_HostelId",
                        column: x => x.HostelId,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HostelAttendance_StudentAttendanceType_StudentAttendanceTypeID",
                        column: x => x.StudentAttendanceTypeID,
                        principalTable: "StudentAttendanceType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TimeIn = table.Column<TimeSpan>(nullable: false),
                    TimeOut = table.Column<TimeSpan>(nullable: false),
                    Relationship = table.Column<string>(nullable: true),
                    Cnic = table.Column<string>(nullable: true),
                    HostleAdmId = table.Column<int>(nullable: false),
                    HostelId = table.Column<int>(nullable: false),
                    HostelAdmissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorID);
                    table.ForeignKey(
                        name: "FK_Visitors_HostelAdmission_HostelAdmissionId",
                        column: x => x.HostelAdmissionId,
                        principalTable: "HostelAdmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitors_Hostels_HostelId",
                        column: x => x.HostelId,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HostelAdmission_AdmissionId",
                table: "HostelAdmission",
                column: "AdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAdmission_HostelId",
                table: "HostelAdmission",
                column: "HostelId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAdmission_RoomsId",
                table: "HostelAdmission",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAdmission_StudentAttendanceTypeID",
                table: "HostelAdmission",
                column: "StudentAttendanceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAttendance_HostelAdmissionId",
                table: "HostelAttendance",
                column: "HostelAdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAttendance_HostelId",
                table: "HostelAttendance",
                column: "HostelId");

            migrationBuilder.CreateIndex(
                name: "IX_HostelAttendance_StudentAttendanceTypeID",
                table: "HostelAttendance",
                column: "StudentAttendanceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_AdmissionID",
                table: "StudentAttendance",
                column: "AdmissionID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_StudentAttendanceTypeID",
                table: "StudentAttendance",
                column: "StudentAttendanceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_HostelAdmissionId",
                table: "Visitors",
                column: "HostelAdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_HostelId",
                table: "Visitors",
                column: "HostelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HostelAttendance");

            migrationBuilder.DropTable(
                name: "StudentAttendance");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "HostelAdmission");

            migrationBuilder.DropTable(
                name: "Admissions");

            migrationBuilder.DropTable(
                name: "StudentAttendanceType");
        }
    }
}
