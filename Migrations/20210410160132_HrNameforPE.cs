using Microsoft.EntityFrameworkCore.Migrations;

namespace OnBoardingAPI.Migrations
{
    public partial class HrNameforPE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UploadDocuments_PersonalDetailEmployeeId",
                table: "UploadDocuments");

            migrationBuilder.AddColumn<string>(
                name: "HrName",
                table: "PreviousEmployers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UploadDocuments_PersonalDetailEmployeeId",
                table: "UploadDocuments",
                column: "PersonalDetailEmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UploadDocuments_PersonalDetailEmployeeId",
                table: "UploadDocuments");

            migrationBuilder.DropColumn(
                name: "HrName",
                table: "PreviousEmployers");

            migrationBuilder.CreateIndex(
                name: "IX_UploadDocuments_PersonalDetailEmployeeId",
                table: "UploadDocuments",
                column: "PersonalDetailEmployeeId");
        }
    }
}
