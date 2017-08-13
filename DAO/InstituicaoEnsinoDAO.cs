using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class InstituicaoEnsinoDAO
    {
        public void Salvar(InstituicaoEnsino instituicaoEnsino)
        {
            using (var context = new EFContext())
            {
                context.InstituicoesEnsino.Add(instituicaoEnsino);
                context.SaveChanges();
            }
        }

        public void Atualizar(InstituicaoEnsino instituicaoEnsino)
        {
            using (var context = new EFContext())
            {
                var novaInstituicaoEnsino = context.InstituicoesEnsino.Find(instituicaoEnsino.Id);
                novaInstituicaoEnsino.Acronimo = instituicaoEnsino.Acronimo;
                novaInstituicaoEnsino.Nome = instituicaoEnsino.Nome;
                context.SaveChanges();
            }
        }

        public IList<InstituicaoEnsino> Listar()
        {
            using (var context = new EFContext())
            {
                return context.InstituicoesEnsino.ToList<InstituicaoEnsino>();
            }
        }

        public void Excluir(long idInstituicaoEnsino)
        {
            using (var context = new EFContext())
            {
                var instituicaoEnsino = context.InstituicoesEnsino.Find(idInstituicaoEnsino);
                context.InstituicoesEnsino.Remove(instituicaoEnsino);
                context.SaveChanges();
            }
        }

        public IList<InstituicaoEnsino> PorAcronimo(string acronimo)
        {
            using (var context = new EFContext())
            {
                var query = context.InstituicoesEnsino.Where(i => i.Acronimo.Contains(acronimo));
                return query.ToList<InstituicaoEnsino>();
            }
        }
    }
}
