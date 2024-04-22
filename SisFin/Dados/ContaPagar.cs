using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ContaPagar
    {
        private int id;
        private decimal valor;
        private DateTime dataCadastro;
        private DateTime dataVencimento;
        private DateTime dataPagamento;
        private MeioPagamento meioPagamento;
        private EstadoPagamento situacao;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public DateTime DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public MeioPagamento MeioPagamento { get => meioPagamento; set => meioPagamento = value; }
        public EstadoPagamento Situacao { get => situacao; set => situacao = value; }
    }
}
