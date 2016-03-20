using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoInterface.Console
{
    //AQUINOS VAMOS FAZER ESTA CLASSE HERDA DE UMA INTERFACE QUE RECEBE UMA CLASSE GENERICA
    public class Generico : IGenerico<UsuarioMOD>
    {

        public IEnumerable<UsuarioMOD> Lista()
        {
            throw new NotImplementedException();
        }

        public IQueryable<UsuarioMOD> ListaTodos()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioMOD dados)
        {
            throw new NotImplementedException();
        }

        public void Excluir(UsuarioMOD dados)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(UsuarioMOD dados)
        {
            throw new NotImplementedException();
        }
    }
}
