using Microsoft.EntityFrameworkCore.Migrations;

namespace OnBoardingAPI.Migrations
{
    public partial class HrphonePE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HrContactNumber",
                table: "PreviousEmployers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HrEmailID",
                table: "PreviousEmployers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HrContactNumber",
                table: "PreviousEmployers");

            migrationBuilder.DropColumn(
                name: "HrEmailID",
                table: "PreviousEmployers");
        }
    }
}
