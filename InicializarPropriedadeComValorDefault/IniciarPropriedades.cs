using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicializarPropriedadeComValorDefault
{
    class IniciarPropriedades
    {
    }

    public class Produto
    {
        //DEFININDO VALOR PADRÃO
        public int Id { get; set; }
        public string Nome { get; set; } = "Produto Novo"
        public decimal Preco { get; set; } = 10
        public double Quantidade { get; set; }

    }
}
