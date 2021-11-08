using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class TechBeauty2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_CargoContratoTrabalho_CargoID",
                table: "CargoContratoTrabalho",
                column: "CargoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_CargoContratoTrabalho_CargoID",
                table: "CargoContratoTrabalho");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargoContratoTrabalho",
                table: "CargoContratoTrabalho",
                columns: new[] { "CargoID", "ContratoDeTrabalhoID" });
        }
    }
}
