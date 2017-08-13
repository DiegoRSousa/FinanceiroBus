using System.Collections.Generic;

namespace FinanceiroBus.Model
{
    public class InstituicaoEnsino
    {
        public long Id { get; set; }
        public string Acronimo { get; set; }
        public string Nome { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }

        public override string ToString()
        {
            return Acronimo;
        }
    }
}