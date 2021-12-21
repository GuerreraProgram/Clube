using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube
{
    public class Socio : Pessoa
    {
        private string nmr_cartao;
        private string nome;
        private string endereco;
        private string telefone;
        private string email;
        private List<Dependente> dependentes = new List<Dependente>();
        private List<Mensalidade> mensalidades = new List<Mensalidade>();

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        
        public void adicionar_dependente(Dependente dependente)
        {
            this.dependentes.Add(dependente);
        }

        public void adicionar_mensalidade(Mensalidade mensalidade)
        {
            this.mensalidades.Add(mensalidade);
        }
    }
}
