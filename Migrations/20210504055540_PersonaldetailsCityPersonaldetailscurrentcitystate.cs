using Microsoft.EntityFrameworkCore.Migrations;

namespace OnBoardingAPI.Migrations
{
    public partial class PersonaldetailsCityPersonaldetailscurrentcitystate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentCityId",
                table: "PersonalDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStateId",
                table: "PersonalDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCityId",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "CurrentStateId",
                table: "PersonalDetails");
        }
    }
}
