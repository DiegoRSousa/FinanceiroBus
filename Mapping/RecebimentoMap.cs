using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class RecebimentoMap : EntityTypeConfiguration<Recebimento>
    {
        public RecebimentoMap()
        {
            ToTable("recebimentos");
            HasKey(x => x.Id);

            HasRequired(x => x.ContaAReceber);
        }
    }
}
