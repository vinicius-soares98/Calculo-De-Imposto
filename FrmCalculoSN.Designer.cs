namespace Impostos_Brasil
{
    partial class FrmCalculoSN
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn1Mes = new System.Windows.Forms.Button();
            this.btn2a11Meses = new System.Windows.Forms.Button();
            this.btn12MesesOuMais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual o tempo de Atividade da sua empresa?";
            // 
            // btn1Mes
            // 
            this.btn1Mes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Mes.Location = new System.Drawing.Point(97, 91);
            this.btn1Mes.Name = "btn1Mes";
            this.btn1Mes.Size = new System.Drawing.Size(213, 31);
            this.btn1Mes.TabIndex = 1;
            this.btn1Mes.Text = "1 Mês";
            this.btn1Mes.UseVisualStyleBackColor = true;
            this.btn1Mes.Click += new System.EventHandler(this.btn1Mes_Click);
            // 
            // btn2a11Meses
            // 
            this.btn2a11Meses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2a11Meses.Location = new System.Drawing.Point(97, 141);
            this.btn2a11Meses.Name = "btn2a11Meses";
            this.btn2a11Meses.Size = new System.Drawing.Size(213, 31);
            this.btn2a11Meses.TabIndex = 2;
            this.btn2a11Meses.Text = "2 a 11 Meses";
            this.btn2a11Meses.UseVisualStyleBackColor = true;
            this.btn2a11Meses.Click += new System.EventHandler(this.btn2a11Meses_Click);
            // 
            // btn12MesesOuMais
            // 
            this.btn12MesesOuMais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn12MesesOuMais.Location = new System.Drawing.Point(97, 191);
            this.btn12MesesOuMais.Name = "btn12MesesOuMais";
            this.btn12MesesOuMais.Size = new System.Drawing.Size(213, 31);
            this.btn12MesesOuMais.TabIndex = 3;
            this.btn12MesesOuMais.Text = "12 Meses (1 Ano) ou mais";
            this.btn12MesesOuMais.UseVisualStyleBackColor = true;
            this.btn12MesesOuMais.Click += new System.EventHandler(this.btn12MesesOuMais_Click);
            // 
            // FrmCalculoSN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 284);
            this.Controls.Add(this.btn12MesesOuMais);
            this.Controls.Add(this.btn2a11Meses);
            this.Controls.Add(this.btn1Mes);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculoSN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculoSN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn1Mes;
        private Button btn2a11Meses;
        private Button btn12MesesOuMais;
    }
}