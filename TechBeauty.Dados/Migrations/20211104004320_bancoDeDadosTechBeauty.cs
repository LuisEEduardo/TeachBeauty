using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class bancoDeDadosTechBeauty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorEmCaixa = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    UF = table.Column<string>(type: "CHAR(2)", nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR(15)", nullable: false),
                    Complemento = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    CEP = table.Column<string>(type: "VARCHAR(8)", nullable: false),
                    Bairro = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CPF = table.Column<string>(type: "CHAR(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegimeContratual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegimeContratual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Preco = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    DuracaoEmMin = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FechamentoDiario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataFechamento = table.Column<DateTime>(type: "DATE", nullable: false),
                    ValorFechamento = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false),
                    CaixaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FechamentoDiario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FechamentoDiario_Caixa_CaixaID",
                        column: x => x.CaixaID,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NomeSocial = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    EnderecoID = table.Column<int>(type: "int", nullable: false),
                    GeneroID = table.Column<int>(type: "int", nullable: false),
                    ContratoTrabalhoID = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Endereco_EnderecoID",
                        column: x => x.EnderecoID,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Genero_GeneroID",
                        column: x => x.GeneroID,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "VARCHAR(256)", nullable: false),
                    TipoContatoID = table.Column<int>(type: "int", nullable: false),
                    PessoaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_PessoaID",
                        column: x => x.PessoaID,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_TipoContato_TipoContatoID",
                        column: x => x.TipoContatoID,
                        principalTable: "TipoContato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaPagamento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    FormasPagamentoId = table.Column<int>(type: "int", nullable: true),
                    StatusPagamento = table.Column<int>(type: "INT", nullable: false),
                    Pagamento = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false),
                    FechamentoDiarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentoCliente_FechamentoDiario_FechamentoDiarioId",
                        column: x => x.FechamentoDiarioId,
                        principalTable: "FechamentoDiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagamentoCliente_FormasPagamento_FormasPagamentoId",
                        column: x => x.FormasPagamentoId,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecoTotal = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false),
                    DuracaoTotal = table.Column<int>(type: "INT", nullable: false),
                    Status = table.Column<int>(type: "INT", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContratoTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegimeContratualID = table.Column<int>(type: "int", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "Date", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "Date", nullable: true),
                    ColaboradorID = table.Column<int>(type: "int", nullable: false),
                    CnpjCTPS = table.Column<string>(type: "VARCHAR(14)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_RegimeContratual_RegimeContratualID",
                        column: x => x.RegimeContratualID,
                        principalTable: "RegimeContratual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraEntrada = table.Column<DateTime>(type: "DATE", nullable: false),
                    DataHoraSaida = table.Column<DateTime>(type: "DATE", nullable: false),
                    ColaboradorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escala_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoColaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColaboradorId = table.Column<int>(type: "int", nullable: true),
                    StatusPagamento = table.Column<int>(type: "INT", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ValorComissao = table.Column<decimal>(type: "DECIMAL(6,2)", nullable: false),
                    FormasPagamentoID = table.Column<int>(type: "int", nullable: false),
                    CaixaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoColaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentoColaborador_Caixa_CaixaID",
                        column: x => x.CaixaID,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagamentoColaborador_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PagamentoColaborador_FormasPagamento_FormasPagamentoID",
                        column: x => x.FormasPagamentoID,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicoColaborador",
                columns: table => new
                {
                    ColaboradorID = table.Column<int>(type: "int", nullable: false),
                    ServicoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoColaborador", x => new { x.ServicoID, x.ColaboradorID });
                    table.ForeignKey(
                        name: "FK_ServicoColaborador_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoColaborador_Servico_ServicoID",
                        column: x => x.ServicoID,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoClienteFechamentoDiario",
                columns: table => new
                {
                    PagamentoClienteID = table.Column<int>(type: "int", nullable: false),
                    FechamentoDiarioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoClienteFechamentoDiario", x => new { x.FechamentoDiarioID, x.PagamentoClienteID });
                    table.ForeignKey(
                        name: "FK_PagamentoClienteFechamentoDiario_FechamentoDiario_FechamentoDiarioID",
                        column: x => x.FechamentoDiarioID,
                        principalTable: "FechamentoDiario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagamentoClienteFechamentoDiario_PagamentoCliente_PagamentoClienteID",
                        column: x => x.PagamentoClienteID,
                        principalTable: "PagamentoCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagamentoClienteFormasPagamento",
                columns: table => new
                {
                    PagamentoClienteID = table.Column<int>(type: "int", nullable: false),
                    FormasPagamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentoClienteFormasPagamento", x => new { x.PagamentoClienteID, x.FormasPagamentoID });
                    table.ForeignKey(
                        name: "FK_PagamentoClienteFormasPagamento_FormasPagamento_FormasPagamentoID",
                        column: x => x.FormasPagamentoID,
                        principalTable: "FormasPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagamentoClienteFormasPagamento_PagamentoCliente_PagamentoClienteID",
                        column: x => x.PagamentoClienteID,
                        principalTable: "PagamentoCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CargoContratoTrabalho",
                columns: table => new
                {
                    CargoID = table.Column<int>(type: "int", nullable: false),
                    ContratoDeTrabalhoID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoContratoTrabalho", x => new { x.CargoID, x.ContratoDeTrabalhoID });
                    table.ForeignKey(
                        name: "FK_CargoContratoTrabalho_Cargo_CargoID",
                        column: x => x.CargoID,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoContratoTrabalho_ContratoTrabalho_ContratoDeTrabalhoID",
                        column: x => x.ContratoDeTrabalhoID,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaAtendia = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    DataHoraInicio = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    DataHoraCriacao = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    DataHoraTermino = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    ServicoID = table.Column<int>(type: "int", nullable: false),
                    ColaboradorID = table.Column<int>(type: "int", nullable: false),
                    OrdemServicoID = table.Column<int>(type: "int", nullable: false),
                    PagamentoClienteID = table.Column<int>(type: "int", nullable: false),
                    PagamentoColaboradorPJId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamento_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_OrdemServico_OrdemServicoID",
                        column: x => x.OrdemServicoID,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_PagamentoCliente_PagamentoClienteID",
                        column: x => x.PagamentoClienteID,
                        principalTable: "PagamentoCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_PagamentoColaboradorPJ_PagamentoColaboradorPJId",
                        column: x => x.PagamentoColaboradorPJId,
                        principalTable: "PagamentoColaboradorPJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamento_Servico_ServicoID",
                        column: x => x.ServicoID,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogAgendamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgendamentoID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "INT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAgendamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogAgendamento_Agendamento_AgendamentoID",
                        column: x => x.AgendamentoID,
                        principalTable: "Agendamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ColaboradorID",
                table: "Agendamento",
                column: "ColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_OrdemServicoID",
                table: "Agendamento",
                column: "OrdemServicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_PagamentoClienteID",
                table: "Agendamento",
                column: "PagamentoClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_PagamentoColaboradorPJId",
                table: "Agendamento",
                column: "PagamentoColaboradorPJId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ServicoID",
                table: "Agendamento",
                column: "ServicoID");

            migrationBuilder.CreateIndex(
                name: "IX_CargoContratoTrabalho_ContratoDeTrabalhoID",
                table: "CargoContratoTrabalho",
                column: "ContratoDeTrabalhoID");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_EnderecoID",
                table: "Colaborador",
                column: "EnderecoID");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_GeneroID",
                table: "Colaborador",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_PessoaID",
                table: "Contato",
                column: "PessoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TipoContatoID",
                table: "Contato",
                column: "TipoContatoID");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_ColaboradorID",
                table: "ContratoTrabalho",
                column: "ColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_RegimeContratualID",
                table: "ContratoTrabalho",
                column: "RegimeContratualID");

            migrationBuilder.CreateIndex(
                name: "IX_Escala_ColaboradorID",
                table: "Escala",
                column: "ColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_FechamentoDiario_CaixaID",
                table: "FechamentoDiario",
                column: "CaixaID");

            migrationBuilder.CreateIndex(
                name: "IX_LogAgendamento_AgendamentoID",
                table: "LogAgendamento",
                column: "AgendamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_ClienteID",
                table: "OrdemServico",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoCliente_FechamentoDiarioId",
                table: "PagamentoCliente",
                column: "FechamentoDiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoCliente_FormasPagamentoId",
                table: "PagamentoCliente",
                column: "FormasPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoClienteFechamentoDiario_PagamentoClienteID",
                table: "PagamentoClienteFechamentoDiario",
                column: "PagamentoClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoClienteFormasPagamento_FormasPagamentoID",
                table: "PagamentoClienteFormasPagamento",
                column: "FormasPagamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaborador_CaixaID",
                table: "PagamentoColaborador",
                column: "CaixaID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaborador_ColaboradorId",
                table: "PagamentoColaborador",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaborador_FormasPagamentoID",
                table: "PagamentoColaborador",
                column: "FormasPagamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaboradorCLT_PagamentoColaboradorID",
                table: "PagamentoColaboradorCLT",
                column: "PagamentoColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentoColaboradorPJ_PagamentoColaboradorID",
                table: "PagamentoColaboradorPJ",
                column: "PagamentoColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoColaborador_ColaboradorID",
                table: "ServicoColaborador",
                column: "ColaboradorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoContratoTrabalho");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Escala");

            migrationBuilder.DropTable(
                name: "LogAgendamento");

            migrationBuilder.DropTable(
                name: "PagamentoClienteFechamentoDiario");

            migrationBuilder.DropTable(
                name: "PagamentoClienteFormasPagamento");

            migrationBuilder.DropTable(
                name: "PagamentoColaboradorCLT");

            migrationBuilder.DropTable(
                name: "ServicoColaborador");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "ContratoTrabalho");

            migrationBuilder.DropTable(
                name: "TipoContato");

            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "RegimeContratual");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "PagamentoCliente");

            migrationBuilder.DropTable(
                name: "PagamentoColaboradorPJ");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "FechamentoDiario");

            migrationBuilder.DropTable(
                name: "PagamentoColaborador");

            migrationBuilder.DropTable(
                name: "Caixa");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "FormasPagamento");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
