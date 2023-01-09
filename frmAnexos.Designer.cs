namespace Impostos_Brasil
{
    partial class FrmAnexos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnexo1 = new System.Windows.Forms.Button();
            this.btnAnexo2 = new System.Windows.Forms.Button();
            this.btnAnexo3 = new System.Windows.Forms.Button();
            this.btnAnexo4 = new System.Windows.Forms.Button();
            this.btnAnexo5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(141, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Selecione o anexo no qual o CNAE de sua empresa se enquadra";
            // 
            // btnAnexo1
            // 
            this.btnAnexo1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnexo1.Location = new System.Drawing.Point(86, 143);
            this.btnAnexo1.Name = "btnAnexo1";
            this.btnAnexo1.Size = new System.Drawing.Size(115, 34);
            this.btnAnexo1.TabIndex = 1;
            this.btnAnexo1.Text = "Anexo 1";
            this.btnAnexo1.UseVisualStyleBackColor = true;
            this.btnAnexo1.Click += new System.EventHandler(this.btnAnexo1_Click);
            // 
            // btnAnexo2
            // 
            this.btnAnexo2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnexo2.Location = new System.Drawing.Point(207, 143);
            this.btnAnexo2.Name = "btnAnexo2";
            this.btnAnexo2.Size = new System.Drawing.Size(115, 34);
            this.btnAnexo2.TabIndex = 2;
            this.btnAnexo2.Text = "Anexo 2";
            this.btnAnexo2.UseVisualStyleBackColor = true;
            this.btnAnexo2.Click += new System.EventHandler(this.btnAnexo2_Click);
            // 
            // btnAnexo3
            // 
            this.btnAnexo3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnexo3.Location = new System.Drawing.Point(328, 143);
            this.btnAnexo3.Name = "btnAnexo3";
            this.btnAnexo3.Size = new System.Drawing.Size(115, 34);
            this.btnAnexo3.TabIndex = 3;
            this.btnAnexo3.Text = "Anexo 3";
            this.btnAnexo3.UseVisualStyleBackColor = true;
            // 
            // btnAnexo4
            // 
            this.btnAnexo4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnexo4.Location = new System.Drawing.Point(449, 143);
            this.btnAnexo4.Name = "btnAnexo4";
            this.btnAnexo4.Size = new System.Drawing.Size(115, 34);
            this.btnAnexo4.TabIndex = 4;
            this.btnAnexo4.Text = "Anexo 4";
            this.btnAnexo4.UseVisualStyleBackColor = true;
            // 
            // btnAnexo5
            // 
            this.btnAnexo5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnexo5.Location = new System.Drawing.Point(570, 143);
            this.btnAnexo5.Name = "btnAnexo5";
            this.btnAnexo5.Size = new System.Drawing.Size(115, 34);
            this.btnAnexo5.TabIndex = 5;
            this.btnAnexo5.Text = "Anexo 5";
            this.btnAnexo5.UseVisualStyleBackColor = true;
            // 
            // FrmAnexos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.btnAnexo5);
            this.Controls.Add(this.btnAnexo4);
            this.Controls.Add(this.btnAnexo3);
            this.Controls.Add(this.btnAnexo2);
            this.Controls.Add(this.btnAnexo1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmAnexos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnexos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnAnexo1;
        private Button btnAnexo2;
        private Button btnAnexo3;
        private Button btnAnexo4;
        private Button btnAnexo5;
    }
}