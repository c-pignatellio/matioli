using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ItemVenda
    {
        private int quantidade;
        private decimal preco;
        private decimal desconto;

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
    }
}
