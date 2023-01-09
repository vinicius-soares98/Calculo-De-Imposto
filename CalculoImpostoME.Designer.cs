namespace Impostos_Brasil
{
    partial class CalculoImpostoME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculoImpostoME));
            this.lbImpostosSN = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalcularImposto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbImpostosSN
            // 
            this.lbImpostosSN.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbImpostosSN.BackColor = System.Drawing.SystemColors.Control;
            this.lbImpostosSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbImpostosSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbImpostosSN.FormattingEnabled = true;
            this.lbImpostosSN.ItemHeight = 21;
            this.lbImpostosSN.Items.AddRange(new object[] {
            "- COFINS: Contribuição para o Financiamento da Seguridade Social  ",
            "- CSLL: Contribuição Social sobre Lucro Líquido ",
            "- CPP: Contribuição Previdenciária Patronal ",
            "- IRPJ: Imposto de Renda Pessoa Jurídica ",
            "- PIS: Programa de integração Social ",
            "- ISS: Imposto sobre Serviços "});
            this.lbImpostosSN.Location = new System.Drawing.Point(75, 85);
            this.lbImpostosSN.Name = "lbImpostosSN";
            this.lbImpostosSN.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbImpostosSN.Size = new System.Drawing.Size(478, 126);
            this.lbImpostosSN.TabIndex = 0;
            this.lbImpostosSN.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Os principais impostos que uma microempresa(ME) paga são:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(75, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 90);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnCalcularImposto
            // 
            this.btnCalcularImposto.Location = new System.Drawing.Point(239, 359);
            this.btnCalcularImposto.Name = "btnCalcularImposto";
            this.btnCalcularImposto.Size = new System.Drawing.Size(139, 48);
            this.btnCalcularImposto.TabIndex = 4;
            this.btnCalcularImposto.Text = "Calcular Imposto";
            this.btnCalcularImposto.UseVisualStyleBackColor = true;
            this.btnCalcularImposto.Click += new System.EventHandler(this.btnCalcularImposto_Click);
            // 
            // CalculoImpostoME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 448);
            this.Controls.Add(this.btnCalcularImposto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbImpostosSN);
            this.MaximizeBox = false;
            this.Name = "CalculoImpostoME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Imposto ME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbImpostosSN;
        private Label label1;
        private TextBox textBox1;
        private Button btnCalcularImposto;
    }
}