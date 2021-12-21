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
    public partial class FormAdcCategorias : Form
    {
        public FormAdcCategorias()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tela_de_Entrada tela_De_Entrada = new Tela_de_Entrada();
            tela_De_Entrada.ShowDialog();
        }
    }
}
