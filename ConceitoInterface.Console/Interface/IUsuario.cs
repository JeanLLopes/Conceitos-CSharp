using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoInterface.Console
{
    interface IUsuario
    {
        //AQUI NOS DEFINMOS OS METODOS DE ACESSO PARA NOSSA APLICAÇÃO
        //DEFINIMOS OS CONTRATOS
        IEnumerable<UsuarioMOD> ListaUsuario();
        UsuarioMOD LoginUsuario(int id);
        void Cadastrar(UsuarioMOD dadosUsuairo);
        void Excluir(UsuarioMOD dadosUsuario);
        void Atualizar(UsuarioMOD dadosUsuario);

    }
}
