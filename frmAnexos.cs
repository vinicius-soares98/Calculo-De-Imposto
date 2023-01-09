using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impostos_Brasil
{
    public partial class FrmAnexos : Form
    {
        public FrmAnexos()
        {
            InitializeComponent();
        }

        private void btnAnexo1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm12MesesOuMais frm12MesesOuMais = new Frm12MesesOuMais();
            frm12MesesOuMais.Show();
        }

        private void btnAnexo2_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm12MesesOuMais frm12MesesOuMais = new Frm12MesesOuMais();
            frm12MesesOuMais.Show();
        }
    }
}
