using Microsoft.EntityFrameworkCore.Migrations;

namespace OnBoardingAPI.Migrations
{
    public partial class PersonalDEtails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetails_City_CityId",
                table: "PersonalDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetails_State_StateId",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "CurrentCityId",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "CurrentPincode",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "CurrentStateId",
                table: "PersonalDetails");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "PersonalDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "PersonalDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pincode",
                table: "PersonalDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetails_City_CityId",
                table: "PersonalDetails",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetails_State_StateId",
                table: "PersonalDetails",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetails_City_CityId",
                table: "PersonalDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetails_State_StateId",
                table: "PersonalDetails");

            migrationBuilder.DropColumn(
                name: "Pincode",
                table: "PersonalDetails");

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "PersonalDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "PersonalDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CurrentCityId",
                table: "PersonalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentPincode",
                table: "PersonalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStateId",
                table: "PersonalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetails_City_CityId",
                table: "PersonalDetails",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetails_State_StateId",
                table: "PersonalDetails",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
