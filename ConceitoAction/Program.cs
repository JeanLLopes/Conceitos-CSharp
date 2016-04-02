using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //REPRESENTA UM METODO QUE EXECUTA UMA AÇAÕ
            //AÇÃO EM UM METODO ESPECIFICO
            //DISPARA UM DELEGATE
            var usuarios = new List<Usuario>()
            {
                new Usuario(){Nome = "Paulo"},
                new Usuario(){Nome = "Renato"},
                new Usuario(){Nome = "Felipe"},
                new Usuario(){Nome = "Vera"}
            };

            //LISTAR OS USUARIO
            //LISTA 
            //PASSASMOS O DELEGATE COMO PARAMETRO
            //A CADA ITEM DO FOREACH, NOS CHAMAMOS O METODO
            usuarios.ForEach(new Action<Usuario>(MostraDados));

            Console.ReadLine();

        }



        //AQUI NOS GERAMOS O METODO DO DELEGATE
        private static void MostraDados(Usuario user)
        {
            //AQUI NOS TEMOS O OBJETO COMPLETO
            Console.WriteLine(user.Nome);
        }

    }
}
