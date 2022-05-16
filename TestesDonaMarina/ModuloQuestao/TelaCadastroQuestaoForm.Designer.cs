namespace TestesDonaMarina.ModuloQuestao
{
    partial class TelaCadastroQuestaoForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlternativa = new System.Windows.Forms.TextBox();
            this.btnCancelarDisciplina = new System.Windows.Forms.Button();
            this.btnGravarDisciplina = new System.Windows.Forms.Button();
            this.listAlternativas = new System.Windows.Forms.ListBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(79, 6);
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(414, 23);
            this.txtEnunciado.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 246);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.listAlternativas);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.btnAdicionar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtAlternativa);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alternativas";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Alternativa Correta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(392, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descrição:";
            // 
            // txtAlternativa
            // 
            this.txtAlternativa.Location = new System.Drawing.Point(66, 6);
            this.txtAlternativa.Name = "txtAlternativa";
            this.txtAlternativa.Size = new System.Drawing.Size(320, 23);
            this.txtAlternativa.TabIndex = 13;
            // 
            // btnCancelarDisciplina
            // 
            this.btnCancelarDisciplina.Location = new System.Drawing.Point(419, 353);
            this.btnCancelarDisciplina.Name = "btnCancelarDisciplina";
            this.btnCancelarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDisciplina.TabIndex = 14;
            this.btnCancelarDisciplina.Text = "Cancelar";
            this.btnCancelarDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnGravarDisciplina
            // 
            this.btnGravarDisciplina.Location = new System.Drawing.Point(338, 353);
            this.btnGravarDisciplina.Name = "btnGravarDisciplina";
            this.btnGravarDisciplina.Size = new System.Drawing.Size(75, 23);
            this.btnGravarDisciplina.TabIndex = 13;
            this.btnGravarDisciplina.Text = "Gravar";
            this.btnGravarDisciplina.UseVisualStyleBackColor = true;
            this.btnGravarDisciplina.Click += new System.EventHandler(this.btnGravarDisciplina_Click);
            // 
            // listAlternativas
            // 
            this.listAlternativas.FormattingEnabled = true;
            this.listAlternativas.ItemHeight = 15;
            this.listAlternativas.Location = new System.Drawing.Point(6, 54);
            this.listAlternativas.Name = "listAlternativas";
            this.listAlternativas.Size = new System.Drawing.Size(457, 154);
            this.listAlternativas.TabIndex = 16;
            // 
            // cmbMateria
            // 
            this.cmbMateria.BackColor = System.Drawing.Color.White;
            this.cmbMateria.DisplayMember = "Nome";
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(79, 64);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(94, 23);
            this.cmbMateria.TabIndex = 16;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(79, 35);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(94, 23);
            this.cmbDisciplina.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Matéria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Disciplina:";
            // 
            // TelaCadastroQuestaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.btnCancelarDisciplina);
            this.Controls.Add(this.btnGravarDisciplina);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.label4);
            this.Name = "TelaCadastroQuestaoForm";
            this.Text = "Cadastro de Questões";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlternativa;
        private System.Windows.Forms.Button btnCancelarDisciplina;
        private System.Windows.Forms.Button btnGravarDisciplina;
        private System.Windows.Forms.ListBox listAlternativas;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}