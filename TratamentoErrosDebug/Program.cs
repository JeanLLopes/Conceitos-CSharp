using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoErrosDebug
{
    class Program
    {
        static void Main(string[] args)
        {

            //DEBUG
            //USANDO F11 
            //O USANDO F10
            int v1 = 0;
            int v2 = 20;
            int total = 0;




            //USANDO O TRY... CACTH
            try
            {
                //EFETUA O CODIGO
                //USANDO UMA CONDICIONAL IF
                Console.WriteLine(CalculaDivisao(v1, v2));

            }

            //SEMPRE AS EXCEÇÕES A MAIS DEVEM FICAR
            //ANTES DO EXCEPTION DEFAULT
            catch (ArgumentException e)
            {
                //ARGUMENT EXCEPTION
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                //EXCEPTION
                Console.WriteLine(e.Message);
            }
            

            //CHAMA O METDO INTERNO


            //APRESENTANDO O TORAL NA TELA
            Console.WriteLine(total);
            Console.ReadLine();
        }


        static int CalculaDivisao(int v1, int v2)
        {
            try
            {
                return v2 / v1;
            }
            catch (Exception)
            {
                //PODEMOS SETAR UMA MENSAGEM DE ERRO
                //COMO TEMOS UM TRATAMENTO DE ERRO NA ROTINA
                //ASSIM PASSAMOS UMA MENSAGEM COSTUMIZADA 
                //PARA NOSSO CLIENTE
                throw new Exception("Ocorreu um Erro na Divisão");
            }
        }
    }
}
