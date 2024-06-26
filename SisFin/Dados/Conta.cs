﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Conta
    {
        private int id;
        private string descricao;
        private TipoConta tipo;
        private bool status;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public TipoConta Tipo { get => tipo; set => tipo = value; }
        public bool Status { get => status; set => status = value; }
    }
}
