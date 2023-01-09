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
    public partial class Frm2a11Meses : Form
    {
        public Frm2a11Meses()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double receitaBruta;

            if (String.IsNullOrWhiteSpace(txtTempoDeAtividade.Text) || String.IsNullOrWhiteSpace(txtFaturamentoMes.Text) || String.IsNullOrWhiteSpace(txtReceitaAcumulada.Text))
            {
                MessageBox.Show("Os campos não podem ser vazios!", "Erro");
                return;
            }
            if (int.Parse(txtTempoDeAtividade.Text) <=1 || int.Parse(txtTempoDeAtividade.Text) >= 12)
            {
                MessageBox.Show("Preencha corretamente os campos!");
                txtTempoDeAtividade.Focus();
            }
            else
            {
                receitaBruta = double.Parse(txtReceitaAcumulada.Text) / int.Parse(txtTempoDeAtividade.Text)*12;
				try
				{
					AnexosSN anexo = AnexosSimpleFactory.CriaAnexo(txtNumeroDoAnexo.Text, Convert.ToDouble(receitaBruta),Convert.ToDouble(txtFaturamentoMes.Text));
					anexo.calculoAnexo(Convert.ToDouble(receitaBruta), Convert.ToDouble(txtFaturamentoMes.Text));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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
