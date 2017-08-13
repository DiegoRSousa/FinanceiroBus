using System.Collections.Generic;

namespace FinanceiroBus.Model
{
    public class Favorecido
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public TipoFavorecido TipoFavorecido { get; set; }
        public IList<ContaAPagar> ContasAPagar { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
