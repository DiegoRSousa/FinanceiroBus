using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class ContratoMap : EntityTypeConfiguration<Contrato>
    {
        public ContratoMap()
        {
            ToTable("contratos");
            HasKey(x => x.Id);

            HasRequired(x => x.Aluno);
            HasRequired(x => x.InstituicaoEnsino);

            HasMany(x => x.ContasAReceber);
        }
    }
}
