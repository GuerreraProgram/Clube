using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    public class Pessoa
    {
        private string nome;
        private string nrm_cartao;
        private string endereco;
        private string telefone;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string Nrm_cartao { get => nrm_cartao; set => nrm_cartao = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
    }
}
