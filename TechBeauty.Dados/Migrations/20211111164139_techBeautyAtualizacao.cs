using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class techBeautyAtualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_PagamentoColaboradorPJ_PagamentoColaboradorPJId",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoColaborador_Colaborador_ColaboradorId",
                table: "PagamentoColaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoColaborador_FormasPagamento_FormasPagamentoID",
                table: "PagamentoColaborador");

            migrationBuilder.DropTable(
                name: "PagamentoColaboradorCLT");

            migrationBuilder.DropTable(
                name: "PagamentoColaboradorPJ");

            migrationBuilder.DropIndex(
                name: "IX_PagamentoColaborador_ColaboradorId",
                table: "PagamentoColaborador");

            migrationBuilder.DropIndex(
                name: "IX_Agendamento_PagamentoColaboradorPJId",
                table: "Agendamento");

            migrationBuilder.DropColumn(
                name: "ValorComissao",
                table: "PagamentoColaborador");

            migrationBuilder.DropColumn(
                name: "PagamentoColaboradorPJId",
                table: "Agendamento");

            migrationBuilder.RenameColumn(
                name: "FormasPagamentoID",
                table: "PagamentoColaborador",
                newName: "FormasPagamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_PagamentoColaborador_FormasPagamentoID",
                table: "PagamentoColaborador",
                newName: "IX_PagamentoColaborador_FormasPagamentoId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CargoContratoTrabalho",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "FormasPagamentoId",
                table: "PagamentoColaborador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorId",
                table: "PagamentoColaborador",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "PagamentoColaborador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "PagamentoColaborador",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ColaboradorId",
                table: "PagamentoCliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagamentoClienteId",
                table: "OrdemServico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CaixaId",
                table: "Colaborador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagamentoColaboradorId",
                table: "Colaborador",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PorcentagemComissao",
                table: "Colaborador",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Caixa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorMovimentado",
                table: "Caixa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoCliente_ColaboradorId",
                table: "PagamentoCliente",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_PagamentoClienteId",
                table: "OrdemServico",
                column: "PagamentoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_CaixaId",
                table: "Colaborador",
                column: "CaixaId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_PagamentoColaboradorId",
                table: "Colaborador",
                column: "PagamentoColaboradorId");

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
                name: "FK_OrdemServico_PagamentoCliente_PagamentoClienteId",
                table: "OrdemServico",
                column: "PagamentoClienteId",
                principalTable: "PagamentoCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagamentoCliente_Colaborador_ColaboradorId",
                table: "PagamentoCliente",
                column: "ColaboradorId",
                principalTable: "Colaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagamentoColaborador_FormasPagamento_FormasPagamentoId",
                table: "PagamentoColaborador",
                column: "FormasPagamentoId",
                principalTable: "FormasPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_Caixa_CaixaId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_PagamentoColaborador_PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_PagamentoCliente_PagamentoClienteId",
                table: "OrdemServico");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoCliente_Colaborador_ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropForeignKey(
                name: "FK_PagamentoColaborador_FormasPagamento_FormasPagamentoId",
                table: "PagamentoColaborador");

            migrationBuilder.DropIndex(
                name: "IX_PagamentoCliente_ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServico_PagamentoClienteId",
                table: "OrdemServico");

            migrationBuilder.DropIndex(
                name: "IX_Colaborador_CaixaId",
                table: "Colaborador");

            migrationBuilder.DropIndex(
                name: "IX_Colaborador_PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "PagamentoColaborador");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "PagamentoColaborador");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "PagamentoCliente");

            migrationBuilder.DropColumn(
                name: "PagamentoClienteId",
                table: "OrdemServico");

            migrationBuilder.DropColumn(
                name: "CaixaId",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "PagamentoColaboradorId",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "PorcentagemComissao",
                table: "Colaborador");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Caixa");

            migrationBuilder.DropColumn(
                name: "ValorMovimentado",
                table: "Caixa");

            migrationBuilder.RenameColumn(
                name: "FormasPagamentoId",
                table: "PagamentoColaborador",
                newName: "FormasPagamentoID");

            migrationBuilder.RenameIndex(
                name: "IX_PagamentoColaborador_FormasPagamentoId",
                table: "PagamentoColaborador",
                newName: "IX_PagamentoColaborador_FormasPagamentoID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CargoContratoTrabalho",
                newName: "ID");

            migrationBuilder.AlterColumn<int>(
                name: "FormasPagamentoID",
                table: "PagamentoColaborador",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorId",
                table: "PagamentoColaborador",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorComissao",
                table: "PagamentoColaborador",
                type: "DECIMAL(6,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PagamentoColaboradorPJId",
                table: "Agendamento",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PagamentoColaboradorCLT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PagamentoColaboradorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoColaboradorCLT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentoColaboradorCLT_PagamentoColaborador_Id",
                        column: x => x.Id,
                        principalTable: "PagamentoColaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagamentoColaboradorCLT_PagamentoColaborador_PagamentoColaboradorID",
                        column: x => x.PagamentoColaboradorID,
                        principalTable: "PagamentoColaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoColaboradorPJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PagamentoColaboradorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoColaboradorPJ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentoColaboradorPJ_PagamentoColaborador_Id",
                        column: x => x.Id,
                        principalTable: "PagamentoColaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagamentoColaboradorPJ_PagamentoColaborador_PagamentoColaboradorID",
                        column: x => x.PagamentoColaboradorID,
                        principalTable: "PagamentoColaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaborador_ColaboradorId",
                table: "PagamentoColaborador",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_PagamentoColaboradorPJId",
                table: "Agendamento",
                column: "PagamentoColaboradorPJId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaboradorCLT_PagamentoColaboradorID",
                table: "PagamentoColaboradorCLT",
                column: "PagamentoColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaboradorPJ_PagamentoColaboradorID",
                table: "PagamentoColaboradorPJ",
                column: "PagamentoColaboradorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_PagamentoColaboradorPJ_PagamentoColaboradorPJId",
                table: "Agendamento",
                column: "PagamentoColaboradorPJId",
                principalTable: "PagamentoColaboradorPJ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PagamentoColaborador_Colaborador_ColaboradorId",
                table: "PagamentoColaborador",
                column: "ColaboradorId",
                principalTable: "Colaborador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PagamentoColaborador_FormasPagamento_FormasPagamentoID",
                table: "PagamentoColaborador",
                column: "FormasPagamentoID",
                principalTable: "FormasPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
