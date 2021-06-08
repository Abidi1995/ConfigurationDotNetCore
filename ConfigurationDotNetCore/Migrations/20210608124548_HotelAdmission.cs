using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationDotNetCore.Migrations
{
    public partial class HotelAdmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmission_Admissions_AdmissionId",
                table: "HostelAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmission_Hostels_HostelId",
                table: "HostelAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmission_Rooms_RoomsId",
                table: "HostelAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmission_StudentAttendanceType_StudentAttendanceTypeID",
                table: "HostelAdmission");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAttendance_HostelAdmission_HostelAdmissionId",
                table: "HostelAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_HostelAdmission_HostelAdmissionId",
                table: "Visitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HostelAdmission",
                table: "HostelAdmission");

            migrationBuilder.RenameTable(
                name: "HostelAdmission",
                newName: "HostelAdmissions");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmission_StudentAttendanceTypeID",
                table: "HostelAdmissions",
                newName: "IX_HostelAdmissions_StudentAttendanceTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmission_RoomsId",
                table: "HostelAdmissions",
                newName: "IX_HostelAdmissions_RoomsId");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmission_HostelId",
                table: "HostelAdmissions",
                newName: "IX_HostelAdmissions_HostelId");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmission_AdmissionId",
                table: "HostelAdmissions",
                newName: "IX_HostelAdmissions_AdmissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HostelAdmissions",
                table: "HostelAdmissions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmissions_Admissions_AdmissionId",
                table: "HostelAdmissions",
                column: "AdmissionId",
                principalTable: "Admissions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmissions_Hostels_HostelId",
                table: "HostelAdmissions",
                column: "HostelId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmissions_Rooms_RoomsId",
                table: "HostelAdmissions",
                column: "RoomsId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmissions_StudentAttendanceType_StudentAttendanceTypeID",
                table: "HostelAdmissions",
                column: "StudentAttendanceTypeID",
                principalTable: "StudentAttendanceType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAttendance_HostelAdmissions_HostelAdmissionId",
                table: "HostelAttendance",
                column: "HostelAdmissionId",
                principalTable: "HostelAdmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_HostelAdmissions_HostelAdmissionId",
                table: "Visitors",
                column: "HostelAdmissionId",
                principalTable: "HostelAdmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmissions_Admissions_AdmissionId",
                table: "HostelAdmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmissions_Hostels_HostelId",
                table: "HostelAdmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmissions_Rooms_RoomsId",
                table: "HostelAdmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAdmissions_StudentAttendanceType_StudentAttendanceTypeID",
                table: "HostelAdmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HostelAttendance_HostelAdmissions_HostelAdmissionId",
                table: "HostelAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitors_HostelAdmissions_HostelAdmissionId",
                table: "Visitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HostelAdmissions",
                table: "HostelAdmissions");

            migrationBuilder.RenameTable(
                name: "HostelAdmissions",
                newName: "HostelAdmission");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmissions_StudentAttendanceTypeID",
                table: "HostelAdmission",
                newName: "IX_HostelAdmission_StudentAttendanceTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmissions_RoomsId",
                table: "HostelAdmission",
                newName: "IX_HostelAdmission_RoomsId");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmissions_HostelId",
                table: "HostelAdmission",
                newName: "IX_HostelAdmission_HostelId");

            migrationBuilder.RenameIndex(
                name: "IX_HostelAdmissions_AdmissionId",
                table: "HostelAdmission",
                newName: "IX_HostelAdmission_AdmissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HostelAdmission",
                table: "HostelAdmission",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmission_Admissions_AdmissionId",
                table: "HostelAdmission",
                column: "AdmissionId",
                principalTable: "Admissions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmission_Hostels_HostelId",
                table: "HostelAdmission",
                column: "HostelId",
                principalTable: "Hostels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmission_Rooms_RoomsId",
                table: "HostelAdmission",
                column: "RoomsId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAdmission_StudentAttendanceType_StudentAttendanceTypeID",
                table: "HostelAdmission",
                column: "StudentAttendanceTypeID",
                principalTable: "StudentAttendanceType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HostelAttendance_HostelAdmission_HostelAdmissionId",
                table: "HostelAttendance",
                column: "HostelAdmissionId",
                principalTable: "HostelAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitors_HostelAdmission_HostelAdmissionId",
                table: "Visitors",
                column: "HostelAdmissionId",
                principalTable: "HostelAdmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
