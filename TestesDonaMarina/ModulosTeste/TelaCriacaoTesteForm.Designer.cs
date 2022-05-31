namespace TestesDonaMarina.ModulosTeste
{
    partial class TelaCriacaoTesteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTituloTeste = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.checkBoxProvaRecuperacao = new System.Windows.Forms.CheckBox();
            this.listBoxQuestoes = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.numQuestoes = new System.Windows.Forms.NumericUpDown();
            this.btnSortearQuestoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestoes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nº:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matéria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade de Questões:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data:";
            // 
            // txtTituloTeste
            // 
            this.txtTituloTeste.Location = new System.Drawing.Point(75, 43);
            this.txtTituloTeste.Name = "txtTituloTeste";
            this.txtTituloTeste.Size = new System.Drawing.Size(126, 23);
            this.txtTituloTeste.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(75, 72);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(126, 23);
            this.cmbDisciplina.TabIndex = 13;
            this.cmbDisciplina.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplina_SelectedIndexChanged);

            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(75, 101);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(126, 23);
            this.cmbMateria.TabIndex = 14;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateria_SelectedIndexChanged);

            // 
            // checkBoxProvaRecuperacao
            // 
            this.checkBoxProvaRecuperacao.AutoSize = true;
            this.checkBoxProvaRecuperacao.Location = new System.Drawing.Point(222, 80);
            this.checkBoxProvaRecuperacao.Name = "checkBoxProvaRecuperacao";
            this.checkBoxProvaRecuperacao.Size = new System.Drawing.Size(148, 19);
            this.checkBoxProvaRecuperacao.TabIndex = 16;
            this.checkBoxProvaRecuperacao.Text = "Prova de Recuperação?";
            this.checkBoxProvaRecuperacao.UseVisualStyleBackColor = true;
            this.checkBoxProvaRecuperacao.CheckedChanged += new System.EventHandler(this.checkBoxProvaRecuperacao_CheckedChanged);

            // 
            // listBoxQuestoes
            // 
            this.listBoxQuestoes.FormattingEnabled = true;
            this.listBoxQuestoes.ItemHeight = 15;
            this.listBoxQuestoes.Location = new System.Drawing.Point(8, 163);
            this.listBoxQuestoes.Name = "listBoxQuestoes";
            this.listBoxQuestoes.Size = new System.Drawing.Size(352, 154);
            this.listBoxQuestoes.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(285, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(204, 323);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);

            // 
            // numQuestoes
            // 
            this.numQuestoes.Enabled = false;
            this.numQuestoes.Location = new System.Drawing.Point(150, 133);
            this.numQuestoes.Name = "numQuestoes";
            this.numQuestoes.Size = new System.Drawing.Size(51, 23);
            this.numQuestoes.TabIndex = 20;
            this.numQuestoes.ValueChanged += new System.EventHandler(this.numQuestoes_ValueChanged);

            // 
            // btnSortearQuestoes
            // 
            this.btnSortearQuestoes.Enabled = false;
            this.btnSortearQuestoes.Location = new System.Drawing.Point(251, 135);
            this.btnSortearQuestoes.Name = "btnSortearQuestoes";
            this.btnSortearQuestoes.Size = new System.Drawing.Size(109, 23);
            this.btnSortearQuestoes.TabIndex = 21;
            this.btnSortearQuestoes.Text = "Sortear Questões";
            this.btnSortearQuestoes.UseVisualStyleBackColor = true;
            this.btnSortearQuestoes.Click += new System.EventHandler(this.btnSortearQuestoes_Click);

            // 
            // TelaCriacaoTesteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 351);
            this.Controls.Add(this.btnSortearQuestoes);
            this.Controls.Add(this.numQuestoes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.listBoxQuestoes);
            this.Controls.Add(this.checkBoxProvaRecuperacao);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTituloTeste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TelaCriacaoTesteForm";
            this.Text = "Criação de Teste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroTeste_FormClosing);
            this.Load += new System.EventHandler(this.TelaCadastroTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuestoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTituloTeste;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.CheckBox checkBoxProvaRecuperacao;
        private System.Windows.Forms.ListBox listBoxQuestoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.NumericUpDown numQuestoes;
        private System.Windows.Forms.Button btnSortearQuestoes;
    }
}