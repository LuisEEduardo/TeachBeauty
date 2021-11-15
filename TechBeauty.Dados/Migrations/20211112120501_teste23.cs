using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class teste23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_Caixa_CaixaId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoCliente_Colaborador_ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropIndex(
                name: "IX_PagamentoCliente_ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.AlterColumn<int>(
                name: "PagamentoColaboradorId",
                table: "Colaborador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CaixaId",
                table: "Colaborador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PagamentoClienteID",
                table: "Agendamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_PagamentoClienteID",
                table: "Agendamento",
                column: "PagamentoClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_PagamentoCliente_PagamentoClienteID",
                table: "Agendamento",
                column: "PagamentoClienteID",
                principalTable: "PagamentoCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_PagamentoCliente_PagamentoClienteID",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_Caixa_CaixaId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_PagamentoClienteID",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "PagamentoClienteID",
                table: "Agendamento");

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

            migrationBuilder.AlterColumn<int>(
                name: "CaixaId",
                table: "Colaborador",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoCliente_ColaboradorId",
                table: "PagamentoCliente",
                column: "ColaboradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaborador_Caixa_CaixaId",
                table: "Colaborador",
                column: "CaixaId",
                principalTable: "Caixa",
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
    }
}
