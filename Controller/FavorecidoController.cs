using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class FavorecidoController
    {
        FavorecidoDAO favorecidoDAO = new FavorecidoDAO();

        public Favorecido PorId(long favorecidoId)
        {
            return this.favorecidoDAO.PorId(favorecidoId);
        }

        public void Salvar(Favorecido favorecido)
        {
            this.favorecidoDAO.Salvar(favorecido);
        }

        public void Atualizar(Favorecido favorecido)
        {
            this.favorecidoDAO.Atualizar(favorecido);
        }

        public IList<Favorecido> Listar()
        {
            return this.favorecidoDAO.Listar();
        }

        public void Excluir(long favorecidoId)
        {
            this.favorecidoDAO.Excluir(favorecidoId);
        }

        public IList<Favorecido> PorNome(string nome)
        {
            return this.favorecidoDAO.PorNome(nome);
        }
    }
}
