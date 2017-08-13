using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class PagamentoMap : EntityTypeConfiguration<Pagamento>
    {
        public PagamentoMap()
        {
            ToTable("pagamentos");
            HasKey(x => x.Id);

            HasRequired(x => x.ContaAPagar);
        }

    }
}
