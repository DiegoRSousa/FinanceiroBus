using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class InstituicaoEnsinoMap : EntityTypeConfiguration<InstituicaoEnsino>
    {
        public InstituicaoEnsinoMap()
        {
            ToTable("instituicoes_ensino");
            HasKey(x => x.Id);

            Property(x => x.Acronimo).HasMaxLength(32);
            Property(x => x.Nome).HasMaxLength(120).IsRequired();

            HasMany(x => x.Contratos);
        }
    }
}
