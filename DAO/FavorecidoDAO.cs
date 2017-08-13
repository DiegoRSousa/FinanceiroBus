using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class FavorecidoDAO
    {
        private EFContext context = new EFContext();

        public Favorecido PorId(long favorecidoId)
        {
            return this.context.Favorecidos.Find(favorecidoId);
        }

        public void Salvar(Favorecido favorecido)
        {
            context.Favorecidos.Add(favorecido);
            context.SaveChanges();
        }

        public void Atualizar(Favorecido favorecido)
        {
            var novoFavorecido = PorId(favorecido.Id);
            novoFavorecido.Nome = favorecido.Nome;
            novoFavorecido.Telefone = favorecido.Telefone;
            novoFavorecido.TipoFavorecido = favorecido.TipoFavorecido;
            context.SaveChanges();
        }

        public IList<Favorecido> Listar()
        {
            return context.Favorecidos.ToList<Favorecido>();
        }

        public void Excluir(long favorecidoId)
        {
            var favorecido = PorId(favorecidoId);
            context.Favorecidos.Remove(favorecido);
            context.SaveChanges();
        }

        public IList<Favorecido> PorNome(string nome)
        {
            var query = context.Favorecidos.Where(a => a.Nome.Contains(nome));
            return query.ToList<Favorecido>();
        }
    }
}
