﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Venda
    {
        private int id;
        private DateTime instante;
        private string descricao;
        private double desconto;
        private double valor_total;

        public int Id { get => id; set => id = value; }
        public DateTime Instante { get => instante; set => instante = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
    }
}
