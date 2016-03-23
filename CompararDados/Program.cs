using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //COMO PODEMOS COMPARAR UMA LISTA DE DADOS
            //E COLOCA-LA EM ORDEM CRESCENTE
            List<Usuario> usuarioList = new List<Usuario>()
            {
                new Usuario(){Id = 1,Nome = "Paulo"},
                new Usuario(){Id = 2,Nome = "Jose"},
                new Usuario(){Id = 3,Nome = "A"},
                new Usuario(){Id = 4,Nome = "Cielo"},
                new Usuario(){Id = 5,Nome = "Rede"},
                new Usuario(){Id = 6,Nome = "Master"}
            };


            //ORDENAÇÃOS
            usuarioList.Sort(new Comparison<Usuario>(Ordenar));


            //AQUI NOS CRIAMOS UM DELEGATE
            //E ENVIAMOS OS DADOS PARA A OUTRO METODO
            usuarioList.ForEach(new Action<Usuario>(ExibirDados));


            Console.ReadLine();
        }



        //AQUI NOS CRIAMOS O METODO CHAMADO ACIMA
        private static int Ordenar(Usuario usuario1, Usuario usuario2)
        {
            //RETORNA OS DADOS DA COMPARAÇÃO
            return Comparer<string>.Default.Compare(usuario1.Nome, usuario2.Nome);
        }


        private static void ExibirDados(Usuario User)
        {
            Console.WriteLine(User.Nome);
        }
    }
}
