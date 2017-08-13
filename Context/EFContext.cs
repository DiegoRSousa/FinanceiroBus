using FinanceiroBus.Mapping;
using FinanceiroBus.Model;
using System.Data.Entity;

namespace FinanceiroBus.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("FinanceiroBus")
        {
            Database.SetInitializer<EFContext>(
                //new EFInitializer());
                //new CreateDatabaseIfNotExists<EFContext>());
                new DropCreateDatabaseIfModelChanges<EFContext>());
                //new DropCreateDatabaseAlways<EFContext>());
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public DbSet<Favorecido> Favorecidos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<ContaAReceber> ContasAReceber { get; set; }
        public DbSet<Recebimento> Recebimentos { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }
        public DbSet<ContaAPagar> ContasAPagar { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new InstituicaoEnsinoMap());
            modelBuilder.Configurations.Add(new FavorecidoMap());
            modelBuilder.Configurations.Add(new ContratoMap());
            modelBuilder.Configurations.Add(new ContaAReceberMap());
            modelBuilder.Configurations.Add(new RecebimentoMap());
            modelBuilder.Configurations.Add(new ConfiguracaoMap());
            modelBuilder.Configurations.Add(new ContaAPagarMap());
            modelBuilder.Configurations.Add(new PagamentoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
