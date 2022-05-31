namespace TestesDonaMarina.ModuloDisciplina
{
    partial class TelaCadastroDisciplinaForm
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
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.btnGravarDisciplina = new System.Windows.Forms.Button();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Disciplina:";
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(139, 35);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(149, 23);
            this.txtNomeDisciplina.TabIndex = 2;
            // 
            // btnGravarDisciplina
            // 
            this.btnGravarDisciplina.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravarDisciplina.Location = new System.Drawing.Point(139, 64);
            this.btnGravarDisciplina.Name = "btnGravarDisciplina";
            this.btnGravarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnGravarDisciplina.TabIndex = 4;
            this.btnGravarDisciplina.Text = "Gravar";
            this.btnGravarDisciplina.UseVisualStyleBackColor = true;
            this.btnGravarDisciplina.Click += new System.EventHandler(this.btnGravarDisciplina_Click);
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(220, 64);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDisciplina.TabIndex = 5;
            this.btnCancelarDisciplina.Text = "Cancelar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nº:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(139, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 23);
            this.txtNumero.TabIndex = 12;
            // 
            // TelaCadastroDisciplinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 92);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnGravarDisciplina);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroDisciplinaForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Disciplina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroDisciplinaForm_FormClosing);
            this.Load += new System.EventHandler(this.TelaCadastroDisciplinaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.Button btnGravarDisciplina;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
    }
}