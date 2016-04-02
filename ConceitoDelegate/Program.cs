using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace ConceitoDelegate
{
    class Program
    {

        //DECLARAMS UM DELEGATE
        delegate int Formula(int a, int b);
        delegate int FormulaOpcionais(int a, int b, int c);

        //PODEMOS TAMBEM PASSAR UM VALOR PADRÃO PARA OS ITENS
        delegate int FormulaPadrao(int a = 10, int b = 20, int c = 30);

        static void Main(string[] args)
        {
            //CHAMAMOS O METODO NORMAL
            Console.WriteLine(Calcular(10,20));


            //CHAMAMOS O DELEGATE, CRIADO ENCIMA
            //NO CASO DO DELEGATE
            //NOS CRIAMOS TUDO NA MESMA LINHA
            //AO INVES DE CRIAMOS UM NOVO METODO
            //ELE CRIA A FORMULA EM TEMPO DE EXECUÇÃO
            Formula op = (a, b) => (a + b)*3;

            //NA SEGUNDA LINHA NOS DECLARAMOS OS VALORES
            //A SEREM ENVIADOS
            Console.WriteLine(op(10,20));






            //AQUI NOS PEGAMOS UM NOVO EXEMPLO
            FormulaOpcionais op2 = (a, b, c) => (a + b)*3 + c;
            
            //NA SEGUNDA LINHA NOS ENVIAMOS OS VALORES 
            //DOS ITENS
            Console.WriteLine(op2(4, 6, 9));





            //PARA ITENS COM VALORE DEFAULT
            FormulaPadrao op3 = (a, b, c) => (a + c)*b - 3;

            //COMO NOS SETAMOS UM VALOR PADRAO PARA NOSSO
            //DELEGATE, PODEMOS INFORMAR OU NAO OS PARAMETRO
            Console.WriteLine(op3(1));
            Console.WriteLine(op3(1, 30));
            Console.WriteLine(op3(1, 30, 40));

            Console.ReadLine();
        }


        static int Calcular(int a, int b)
        {
            return (a + b)*3;
        }
    }
}
