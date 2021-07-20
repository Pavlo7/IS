using Microsoft.EntityFrameworkCore.Migrations;

namespace ISites.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code_A2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code_A3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code_Num = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_RU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issuer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssuerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issuer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerCode = table.Column<int>(type: "int", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owner_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosCode = table.Column<int>(type: "int", nullable: false),
                    PosName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    IssuerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pos_Issuer_IssuerId",
                        column: x => x.IssuerId,
                        principalTable: "Issuer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pos_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PosIssuer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosId = table.Column<int>(type: "int", nullable: false),
                    IssuerId = table.Column<int>(type: "int", nullable: false),
                    IssuerPosCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosIssuer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PosIssuer_Issuer_IssuerId",
                        column: x => x.IssuerId,
                        principalTable: "Issuer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PosIssuer_Pos_PosId",
                        column: x => x.PosId,
                        principalTable: "Pos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssuerProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosIssuerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IssuerProductCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuerProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssuerProduct_PosIssuer_PosIssuerId",
                        column: x => x.PosIssuerId,
                        principalTable: "PosIssuer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuerProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssuerProduct_PosIssuerId",
                table: "IssuerProduct",
                column: "PosIssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuerProduct_ProductId",
                table: "IssuerProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Owner_CountryId",
                table: "Owner",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pos_IssuerId",
                table: "Pos",
                column: "IssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pos_OwnerId",
                table: "Pos",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PosIssuer_IssuerId",
                table: "PosIssuer",
                column: "IssuerId");

            migrationBuilder.CreateIndex(
                name: "IX_PosIssuer_PosId",
                table: "PosIssuer",
                column: "PosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuerProduct");

            migrationBuilder.DropTable(
                name: "PosIssuer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Pos");

            migrationBuilder.DropTable(
                name: "Issuer");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
