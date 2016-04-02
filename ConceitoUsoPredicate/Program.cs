using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoUsoPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //O PREDICATE É BEMPARECIDO COM O CONCEITO DE ACTION
            //POREM ELE RETURNA UM BOORLEANO
            var usuarios = new List<Usuario>()
            {
                new Usuario() {Nome = "Paulo"},
                new Usuario() {Nome = "Paulo1"},
                new Usuario() {Nome = "Paulo2"},
                new Usuario() {Nome = "Paulo3"},
                new Usuario() {Nome = "Paulo4"},
                new Usuario() {Nome = "Paulo5"},
                new Usuario() {Nome = "Paulo6"}
            };

            //NESSE CASO DESSA PESQUISA ELE VAI PARA DE 
            //EXECUTAR ASSIM QUE ENCONTRAR O ITEM
            Usuario pesquisa = usuarios.Find(new Predicate<Usuario>(Pesquisar2));
            
            //AQUI ELE VERIFICA SE O RESULTADO DA PESQUISA TEVE
            //ALGUM RETORNO RESPEITANDO O COMANDO ABAIXO
            if (pesquisa != null)
            {
                Console.WriteLine(pesquisa.Nome);
            }




            //USANDO AGORA COM LAMBDA
            //aqui ele vai desparar um predicate
            var resultado = usuarios.Where(n => n.Nome.StartsWith("Pa"));




            //USANDO LINQ
            var linq = from n in usuarios where n.Nome.StartsWith("Pau") select n;


            Console.ReadLine();

        }

        private static bool Pesquisar2(Usuario user)
        {
            //RETONA QUANDO A STRING CONTEM 1 NA STRING
            return user.Nome.Contains("1");
        }

        private static bool Pesquisar1(Usuario user)
        {
            //ALGUM NOME QUE COMECE COM Pau
            return user.Nome.StartsWith("Pau");
        }




        private static bool Pesquisar(Usuario user)
        {
            return user.Nome.Length == 6;
        }
    }
}
