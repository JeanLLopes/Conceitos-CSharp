using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {0, 2, 4, 5, 6, 87, 23, 1, 5, 8, 9, 0};
            
            //PEGAR O MAIOR NUMERO DA APLICAÇÃO
            //MAIS COMUM USANDO METODOS DE EXTESÃO
            var valor1 = numeros.Max(x => x);
            var valor2 = numeros.Where(x => x > 5);


            //USANDO DELEGATE 
            int contador = 0;
            Func<int> numero = () => contador++;

            Console.WriteLine(numero());
            Console.WriteLine(numero());
            Console.WriteLine(numero());
            Console.WriteLine(numero());
            Console.WriteLine(numero());



            //FUNCÃO
            //COM PARAMETRO DE ENTRADA STRING
            //PARAMETRO DE SAIDA NUMERO
            Func<string, int> letras = x => x.Length;

            //AQUI NOS CHAMAMOS A FUNÇÃO QUE CRIAMOS
            //PARA CHAMAR A FUNÇAÕ DEVEMOS PASSAR O TEXTO PARA QUE 
            //ELE CALCULE PARA NOS OS RESULTADO
            Console.WriteLine(letras("Usando Visual C#"));


            //NESSA CASO ABAIXO
            //NOS VAMOS CRIAR O METODO, AO CONTRARIO DO 
            //DELEGATE QUE CRIA A FUNÇÃO EM TEMPO DE EXECUÇÃO
            Console.WriteLine(QuantidadeLetras("Usando Visual C#"));



            Console.WriteLine("Impostos -------");
            
            //NOSSA FUNÇÃO AGORA VAI RETORNAR
            //UMA VALR DECIMAL ( ULTIMO PARAMETRO DA FUNÇAÕ )
            //E VAI RECEBER DOIS VALORES UM INTEIRO E UM DECIMAL
            Func<int, decimal, decimal> imposto = (valor, percentual) => valor*(percentual/100);

            //VOU PEDIR PRA CALCULAR O VALOR DE 
            //10 PORCENTO DE 1000
            Console.WriteLine(imposto(1000, 10));
            Console.WriteLine(imposto(2500, 10));



            Console.WriteLine("Impostos -------");


            Console.ReadLine();
        }


        //AQUI NOS CRIAMOS UM METODO QUE FAZ
        //O MESMO QUE NOSSO DELEGATE 
        private static int QuantidadeLetras(string p)
        {
            return p.Length;
        }
    }
}
