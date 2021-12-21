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
    public partial class FormListMensalidades : Form
    {
        public FormListMensalidades()
        {
            InitializeComponent();
        }

        private void btn_adcsocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
