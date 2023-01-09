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
    public partial class FrmCalculoSN : Form
    {
        public FrmCalculoSN()
        {
            InitializeComponent();
        }

        private void btn12MesesOuMais_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm12MesesOuMais frm12MesesOuMais = new Frm12MesesOuMais();
            frm12MesesOuMais.Show();
        }

        private void btn1Mes_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm1Mes frm1Mes= new Frm1Mes();
            frm1Mes.Show();
        }

        private void btn2a11Meses_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm2a11Meses frm2A11Meses= new Frm2a11Meses();
            frm2A11Meses.Show();
        }
    }
}
