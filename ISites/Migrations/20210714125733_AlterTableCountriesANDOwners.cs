using Microsoft.EntityFrameworkCore.Migrations;

namespace ISites.Migrations
{
    public partial class AlterTableCountriesANDOwners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Countries");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Owners_CountryId",
                table: "Owners",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Countries_CountryId",
                table: "Owners",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Countries_CountryId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_CountryId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Owners");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
