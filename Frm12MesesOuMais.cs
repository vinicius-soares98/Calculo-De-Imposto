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
    public partial class Frm12MesesOuMais : Form
    {
        public Frm12MesesOuMais()
        {
            InitializeComponent();
        }

        private void txtTempoDeAtividade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtReceitaBruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceitaBruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtTempoDeAtividade.Text) || String.IsNullOrWhiteSpace(txtReceitaBruta.Text) || String.IsNullOrWhiteSpace(txtFaturamentoMes.Text))
            {
                MessageBox.Show("Os campos não podem ser vazios!","Erro");
                return;
            }          
            if (int.Parse(txtTempoDeAtividade.Text) <12)
            {
                MessageBox.Show("Preencha corretamente os campos!");
                txtTempoDeAtividade.Focus();
            }
            else
            {
                try
                {
                    AnexosSN anexo = AnexosSimpleFactory.CriaAnexo(txtNumeroDoAnexo.Text, Convert.ToDouble(txtReceitaBruta.Text), Convert.ToDouble(txtFaturamentoMes.Text));
                    anexo.calculoAnexo(Convert.ToDouble(txtReceitaBruta.Text), Convert.ToDouble(txtFaturamentoMes.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                                                         
            }
        }

        private void txtFaturamentoMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroDoAnexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1'|| e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCalculoSN frmCalculoSN = new FrmCalculoSN();
            frmCalculoSN.Show();
        }
    }
}
