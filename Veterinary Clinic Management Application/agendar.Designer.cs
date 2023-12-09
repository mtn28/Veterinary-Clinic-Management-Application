namespace projeto_clinicaveterinária
{
    partial class agendar
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
            this.L_Agendar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_observações = new System.Windows.Forms.Label();
            this.textBoxobservaçoes = new System.Windows.Forms.TextBox();
            this.RB_Cirurgia = new System.Windows.Forms.RadioButton();
            this.RB_consulta = new System.Windows.Forms.RadioButton();
            this.RB_Vacinaçao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxVets = new System.Windows.Forms.ComboBox();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.comboBox_Npaciente = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxdata = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNomepaciente = new System.Windows.Forms.TextBox();
            this.L_NP = new System.Windows.Forms.Label();
            this.L_nomeanimal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Veterinario = new System.Windows.Forms.Label();
            this.B_REGISTAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Agendar
            // 
            this.L_Agendar.AutoSize = true;
            this.L_Agendar.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Agendar.Location = new System.Drawing.Point(21, 22);
            this.L_Agendar.Name = "L_Agendar";
            this.L_Agendar.Size = new System.Drawing.Size(157, 53);
            this.L_Agendar.TabIndex = 0;
            this.L_Agendar.Text = "Agendar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_observações);
            this.groupBox1.Controls.Add(this.textBoxobservaçoes);
            this.groupBox1.Controls.Add(this.RB_Cirurgia);
            this.groupBox1.Controls.Add(this.RB_consulta);
            this.groupBox1.Controls.Add(this.RB_Vacinaçao);
            this.groupBox1.Location = new System.Drawing.Point(31, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // L_observações
            // 
            this.L_observações.AutoSize = true;
            this.L_observações.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_observações.Location = new System.Drawing.Point(27, 64);
            this.L_observações.Name = "L_observações";
            this.L_observações.Size = new System.Drawing.Size(125, 20);
            this.L_observações.TabIndex = 6;
            this.L_observações.Text = "Observações:";
            // 
            // textBoxobservaçoes
            // 
            this.textBoxobservaçoes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxobservaçoes.Location = new System.Drawing.Point(31, 97);
            this.textBoxobservaçoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxobservaçoes.Name = "textBoxobservaçoes";
            this.textBoxobservaçoes.Size = new System.Drawing.Size(735, 30);
            this.textBoxobservaçoes.TabIndex = 5;
            // 
            // RB_Cirurgia
            // 
            this.RB_Cirurgia.AutoSize = true;
            this.RB_Cirurgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Cirurgia.Location = new System.Drawing.Point(341, 15);
            this.RB_Cirurgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_Cirurgia.Name = "RB_Cirurgia";
            this.RB_Cirurgia.Size = new System.Drawing.Size(97, 24);
            this.RB_Cirurgia.TabIndex = 3;
            this.RB_Cirurgia.TabStop = true;
            this.RB_Cirurgia.Text = "Cirurgia";
            this.RB_Cirurgia.UseVisualStyleBackColor = true;
            this.RB_Cirurgia.CheckedChanged += new System.EventHandler(this.RB_Cirurgia_CheckedChanged);
            // 
            // RB_consulta
            // 
            this.RB_consulta.AutoSize = true;
            this.RB_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_consulta.Location = new System.Drawing.Point(31, 15);
            this.RB_consulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_consulta.Name = "RB_consulta";
            this.RB_consulta.Size = new System.Drawing.Size(104, 24);
            this.RB_consulta.TabIndex = 4;
            this.RB_consulta.TabStop = true;
            this.RB_consulta.Text = "Consulta";
            this.RB_consulta.UseVisualStyleBackColor = true;
            // 
            // RB_Vacinaçao
            // 
            this.RB_Vacinaçao.AutoSize = true;
            this.RB_Vacinaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Vacinaçao.Location = new System.Drawing.Point(184, 15);
            this.RB_Vacinaçao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RB_Vacinaçao.Name = "RB_Vacinaçao";
            this.RB_Vacinaçao.Size = new System.Drawing.Size(117, 24);
            this.RB_Vacinaçao.TabIndex = 3;
            this.RB_Vacinaçao.TabStop = true;
            this.RB_Vacinaçao.Text = "Vacinação";
            this.RB_Vacinaçao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxVets);
            this.groupBox2.Controls.Add(this.button_pesquisar);
            this.groupBox2.Controls.Add(this.comboBox_Npaciente);
            this.groupBox2.Controls.Add(this.maskedTextBoxdata);
            this.groupBox2.Controls.Add(this.textBoxNomepaciente);
            this.groupBox2.Controls.Add(this.L_NP);
            this.groupBox2.Controls.Add(this.L_nomeanimal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.L_Veterinario);
            this.groupBox2.Location = new System.Drawing.Point(31, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(776, 185);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxVets
            // 
            this.comboBoxVets.FormattingEnabled = true;
            this.comboBoxVets.Location = new System.Drawing.Point(193, 130);
            this.comboBoxVets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxVets.Name = "comboBoxVets";
            this.comboBoxVets.Size = new System.Drawing.Size(465, 24);
            this.comboBoxVets.TabIndex = 14;
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pesquisar.Location = new System.Drawing.Point(441, 19);
            this.button_pesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(164, 43);
            this.button_pesquisar.TabIndex = 5;
            this.button_pesquisar.Text = "SELECIONAR";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // comboBox_Npaciente
            // 
            this.comboBox_Npaciente.FormattingEnabled = true;
            this.comboBox_Npaciente.Location = new System.Drawing.Point(199, 28);
            this.comboBox_Npaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Npaciente.Name = "comboBox_Npaciente";
            this.comboBox_Npaciente.Size = new System.Drawing.Size(215, 24);
            this.comboBox_Npaciente.TabIndex = 13;
            // 
            // maskedTextBoxdata
            // 
            this.maskedTextBoxdata.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxdata.Location = new System.Drawing.Point(441, 78);
            this.maskedTextBoxdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxdata.Mask = "00/00/0000";
            this.maskedTextBoxdata.Name = "maskedTextBoxdata";
            this.maskedTextBoxdata.Size = new System.Drawing.Size(100, 30);
            this.maskedTextBoxdata.TabIndex = 10;
            this.maskedTextBoxdata.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxNomepaciente
            // 
            this.textBoxNomepaciente.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomepaciente.Location = new System.Drawing.Point(193, 78);
            this.textBoxNomepaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomepaciente.Name = "textBoxNomepaciente";
            this.textBoxNomepaciente.Size = new System.Drawing.Size(167, 30);
            this.textBoxNomepaciente.TabIndex = 9;
            this.textBoxNomepaciente.TextChanged += new System.EventHandler(this.textBoxN_paciente_TextChanged);
            // 
            // L_NP
            // 
            this.L_NP.AutoSize = true;
            this.L_NP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NP.Location = new System.Drawing.Point(23, 28);
            this.L_NP.Name = "L_NP";
            this.L_NP.Size = new System.Drawing.Size(145, 20);
            this.L_NP.TabIndex = 8;
            this.L_NP.Text = "Nº. de Paciente:";
            // 
            // L_nomeanimal
            // 
            this.L_nomeanimal.AutoSize = true;
            this.L_nomeanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nomeanimal.Location = new System.Drawing.Point(23, 78);
            this.L_nomeanimal.Name = "L_nomeanimal";
            this.L_nomeanimal.Size = new System.Drawing.Size(150, 20);
            this.L_nomeanimal.TabIndex = 7;
            this.L_nomeanimal.Text = "Nome do animal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // L_Veterinario
            // 
            this.L_Veterinario.AutoSize = true;
            this.L_Veterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Veterinario.Location = new System.Drawing.Point(27, 130);
            this.L_Veterinario.Name = "L_Veterinario";
            this.L_Veterinario.Size = new System.Drawing.Size(107, 20);
            this.L_Veterinario.TabIndex = 6;
            this.L_Veterinario.Text = "Veterinário:";
            // 
            // B_REGISTAR
            // 
            this.B_REGISTAR.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_REGISTAR.Location = new System.Drawing.Point(685, 428);
            this.B_REGISTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_REGISTAR.Name = "B_REGISTAR";
            this.B_REGISTAR.Size = new System.Drawing.Size(121, 43);
            this.B_REGISTAR.TabIndex = 4;
            this.B_REGISTAR.Text = "REGISTAR";
            this.B_REGISTAR.UseVisualStyleBackColor = true;
            this.B_REGISTAR.Click += new System.EventHandler(this.B_REGISTAR_Click);
            // 
            // agendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 502);
            this.Controls.Add(this.B_REGISTAR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_Agendar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "agendar";
            this.Text = "agendar";
            this.Load += new System.EventHandler(this.agendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Agendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Cirurgia;
        private System.Windows.Forms.RadioButton RB_Vacinaçao;
        private System.Windows.Forms.RadioButton RB_consulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_nomeanimal;
        private System.Windows.Forms.Label L_Veterinario;
        private System.Windows.Forms.Label L_NP;
        private System.Windows.Forms.TextBox textBoxNomepaciente;
        private System.Windows.Forms.Label L_observações;
        private System.Windows.Forms.TextBox textBoxobservaçoes;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxdata;
        private System.Windows.Forms.Button B_REGISTAR;
        private System.Windows.Forms.ComboBox comboBox_Npaciente;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.ComboBox comboBoxVets;
    }
}