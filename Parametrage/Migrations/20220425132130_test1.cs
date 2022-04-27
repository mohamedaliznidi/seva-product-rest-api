using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parametrage.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GarantieId",
                table: "RegleCalculs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RegleCalculs_GarantieId",
                table: "RegleCalculs",
                column: "GarantieId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegleCalculs_Garanties_GarantieId",
                table: "RegleCalculs",
                column: "GarantieId",
                principalTable: "Garanties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegleCalculs_Garanties_GarantieId",
                table: "RegleCalculs");

            migrationBuilder.DropIndex(
                name: "IX_RegleCalculs_GarantieId",
                table: "RegleCalculs");

            migrationBuilder.DropColumn(
                name: "GarantieId",
                table: "RegleCalculs");
        }
    }
}
