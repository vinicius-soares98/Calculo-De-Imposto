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
    public partial class CalculoImpostoME : Form
    {
        public CalculoImpostoME()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularImposto_Click(object sender, EventArgs e)
        {
            this.Close();  
            FrmCalculoSN frmCalculoSN = new FrmCalculoSN();
            frmCalculoSN.Show();
           
            
        }
    }
}
