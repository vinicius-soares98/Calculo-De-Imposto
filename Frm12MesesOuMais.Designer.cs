namespace Impostos_Brasil
{
    partial class Frm12MesesOuMais
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
            this.lblTempoDeAtividade = new System.Windows.Forms.Label();
            this.txtTempoDeAtividade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceitaBruta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFaturamentoMes = new System.Windows.Forms.Label();
            this.txtFaturamentoMes = new System.Windows.Forms.TextBox();
            this.lblDigiteAnexo = new System.Windows.Forms.Label();
            this.txtNumeroDoAnexo = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite as informações solicitadas abaixo CORRETAMENTE!";
            // 
            // lblTempoDeAtividade
            // 
            this.lblTempoDeAtividade.AutoSize = true;
            this.lblTempoDeAtividade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempoDeAtividade.Location = new System.Drawing.Point(57, 89);
            this.lblTempoDeAtividade.Name = "lblTempoDeAtividade";
            this.lblTempoDeAtividade.Size = new System.Drawing.Size(396, 21);
            this.lblTempoDeAtividade.TabIndex = 1;
            this.lblTempoDeAtividade.Text = "Tempo de atividade da ampresa (Em número de meses):";
            // 
            // txtTempoDeAtividade
            // 
            this.txtTempoDeAtividade.Location = new System.Drawing.Point(66, 113);
            this.txtTempoDeAtividade.Name = "txtTempoDeAtividade";
            this.txtTempoDeAtividade.Size = new System.Drawing.Size(102, 23);
            this.txtTempoDeAtividade.TabIndex = 2;
            this.txtTempoDeAtividade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempoDeAtividade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempoDeAtividade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Receita Bruta dos últimos 12 meses:";
            // 
            // txtReceitaBruta
            // 
            this.txtReceitaBruta.Location = new System.Drawing.Point(66, 193);
            this.txtReceitaBruta.Name = "txtReceitaBruta";
            this.txtReceitaBruta.Size = new System.Drawing.Size(102, 23);
            this.txtReceitaBruta.TabIndex = 4;
            this.txtReceitaBruta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceitaBruta.TextChanged += new System.EventHandler(this.txtReceitaBruta_TextChanged);
            this.txtReceitaBruta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceitaBruta_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(321, 445);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 45);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFaturamentoMes
            // 
            this.lblFaturamentoMes.AutoSize = true;
            this.lblFaturamentoMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFaturamentoMes.Location = new System.Drawing.Point(57, 247);
            this.lblFaturamentoMes.Name = "lblFaturamentoMes";
            this.lblFaturamentoMes.Size = new System.Drawing.Size(156, 21);
            this.lblFaturamentoMes.TabIndex = 7;
            this.lblFaturamentoMes.Text = "Faturamento do mês:";
            // 
            // txtFaturamentoMes
            // 
            this.txtFaturamentoMes.Location = new System.Drawing.Point(66, 271);
            this.txtFaturamentoMes.Name = "txtFaturamentoMes";
            this.txtFaturamentoMes.Size = new System.Drawing.Size(102, 23);
            this.txtFaturamentoMes.TabIndex = 8;
            this.txtFaturamentoMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFaturamentoMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFaturamentoMes_KeyPress);
            // 
            // lblDigiteAnexo
            // 
            this.lblDigiteAnexo.AutoSize = true;
            this.lblDigiteAnexo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigiteAnexo.Location = new System.Drawing.Point(135, 331);
            this.lblDigiteAnexo.Name = "lblDigiteAnexo";
            this.lblDigiteAnexo.Size = new System.Drawing.Size(558, 21);
            this.lblDigiteAnexo.TabIndex = 9;
            this.lblDigiteAnexo.Text = "Digite abaixo o número do anexo no qual o CNAE da sua empresa se enquadra ";
            // 
            // txtNumeroDoAnexo
            // 
            this.txtNumeroDoAnexo.Location = new System.Drawing.Point(353, 365);
            this.txtNumeroDoAnexo.Name = "txtNumeroDoAnexo";
            this.txtNumeroDoAnexo.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroDoAnexo.TabIndex = 10;
            this.txtNumeroDoAnexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroDoAnexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoAnexo_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(713, 467);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Frm12MesesOuMais
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
            this.Controls.Add(this.txtReceitaBruta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempoDeAtividade);
            this.Controls.Add(this.lblTempoDeAtividade);
            this.Controls.Add(this.label1);
            this.Name = "Frm12MesesOuMais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm12MesesOuMais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblTempoDeAtividade;
        private TextBox txtTempoDeAtividade;
        private Label label2;
        private TextBox txtReceitaBruta;
        private Button btnCalcular;
        private Label lblFaturamentoMes;
        private TextBox txtFaturamentoMes;
        private Label lblDigiteAnexo;
        private TextBox txtNumeroDoAnexo;
        private Button btnVoltar;
    }
}