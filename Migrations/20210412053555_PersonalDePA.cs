using Microsoft.EntityFrameworkCore.Migrations;

namespace OnBoardingAPI.Migrations
{
    public partial class PersonalDePA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "PersonalDetails",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PermanentAddressCityId",
                table: "PersonalDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermanentAddressPincode",
                table: "PersonalDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermanentAddressStateId",
                table: "PersonalDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "PermanentAddressCityId",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "PermanentAddressPincode",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "PermanentAddressStateId",
                table: "PersonalDetails");
        }
    }
}
