using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        private TipoPessoa tipoPessoa;
        private int id;
        private string cpf_cnpj;
        private DateTime dataNascimeto;
        private string razaoSocial;
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string complemento;
        private string cep;
        private string telefone;
        private string email;
        private string celular;
        private decimal limite;

        public TipoPessoa TipoPessoa { get => tipoPessoa; set => tipoPessoa = value; }
        public int Id { get => id; set => id = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public DateTime DataNascimeto { get => dataNascimeto; set => dataNascimeto = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Celular { get => celular; set => celular = value; }
        public decimal Limite { get => limite; set => limite = value; }
    }
}
