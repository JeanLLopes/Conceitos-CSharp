using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilidadeDaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseA objA = new ClasseA(){x = 10, y = 20};
            Console.WriteLine(objA);

            Console.ReadLine();


            //SETAMOS A CLASSEB
            //QUE ESTA HEDANDO AS PROPRIEDADES DA CLASSEA
            //ClasseB objB = new ClasseB() {Salario = 100, x = 10, y = 20};
            
            
            //COMO A PROPRIEDADE SALARIO ESTA COMO private
            //NA CLASSE ELE NAO CONSEGUE ENCHEGAR
            ClasseB objB = new ClasseB() {x = 10, y = 20};
            objB.Salvar();

            Console.ReadLine();



            ClasseC objC = new ClasseC() {ID = 1};
            Console.ReadLine();
        }
    }



    //CASO NAO SEJA COLOCADO UMA VISIBILIDADE PARA A CLASSE
    //ELE ASSUME UM VALOR PADRAO DE PUBLIC
    class ClasseA
    {
        public int x { get; set; }
        public int y { get; set; }

        //ESTA PROPRIEDADE NAO ESTA DISPONIVEL PARA 
        //CLASSES FORA DESTE BLOCK
        protected int z { get; set; }



        //METODO PARA SALVAR 
        public void Salvar()
        {
            var item = new ClasseA() {y = 10, x = 20, z = 30};
            //SALVA ITENS NO BANCO
        }
    }


    class ClasseB : ClasseA
    {
        public int x { get; set; }
        private int Salario { get; set; }

    }


    //INSERIMOS O ATRIBUTO sealed
    //ELE NAO DEIXA A CLASSE SER HERDADA
    //NINGUEM VAI PODER HERDAR DA CLASSEC
    sealed class ClasseC
    {
        public int ID { get; set; }
    }

}
