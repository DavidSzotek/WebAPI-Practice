using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_Practice.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Printer_Office_OfficeId",
                table: "Printer");

            migrationBuilder.DropForeignKey(
                name: "FK_Printer_Printerstatus_PrinterstatusId",
                table: "Printer");

            migrationBuilder.DropForeignKey(
                name: "FK_Printer_Printertypes_PrintertypeId",
                table: "Printer");

            migrationBuilder.DropForeignKey(
                name: "FK_Printerfile_Printer_PrinterId",
                table: "Printerfile");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Materials_MaterialId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Office_OfficeId",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printerstatus",
                table: "Printerstatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printerfile",
                table: "Printerfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printer",
                table: "Printer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Office",
                table: "Office");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "Printerstatus",
                newName: "Printerstatuses");

            migrationBuilder.RenameTable(
                name: "Printerfile",
                newName: "Printerfiles");

            migrationBuilder.RenameTable(
                name: "Printer",
                newName: "Printers");

            migrationBuilder.RenameTable(
                name: "Office",
                newName: "Offices");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_OfficeId",
                table: "Stocks",
                newName: "IX_Stocks_OfficeId");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_MaterialId",
                table: "Stocks",
                newName: "IX_Stocks_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Printerfile_PrinterId",
                table: "Printerfiles",
                newName: "IX_Printerfiles_PrinterId");

            migrationBuilder.RenameIndex(
                name: "IX_Printer_PrintertypeId",
                table: "Printers",
                newName: "IX_Printers_PrintertypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Printer_PrinterstatusId",
                table: "Printers",
                newName: "IX_Printers_PrinterstatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Printer_OfficeId",
                table: "Printers",
                newName: "IX_Printers_OfficeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printerstatuses",
                table: "Printerstatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printerfiles",
                table: "Printerfiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printers",
                table: "Printers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Offices",
                table: "Offices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Printerfiles_Printers_PrinterId",
                table: "Printerfiles",
                column: "PrinterId",
                principalTable: "Printers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_Offices_OfficeId",
                table: "Printers",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_Printerstatuses_PrinterstatusId",
                table: "Printers",
                column: "PrinterstatusId",
                principalTable: "Printerstatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printers_Printertypes_PrintertypeId",
                table: "Printers",
                column: "PrintertypeId",
                principalTable: "Printertypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Materials_MaterialId",
                table: "Stocks",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Offices_OfficeId",
                table: "Stocks",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Printerfiles_Printers_PrinterId",
                table: "Printerfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_Offices_OfficeId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_Printerstatuses_PrinterstatusId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_Printers_Printertypes_PrintertypeId",
                table: "Printers");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Materials_MaterialId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Offices_OfficeId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printerstatuses",
                table: "Printerstatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printers",
                table: "Printers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Printerfiles",
                table: "Printerfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Offices",
                table: "Offices");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stock");

            migrationBuilder.RenameTable(
                name: "Printerstatuses",
                newName: "Printerstatus");

            migrationBuilder.RenameTable(
                name: "Printers",
                newName: "Printer");

            migrationBuilder.RenameTable(
                name: "Printerfiles",
                newName: "Printerfile");

            migrationBuilder.RenameTable(
                name: "Offices",
                newName: "Office");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_OfficeId",
                table: "Stock",
                newName: "IX_Stock_OfficeId");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_MaterialId",
                table: "Stock",
                newName: "IX_Stock_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Printers_PrintertypeId",
                table: "Printer",
                newName: "IX_Printer_PrintertypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Printers_PrinterstatusId",
                table: "Printer",
                newName: "IX_Printer_PrinterstatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Printers_OfficeId",
                table: "Printer",
                newName: "IX_Printer_OfficeId");

            migrationBuilder.RenameIndex(
                name: "IX_Printerfiles_PrinterId",
                table: "Printerfile",
                newName: "IX_Printerfile_PrinterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printerstatus",
                table: "Printerstatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printer",
                table: "Printer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Printerfile",
                table: "Printerfile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Office",
                table: "Office",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Printer_Office_OfficeId",
                table: "Printer",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printer_Printerstatus_PrinterstatusId",
                table: "Printer",
                column: "PrinterstatusId",
                principalTable: "Printerstatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printer_Printertypes_PrintertypeId",
                table: "Printer",
                column: "PrintertypeId",
                principalTable: "Printertypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Printerfile_Printer_PrinterId",
                table: "Printerfile",
                column: "PrinterId",
                principalTable: "Printer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Materials_MaterialId",
                table: "Stock",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Office_OfficeId",
                table: "Stock",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
