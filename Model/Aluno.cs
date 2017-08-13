using System.Collections.Generic;

namespace FinanceiroBus.Model
{
    public class Aluno
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
