using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_Practice.Migrations
{
    /// <inheritdoc />
    public partial class AddingURIs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrinterImageUri",
                table: "Printer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerImageUri",
                table: "Manufacturers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Printerfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrinterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printerfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Printerfile_Printer_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Printerfile_PrinterId",
                table: "Printerfile",
                column: "PrinterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Printerfile");

            migrationBuilder.DropColumn(
                name: "PrinterImageUri",
                table: "Printer");

            migrationBuilder.DropColumn(
                name: "ManufacturerImageUri",
                table: "Manufacturers");
        }
    }
}
