using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class ConfiguracaoMap : EntityTypeConfiguration<Configuracao>
    {
        public ConfiguracaoMap()
        {
            ToTable("configuracoes");
            HasKey(x => x.Id);

            Property(x => x.Email).HasMaxLength(64).IsRequired();
            Property(x => x.Senha).HasMaxLength(64).IsRequired();
            Property(x => x.SMTP).HasMaxLength(64).IsRequired();
            Property(x => x.Porta).IsRequired();
        }
    }
}
