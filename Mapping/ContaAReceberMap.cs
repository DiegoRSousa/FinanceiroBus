using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class ContaAReceberMap : EntityTypeConfiguration<ContaAReceber>
    {
        public ContaAReceberMap()
        {
            ToTable("contas_a_receber");
            HasKey(x => x.Id);

            Property(x => x.Referencia).HasMaxLength(240).IsRequired();
            Property(x => x.Valor).IsRequired();

            HasRequired(x => x.Contrato);
        }
    }
}
