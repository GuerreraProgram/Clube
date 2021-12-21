using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clube
{
    public partial class Tela_de_Entrada : Form
    {
        public Tela_de_Entrada()
        {
            InitializeComponent();
        }

        private void bt_irsocio_Click(object sender, EventArgs e)
        {
            FormAdcSocio1 formAdcSocio1 = new FormAdcSocio1();
            formAdcSocio1.ShowDialog();
        }

        private void bt_irdependentes_Click(object sender, EventArgs e)
        {
            FormAdcDependente formAdcDependente = new FormAdcDependente();
            formAdcDependente.ShowDialog();
        }

        private void bt_ircategorias_Click(object sender, EventArgs e)
        {
            FormAdcCategorias formAdcCategorias = new FormAdcCategorias();
            formAdcCategorias.ShowDialog();
        }

        private void bt_irlistarsocio_Click(object sender, EventArgs e)
        {
            FormListarSocios formListarSocios = new FormListarSocios();
            formListarSocios.ShowDialog();
        }

        private void bt_irmens_Click(object sender, EventArgs e)
        {
            FormPagarmensalidade formPagarMensalidade = new FormPagarmensalidade();
            formPagarMensalidade.ShowDialog();
        }

        private void btn_listarmens_Click(object sender, EventArgs e)
        {
            FormListMensalidades formListMensalidades = new FormListMensalidades();
            formListMensalidades.ShowDialog();
        }

        private void btn_adcsocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
