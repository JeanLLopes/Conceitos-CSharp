using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceitoInterface.Console.Model;

namespace ConceitoInterface.Console
{
    //AQUI OS IMPLEMENTAMOS A INTERFACE, POREM AGORA USANDO 
    //UMA CLASSE DE CARRO
    //COM UMA INTERFACE GENERICA NOS PODEMOS ENVIAR COMO PARAMETRO QUALQUER CLASSE
    class GenericoCarro : IGenerico<CarroMOD>
    {

        public IEnumerable<CarroMOD> Lista()
        {
            throw new NotImplementedException();
        }

        public IQueryable<CarroMOD> ListaTodos()
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CarroMOD dados)
        {
            throw new NotImplementedException();
        }

        public void Excluir(CarroMOD dados)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(CarroMOD dados)
        {
            throw new NotImplementedException();
        }
    }
}
