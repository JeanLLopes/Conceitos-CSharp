using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao
{
    public static class Program
    {
        static void Main(string[] args)
        {

            decimal valor = 4500;
            //CHAMAMOS UM METODO DE EXTESÃO
            Console.WriteLine(valor.Formatar("R$ ##,##0.00"));



            //CHAMAMOS OS METODOS DE EXTESÃO PARA DATA
            Console.WriteLine(DateTime.Today.FormatarData("D"));
            Console.WriteLine(DateTime.Today.FormatarData("dd/MM/yyyy"));




            //USANDO COM LAMBDA
            int[] numeros = {1, 20, 5, 40};

            //VERIFICA QUAIS NUMEROS SAO MAIORES QUE 10
            //E RETORNA TRUE OU FALSE
            Console.WriteLine(numeros.Any(x => x > 10));
        }


        //CRIAMOS O METODO DE EXTESÃO
        public static string Formatar(this decimal valor, string formato)
        {
            return valor.ToString(formato);
        }



        //CRIAMOS O METODO DE EXTESÃO PARA DATA
        public static string FormatarData(this DateTime data, string formato)
        {
            return data.ToString(formato);
        }
    }
}
