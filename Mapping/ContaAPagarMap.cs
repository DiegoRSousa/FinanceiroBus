using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class ContaAPagarMap : EntityTypeConfiguration<ContaAPagar>
    {
        public ContaAPagarMap()
        {
            ToTable("contas_a_pagar");
            HasKey(x => x.Id);

            Property(x => x.Referencia).HasMaxLength(240).IsRequired();
            Property(x => x.Valor).IsRequired();

            HasRequired(x => x.Favorecido);
        }
    }
}
