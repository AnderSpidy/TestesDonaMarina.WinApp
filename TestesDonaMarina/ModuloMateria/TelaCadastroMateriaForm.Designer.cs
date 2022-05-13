namespace TestesDonaMarina.ModuloMateria
{
    partial class TelaCadastroMateriaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPrimeira = new System.Windows.Forms.RadioButton();
            this.rdbSegunda = new System.Windows.Forms.RadioButton();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnGravarDisciplina = new System.Windows.Forms.Button();
            this.txtNomeMateria = new System.Windows.Forms.TextBox();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Matéria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Série:";
            // 
            // rdbPrimeira
            // 
            this.rdbPrimeira.AutoSize = true;
            this.rdbPrimeira.Location = new System.Drawing.Point(115, 87);
            this.rdbPrimeira.Name = "rdbPrimeira";
            this.rdbPrimeira.Size = new System.Drawing.Size(64, 19);
            this.rdbPrimeira.TabIndex = 4;
            this.rdbPrimeira.TabStop = true;
            this.rdbPrimeira.Text = "1º Série";
            this.rdbPrimeira.UseVisualStyleBackColor = true;
            this.rdbPrimeira.CheckedChanged += new System.EventHandler(this.rdbPrimeira_CheckedChanged);
            // 
            // rdbSegunda
            // 
            this.rdbSegunda.AutoSize = true;
            this.rdbSegunda.Location = new System.Drawing.Point(185, 88);
            this.rdbSegunda.Name = "rdbSegunda";
            this.rdbSegunda.Size = new System.Drawing.Size(64, 19);
            this.rdbSegunda.TabIndex = 5;
            this.rdbSegunda.TabStop = true;
            this.rdbSegunda.Text = "2º Série";
            this.rdbSegunda.UseVisualStyleBackColor = true;
            this.rdbSegunda.CheckedChanged += new System.EventHandler(this.rdbSegunda_CheckedChanged);
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(189, 113);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDisciplina.TabIndex = 7;
            this.btnCancelarDisciplina.Text = "Cancelar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnGravarDisciplina
            // 
            this.btnGravarDisciplina.Location = new System.Drawing.Point(108, 113);
            this.btnGravarDisciplina.Name = "btnGravarDisciplina";
            this.btnGravarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnGravarDisciplina.TabIndex = 6;
            this.btnGravarDisciplina.Text = "Gravar";
            this.btnGravarDisciplina.UseVisualStyleBackColor = true;
            this.btnGravarDisciplina.Click += new System.EventHandler(this.btnGravarDisciplina_Click);
            // 
            // txtNomeMateria
            // 
            this.txtNomeMateria.Location = new System.Drawing.Point(115, 31);
            this.txtNomeMateria.Name = "txtNomeMateria";
            this.txtNomeMateria.Size = new System.Drawing.Size(149, 23);
            this.txtNomeMateria.TabIndex = 8;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.BackColor = System.Drawing.Color.White;
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(115, 58);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(94, 23);
            this.cmbDisciplina.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nº:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(115, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 23);
            this.textBox2.TabIndex = 11;
            // 
            // TelaCadastroMateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 144);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.txtNomeMateria);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnGravarDisciplina);
            this.Controls.Add(this.rdbSegunda);
            this.Controls.Add(this.rdbPrimeira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroMateriaForm";
            this.Text = "Cadastro de Matérias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbPrimeira;
        private System.Windows.Forms.RadioButton rdbSegunda;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnGravarDisciplina;
        private System.Windows.Forms.TextBox txtNomeMateria;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}