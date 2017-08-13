using FinanceiroBus.Model;
using System.Data.Entity.ModelConfiguration;

namespace FinanceiroBus.Mapping
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            ToTable("alunos");
            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(120).IsRequired();
            Property(x => x.Matricula).HasMaxLength(32);
            Property(x => x.Telefone).HasMaxLength(11).IsRequired();
            Property(x => x.Email).HasMaxLength(64);

            HasMany(x => x.Contratos);
        }
    }
}