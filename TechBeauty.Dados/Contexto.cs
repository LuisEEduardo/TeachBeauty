using Microsoft.EntityFrameworkCore;
using System;
using TechBeauty.Dados.Map;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados
{
    public class Contexto : DbContext
    {
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<CargoContratoTrabalho> CargoContratoTrabalho { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<ContratoTrabalho> ContratoTrabalho { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Escala> Escala { get; set; }
        public DbSet<FechamentoDiario> FechamentoDiario { get; set; }
        public DbSet<FormasPagamento> FormasPagamento { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<LogAgendamento> LogAgendamentos { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<PagamentoClienteFechamentoDiario> PagamentoClienteFechamentoDiario { get; set; }
        public DbSet<PagamentoClienteFormasPagamento> PagamentoClienteFormasPagamento { get; set; }
        public DbSet<PagamentoCliente> PagamentoCliente { get; set; }
        public DbSet<PagamentoColaboradorCLT> PagamentoColaboradorCLT { get; set; }
        public DbSet<PagamentoColaborador> PagamentoColaborador { get; set; }
        public DbSet<PagamentoColaboradorPJ> PagamentoColaboradorPJ { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<RegimeContratual> RegimeContratual { get; set; }
        public DbSet<ServicoColaborador> ServicoColaborador { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //                                                               // User ID=name; Password=password
            optionsBuilder.UseSqlServer("Server=MIR-0553; Database=TechBeauty; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendamentoMap());
            modelBuilder.ApplyConfiguration(new CaixaMap());
            modelBuilder.ApplyConfiguration(new CargoContratoTrabalhoMap());
            modelBuilder.ApplyConfiguration(new CargoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new ContratoTrabalhoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EscalaMap());
            modelBuilder.ApplyConfiguration(new FechamentoDiarioMap());
            modelBuilder.ApplyConfiguration(new FormasPagamentoMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new LogAgendamentoMap());
            modelBuilder.ApplyConfiguration(new OrdemServicoMap());
            modelBuilder.ApplyConfiguration(new PagamentoClienteFechamentoDiarioMap());
            modelBuilder.ApplyConfiguration(new PagamentoClienteFormasPagamentoMap());
            modelBuilder.ApplyConfiguration(new PagamentoClienteMap());
            modelBuilder.ApplyConfiguration(new PagamentoColaboradorCLTMap());
            modelBuilder.ApplyConfiguration(new PagamentoColaboradorMap());
            modelBuilder.ApplyConfiguration(new PagamentoColaboradorPJMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new RegimeContratualMap());
            modelBuilder.ApplyConfiguration(new ServicoColaboradorMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
            modelBuilder.ApplyConfiguration(new TipoContatoMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
