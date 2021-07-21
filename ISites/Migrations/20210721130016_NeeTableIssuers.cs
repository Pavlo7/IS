using Microsoft.EntityFrameworkCore.Migrations;

namespace ISites.Migrations
{
    public partial class NeeTableIssuers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pos_Issuer_IssuerId",
                table: "Pos");

            migrationBuilder.DropIndex(
                name: "IX_Pos_IssuerId",
                table: "Pos");

            migrationBuilder.DropColumn(
                name: "IssuerId",
                table: "Pos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IssuerId",
                table: "Pos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pos_IssuerId",
                table: "Pos",
                column: "IssuerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pos_Issuer_IssuerId",
                table: "Pos",
                column: "IssuerId",
                principalTable: "Issuer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
