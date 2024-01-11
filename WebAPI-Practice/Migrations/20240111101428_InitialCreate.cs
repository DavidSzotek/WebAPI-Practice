using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_Practice.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Functiontypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functiontypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materialtypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materialtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Printertypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsColor = table.Column<bool>(type: "bit", nullable: false),
                    IsA3 = table.Column<bool>(type: "bit", nullable: false),
                    FunctiontypeId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printertypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Printertypes_Functiontypes_FunctiontypeId",
                        column: x => x.FunctiontypeId,
                        principalTable: "Functiontypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Printertypes_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsAlternative = table.Column<bool>(type: "bit", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PriceDph = table.Column<double>(type: "float", nullable: false),
                    MaterialtypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Materialtypes_MaterialtypeId",
                        column: x => x.MaterialtypeId,
                        principalTable: "Materialtypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialPrintertype",
                columns: table => new
                {
                    MaterialsId = table.Column<int>(type: "int", nullable: false),
                    PrintertypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialPrintertype", x => new { x.MaterialsId, x.PrintertypesId });
                    table.ForeignKey(
                        name: "FK_MaterialPrintertype_Materials_MaterialsId",
                        column: x => x.MaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialPrintertype_Printertypes_PrintertypesId",
                        column: x => x.PrintertypesId,
                        principalTable: "Printertypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPrintertype_PrintertypesId",
                table: "MaterialPrintertype",
                column: "PrintertypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialtypeId",
                table: "Materials",
                column: "MaterialtypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Printertypes_FunctiontypeId",
                table: "Printertypes",
                column: "FunctiontypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Printertypes_ManufacturerId",
                table: "Printertypes",
                column: "ManufacturerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialPrintertype");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Printertypes");

            migrationBuilder.DropTable(
                name: "Materialtypes");

            migrationBuilder.DropTable(
                name: "Functiontypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
