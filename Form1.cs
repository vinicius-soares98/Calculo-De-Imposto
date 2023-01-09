namespace Impostos_Brasil
{
    public partial class Impostos : Form
    {
        public Impostos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculoImpostoME calculoImpostoME = new CalculoImpostoME();
            calculoImpostoME.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}