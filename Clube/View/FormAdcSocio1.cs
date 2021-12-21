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
    public partial class FormAdcSocio1 : Form
    {
        public FormAdcSocio1()
        {
            InitializeComponent();
        }

        private void btn_adcsocio_Click(object sender, EventArgs e)
        {
            Tela_de_Entrada tela_De_Entrada = new Tela_de_Entrada();
            this.Close();
        }

        private void combo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nomesocio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
