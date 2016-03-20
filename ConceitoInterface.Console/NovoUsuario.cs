using System;
using System.Collections.Generic;

namespace ConceitoInterface.Console
{
    //NESSA CLASSE NOS IMPLEMENTAMOS A INTERFACE
    public class NovoUsuario : IUsuario
    {
        #region IUSUARIO
        public IEnumerable<UsuarioMOD> ListaUsuario()
        {
            throw new NotImplementedException();
        }

        public UsuarioMOD LoginUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(UsuarioMOD dadosUsuairo)
        {
            throw new NotImplementedException();
        }

        public void Excluir(UsuarioMOD dadosUsuario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(UsuarioMOD dadosUsuario)
        {
            throw new NotImplementedException();
        }

        #endregion  
    }
}
