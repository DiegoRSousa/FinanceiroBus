using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class FavorecidoMap : EntityTypeConfiguration<Favorecido>
    {
        public FavorecidoMap()
        {    
            ToTable("favorecidos");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(120).IsRequired();
            Property(x => x.Telefone).HasMaxLength(13).IsRequired();
            HasMany(x => x.ContasAPagar);
        }
    }
}
