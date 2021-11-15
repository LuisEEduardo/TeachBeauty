using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class TeachBeauty5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_Caixa_CaixaId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropIndex(
                name: "IX_Colaborador_CaixaId",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "CaixaId",
                table: "Colaborador");

            migrationBuilder.AddColumn<int>(
                name: "ColaboradorId",
                table: "PagamentoCliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PagamentoColaboradorId",
                table: "Colaborador",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColaboradorId",
                table: "Caixa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoCliente_ColaboradorId",
                table: "PagamentoCliente",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Caixa_ColaboradorId",
                table: "Caixa",
                column: "ColaboradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caixa_Colaborador_ColaboradorId",
                table: "Caixa",
                column: "ColaboradorId",
                principalTable: "Colaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador",
                column: "PagamentoColaboradorId",
                principalTable: "PagamentoColaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagamentoCliente_Colaborador_ColaboradorId",
                table: "PagamentoCliente",
                column: "ColaboradorId",
                principalTable: "Colaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caixa_Colaborador_ColaboradorId",
                table: "Caixa");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoCliente_Colaborador_ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropIndex(
                name: "IX_PagamentoCliente_ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropIndex(
                name: "IX_Caixa_ColaboradorId",
                table: "Caixa");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "Caixa");

            migrationBuilder.AlterColumn<int>(
                name: "PagamentoColaboradorId",
                table: "Colaborador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CaixaId",
                table: "Colaborador",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_CaixaId",
                table: "Colaborador",
                column: "CaixaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaborador_Caixa_CaixaId",
                table: "Colaborador",
                column: "CaixaId",
                principalTable: "Caixa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador",
                column: "PagamentoColaboradorId",
                principalTable: "PagamentoColaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
