using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_PagamentoCliente_PagamentoClienteID",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoCliente_FormasPagamento_FormasPagamentoId",
                table: "PagamentoCliente");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_PagamentoClienteID",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "PagamentoClienteID",
                table: "Agendamento");

            migrationBuilder.AlterColumn<int>(
                name: "FormasPagamentoId",
                table: "PagamentoCliente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PagamentoCliente_FormasPagamento_FormasPagamentoId",
                table: "PagamentoCliente",
                column: "FormasPagamentoId",
                principalTable: "FormasPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoCliente_FormasPagamento_FormasPagamentoId",
                table: "PagamentoCliente");

            migrationBuilder.AlterColumn<int>(
                name: "FormasPagamentoId",
                table: "PagamentoCliente",
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
                name: "FK_PagamentoCliente_FormasPagamento_FormasPagamentoId",
                table: "PagamentoCliente",
                column: "FormasPagamentoId",
                principalTable: "FormasPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
