using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoInterface.Console
{
    //AQUIN OS DEFINIMOS QUE ESSA INTERFACE VAI RECEBER UMA CLASS GENERICA 
    public interface IGenerico<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Lista();
        IQueryable<TEntity> ListaTodos();
        void Cadastrar(TEntity dados);
        void Excluir(TEntity dados);
        void Atualizar(TEntity dados);
    }
}
