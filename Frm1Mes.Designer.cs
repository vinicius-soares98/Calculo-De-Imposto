namespace Impostos_Brasil
{
    partial class Frm1Mes
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
            this.txtNumeroDoAnexo = new System.Windows.Forms.TextBox();
            this.lblDigiteAnexo = new System.Windows.Forms.Label();
            this.txtFaturamentoMes = new System.Windows.Forms.TextBox();
            this.lblFaturamentoMes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTempoDeAtividade = new System.Windows.Forms.TextBox();
            this.lblTempoDeAtividade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroDoAnexo
            // 
            this.txtNumeroDoAnexo.Location = new System.Drawing.Point(353, 343);
            this.txtNumeroDoAnexo.Name = "txtNumeroDoAnexo";
            this.txtNumeroDoAnexo.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroDoAnexo.TabIndex = 20;
            this.txtNumeroDoAnexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDigiteAnexo
            // 
            this.lblDigiteAnexo.AutoSize = true;
            this.lblDigiteAnexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigiteAnexo.Location = new System.Drawing.Point(135, 309);
            this.lblDigiteAnexo.Name = "lblDigiteAnexo";
            this.lblDigiteAnexo.Size = new System.Drawing.Size(558, 21);
            this.lblDigiteAnexo.TabIndex = 19;
            this.lblDigiteAnexo.Text = "Digite abaixo o número do anexo no qual o CNAE da sua empresa se enquadra ";
            // 
            // txtFaturamentoMes
            // 
            this.txtFaturamentoMes.Location = new System.Drawing.Point(66, 249);
            this.txtFaturamentoMes.Name = "txtFaturamentoMes";
            this.txtFaturamentoMes.Size = new System.Drawing.Size(102, 23);
            this.txtFaturamentoMes.TabIndex = 18;
            this.txtFaturamentoMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFaturamentoMes
            // 
            this.lblFaturamentoMes.AutoSize = true;
            this.lblFaturamentoMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaturamentoMes.Location = new System.Drawing.Point(57, 225);
            this.lblFaturamentoMes.Name = "lblFaturamentoMes";
            this.lblFaturamentoMes.Size = new System.Drawing.Size(156, 21);
            this.lblFaturamentoMes.TabIndex = 17;
            this.lblFaturamentoMes.Text = "Faturamento do mês:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(322, 445);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 45);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTempoDeAtividade
            // 
            this.txtTempoDeAtividade.Location = new System.Drawing.Point(66, 151);
            this.txtTempoDeAtividade.Name = "txtTempoDeAtividade";
            this.txtTempoDeAtividade.Size = new System.Drawing.Size(102, 23);
            this.txtTempoDeAtividade.TabIndex = 13;
            this.txtTempoDeAtividade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTempoDeAtividade
            // 
            this.lblTempoDeAtividade.AutoSize = true;
            this.lblTempoDeAtividade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempoDeAtividade.Location = new System.Drawing.Point(57, 127);
            this.lblTempoDeAtividade.Name = "lblTempoDeAtividade";
            this.lblTempoDeAtividade.Size = new System.Drawing.Size(396, 21);
            this.lblTempoDeAtividade.TabIndex = 12;
            this.lblTempoDeAtividade.Text = "Tempo de atividade da ampresa (Em número de meses):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite as informações solicitadas abaixo CORRETAMENTE!";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(713, 467);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm1Mes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtNumeroDoAnexo);
            this.Controls.Add(this.lblDigiteAnexo);
            this.Controls.Add(this.txtFaturamentoMes);
            this.Controls.Add(this.lblFaturamentoMes);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTempoDeAtividade);
            this.Controls.Add(this.lblTempoDeAtividade);
            this.Controls.Add(this.label1);
            this.Name = "Frm1Mes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm1Mes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumeroDoAnexo;
        private Label lblDigiteAnexo;
        private TextBox txtFaturamentoMes;
        private Label lblFaturamentoMes;
        private Button btnCalcular;
        private TextBox txtTempoDeAtividade;
        private Label lblTempoDeAtividade;
        private Label label1;
        private Button btnVoltar;
    }
}