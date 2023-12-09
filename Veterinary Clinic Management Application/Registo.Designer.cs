namespace projeto_clinicaveterinária
{
    partial class Registo
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
            this.L_dataregisto = new System.Windows.Forms.Label();
            this.L_nomedono = new System.Windows.Forms.Label();
            this.L_nomeanimal = new System.Windows.Forms.Label();
            this.L_datanascimento = new System.Windows.Forms.Label();
            this.L_pesoatual = new System.Windows.Forms.Label();
            this.L_especie = new System.Windows.Forms.Label();
            this.L_raça = new System.Windows.Forms.Label();
            this.L_corpelagem = new System.Windows.Forms.Label();
            this.L_informaçoesanimal = new System.Windows.Forms.Label();
            this.B_Registar = new System.Windows.Forms.Button();
            this.B_macho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNpaciente = new System.Windows.Forms.TextBox();
            this.L_NP = new System.Windows.Forms.Label();
            this.textBoxnomeanimal = new System.Windows.Forms.TextBox();
            this.maskedTextBoxdataNA = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPA = new System.Windows.Forms.TextBox();
            this.B_F = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxnomedono = new System.Windows.Forms.TextBox();
            this.textBoxraça = new System.Windows.Forms.TextBox();
            this.textBoxcorpelagem = new System.Windows.Forms.TextBox();
            this.textBoxinformaçoes = new System.Windows.Forms.TextBox();
            this.L_registo = new System.Windows.Forms.Label();
            this.textBoxespecie = new System.Windows.Forms.TextBox();
            this.maskedTextBoxdataR = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxcontacto = new System.Windows.Forms.TextBox();
            this.L_contacto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_dataregisto
            // 
            this.L_dataregisto.AutoSize = true;
            this.L_dataregisto.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_dataregisto.Location = new System.Drawing.Point(6, 69);
            this.L_dataregisto.Name = "L_dataregisto";
            this.L_dataregisto.Size = new System.Drawing.Size(164, 30);
            this.L_dataregisto.TabIndex = 0;
            this.L_dataregisto.Text = "Data do registo:";
            this.L_dataregisto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // L_nomedono
            // 
            this.L_nomedono.AutoSize = true;
            this.L_nomedono.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nomedono.Location = new System.Drawing.Point(6, 30);
            this.L_nomedono.Name = "L_nomedono";
            this.L_nomedono.Size = new System.Drawing.Size(157, 30);
            this.L_nomedono.TabIndex = 1;
            this.L_nomedono.Text = "Nome do Dono:";
            // 
            // L_nomeanimal
            // 
            this.L_nomeanimal.AutoSize = true;
            this.L_nomeanimal.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nomeanimal.Location = new System.Drawing.Point(6, 30);
            this.L_nomeanimal.Name = "L_nomeanimal";
            this.L_nomeanimal.Size = new System.Drawing.Size(173, 30);
            this.L_nomeanimal.TabIndex = 2;
            this.L_nomeanimal.Text = "Nome do animal:";
            // 
            // L_datanascimento
            // 
            this.L_datanascimento.AutoSize = true;
            this.L_datanascimento.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_datanascimento.Location = new System.Drawing.Point(271, 72);
            this.L_datanascimento.Name = "L_datanascimento";
            this.L_datanascimento.Size = new System.Drawing.Size(211, 30);
            this.L_datanascimento.TabIndex = 3;
            this.L_datanascimento.Text = "Data de nascimento:";
            // 
            // L_pesoatual
            // 
            this.L_pesoatual.AutoSize = true;
            this.L_pesoatual.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_pesoatual.Location = new System.Drawing.Point(597, 71);
            this.L_pesoatual.Name = "L_pesoatual";
            this.L_pesoatual.Size = new System.Drawing.Size(118, 30);
            this.L_pesoatual.TabIndex = 4;
            this.L_pesoatual.Text = "Peso Atual:";
            // 
            // L_especie
            // 
            this.L_especie.AutoSize = true;
            this.L_especie.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_especie.Location = new System.Drawing.Point(478, 22);
            this.L_especie.Name = "L_especie";
            this.L_especie.Size = new System.Drawing.Size(85, 30);
            this.L_especie.TabIndex = 7;
            this.L_especie.Text = "Espécie:";
            this.L_especie.Click += new System.EventHandler(this.L_especie_Click);
            // 
            // L_raça
            // 
            this.L_raça.AutoSize = true;
            this.L_raça.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_raça.Location = new System.Drawing.Point(167, 22);
            this.L_raça.Name = "L_raça";
            this.L_raça.Size = new System.Drawing.Size(63, 30);
            this.L_raça.TabIndex = 8;
            this.L_raça.Text = "Raça:";
            // 
            // L_corpelagem
            // 
            this.L_corpelagem.AutoSize = true;
            this.L_corpelagem.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_corpelagem.Location = new System.Drawing.Point(167, 68);
            this.L_corpelagem.Name = "L_corpelagem";
            this.L_corpelagem.Size = new System.Drawing.Size(142, 30);
            this.L_corpelagem.TabIndex = 9;
            this.L_corpelagem.Text = "Cor/Pelagem:";
            // 
            // L_informaçoesanimal
            // 
            this.L_informaçoesanimal.AutoSize = true;
            this.L_informaçoesanimal.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_informaçoesanimal.Location = new System.Drawing.Point(6, 18);
            this.L_informaçoesanimal.Name = "L_informaçoesanimal";
            this.L_informaçoesanimal.Size = new System.Drawing.Size(335, 30);
            this.L_informaçoesanimal.TabIndex = 10;
            this.L_informaçoesanimal.Text = "Principais informações do animal:";
            // 
            // B_Registar
            // 
            this.B_Registar.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Registar.Location = new System.Drawing.Point(738, 569);
            this.B_Registar.Name = "B_Registar";
            this.B_Registar.Size = new System.Drawing.Size(124, 45);
            this.B_Registar.TabIndex = 11;
            this.B_Registar.Text = "REGISTAR";
            this.B_Registar.UseVisualStyleBackColor = true;
            this.B_Registar.Click += new System.EventHandler(this.B_Registar_Click);
            // 
            // B_macho
            // 
            this.B_macho.AutoSize = true;
            this.B_macho.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_macho.Location = new System.Drawing.Point(11, 18);
            this.B_macho.Name = "B_macho";
            this.B_macho.Size = new System.Drawing.Size(98, 34);
            this.B_macho.TabIndex = 14;
            this.B_macho.TabStop = true;
            this.B_macho.Text = "Macho";
            this.B_macho.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNpaciente);
            this.groupBox1.Controls.Add(this.L_NP);
            this.groupBox1.Controls.Add(this.textBoxnomeanimal);
            this.groupBox1.Controls.Add(this.maskedTextBoxdataNA);
            this.groupBox1.Controls.Add(this.L_datanascimento);
            this.groupBox1.Controls.Add(this.L_pesoatual);
            this.groupBox1.Controls.Add(this.textBoxPA);
            this.groupBox1.Controls.Add(this.L_nomeanimal);
            this.groupBox1.Location = new System.Drawing.Point(34, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 112);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxNpaciente
            // 
            this.textBoxNpaciente.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNpaciente.Location = new System.Drawing.Point(146, 71);
            this.textBoxNpaciente.Name = "textBoxNpaciente";
            this.textBoxNpaciente.Size = new System.Drawing.Size(110, 30);
            this.textBoxNpaciente.TabIndex = 27;
            // 
            // L_NP
            // 
            this.L_NP.AutoSize = true;
            this.L_NP.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NP.Location = new System.Drawing.Point(6, 70);
            this.L_NP.Name = "L_NP";
            this.L_NP.Size = new System.Drawing.Size(124, 30);
            this.L_NP.TabIndex = 27;
            this.L_NP.Text = "Nº. Paciente:";
            this.L_NP.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // textBoxnomeanimal
            // 
            this.textBoxnomeanimal.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnomeanimal.Location = new System.Drawing.Point(203, 29);
            this.textBoxnomeanimal.Name = "textBoxnomeanimal";
            this.textBoxnomeanimal.Size = new System.Drawing.Size(642, 30);
            this.textBoxnomeanimal.TabIndex = 24;
            // 
            // maskedTextBoxdataNA
            // 
            this.maskedTextBoxdataNA.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxdataNA.Location = new System.Drawing.Point(499, 72);
            this.maskedTextBoxdataNA.Mask = "00/00/0000";
            this.maskedTextBoxdataNA.Name = "maskedTextBoxdataNA";
            this.maskedTextBoxdataNA.Size = new System.Drawing.Size(89, 30);
            this.maskedTextBoxdataNA.TabIndex = 24;
            this.maskedTextBoxdataNA.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPA
            // 
            this.textBoxPA.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPA.Location = new System.Drawing.Point(736, 70);
            this.textBoxPA.Name = "textBoxPA";
            this.textBoxPA.Size = new System.Drawing.Size(109, 30);
            this.textBoxPA.TabIndex = 17;
            // 
            // B_F
            // 
            this.B_F.AutoSize = true;
            this.B_F.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_F.Location = new System.Drawing.Point(11, 66);
            this.B_F.Name = "B_F";
            this.B_F.Size = new System.Drawing.Size(99, 34);
            this.B_F.TabIndex = 16;
            this.B_F.TabStop = true;
            this.B_F.Text = "Fêmea";
            this.B_F.UseVisualStyleBackColor = true;
            // 
            // textBoxnomedono
            // 
            this.textBoxnomedono.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnomedono.Location = new System.Drawing.Point(187, 30);
            this.textBoxnomedono.Name = "textBoxnomedono";
            this.textBoxnomedono.Size = new System.Drawing.Size(658, 30);
            this.textBoxnomedono.TabIndex = 16;
            // 
            // textBoxraça
            // 
            this.textBoxraça.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxraça.Location = new System.Drawing.Point(249, 22);
            this.textBoxraça.Name = "textBoxraça";
            this.textBoxraça.Size = new System.Drawing.Size(215, 30);
            this.textBoxraça.TabIndex = 18;
            // 
            // textBoxcorpelagem
            // 
            this.textBoxcorpelagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcorpelagem.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcorpelagem.Location = new System.Drawing.Point(327, 70);
            this.textBoxcorpelagem.Name = "textBoxcorpelagem";
            this.textBoxcorpelagem.Size = new System.Drawing.Size(518, 23);
            this.textBoxcorpelagem.TabIndex = 19;
            this.textBoxcorpelagem.TextChanged += new System.EventHandler(this.textBoxcorpelagem_TextChanged);
            // 
            // textBoxinformaçoes
            // 
            this.textBoxinformaçoes.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxinformaçoes.Location = new System.Drawing.Point(11, 51);
            this.textBoxinformaçoes.Name = "textBoxinformaçoes";
            this.textBoxinformaçoes.Size = new System.Drawing.Size(834, 30);
            this.textBoxinformaçoes.TabIndex = 20;
            // 
            // L_registo
            // 
            this.L_registo.AutoSize = true;
            this.L_registo.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_registo.ForeColor = System.Drawing.Color.Black;
            this.L_registo.Location = new System.Drawing.Point(36, 32);
            this.L_registo.Name = "L_registo";
            this.L_registo.Size = new System.Drawing.Size(325, 53);
            this.L_registo.TabIndex = 21;
            this.L_registo.Text = "Registo do Paciente";
            this.L_registo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxespecie
            // 
            this.textBoxespecie.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxespecie.Location = new System.Drawing.Point(573, 22);
            this.textBoxespecie.Name = "textBoxespecie";
            this.textBoxespecie.Size = new System.Drawing.Size(272, 30);
            this.textBoxespecie.TabIndex = 22;
            this.textBoxespecie.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // maskedTextBoxdataR
            // 
            this.maskedTextBoxdataR.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxdataR.Location = new System.Drawing.Point(191, 68);
            this.maskedTextBoxdataR.Mask = "00/00/0000";
            this.maskedTextBoxdataR.Name = "maskedTextBoxdataR";
            this.maskedTextBoxdataR.Size = new System.Drawing.Size(88, 30);
            this.maskedTextBoxdataR.TabIndex = 23;
            this.maskedTextBoxdataR.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.L_especie);
            this.groupBox2.Controls.Add(this.textBoxespecie);
            this.groupBox2.Controls.Add(this.B_F);
            this.groupBox2.Controls.Add(this.L_raça);
            this.groupBox2.Controls.Add(this.B_macho);
            this.groupBox2.Controls.Add(this.textBoxraça);
            this.groupBox2.Controls.Add(this.textBoxcorpelagem);
            this.groupBox2.Controls.Add(this.L_corpelagem);
            this.groupBox2.Location = new System.Drawing.Point(34, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 113);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.L_informaçoesanimal);
            this.groupBox3.Controls.Add(this.textBoxinformaçoes);
            this.groupBox3.Location = new System.Drawing.Point(34, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxcontacto);
            this.groupBox4.Controls.Add(this.L_contacto);
            this.groupBox4.Controls.Add(this.L_dataregisto);
            this.groupBox4.Controls.Add(this.maskedTextBoxdataR);
            this.groupBox4.Controls.Add(this.L_nomedono);
            this.groupBox4.Controls.Add(this.textBoxnomedono);
            this.groupBox4.Location = new System.Drawing.Point(34, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(851, 119);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // textBoxcontacto
            // 
            this.textBoxcontacto.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcontacto.Location = new System.Drawing.Point(414, 69);
            this.textBoxcontacto.Name = "textBoxcontacto";
            this.textBoxcontacto.Size = new System.Drawing.Size(165, 30);
            this.textBoxcontacto.TabIndex = 28;
            // 
            // L_contacto
            // 
            this.L_contacto.AutoSize = true;
            this.L_contacto.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_contacto.Location = new System.Drawing.Point(286, 69);
            this.L_contacto.Name = "L_contacto";
            this.L_contacto.Size = new System.Drawing.Size(108, 30);
            this.L_contacto.TabIndex = 27;
            this.L_contacto.Text = "Contacto:";
            this.L_contacto.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 648);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.L_registo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_Registar);
            this.Name = "Registo";
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_dataregisto;
        private System.Windows.Forms.Label L_nomedono;
        private System.Windows.Forms.Label L_nomeanimal;
        private System.Windows.Forms.Label L_datanascimento;
        private System.Windows.Forms.Label L_pesoatual;
        private System.Windows.Forms.Label L_especie;
        private System.Windows.Forms.Label L_raça;
        private System.Windows.Forms.Label L_corpelagem;
        private System.Windows.Forms.Label L_informaçoesanimal;
        private System.Windows.Forms.Button B_Registar;
        private System.Windows.Forms.RadioButton B_macho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton B_F;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxnomedono;
        private System.Windows.Forms.TextBox textBoxPA;
        private System.Windows.Forms.TextBox textBoxraça;
        private System.Windows.Forms.TextBox textBoxcorpelagem;
        private System.Windows.Forms.TextBox textBoxinformaçoes;
        private System.Windows.Forms.Label L_registo;
        private System.Windows.Forms.TextBox textBoxnomeanimal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxdataNA;
        private System.Windows.Forms.TextBox textBoxespecie;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxdataR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label L_contacto;
        private System.Windows.Forms.TextBox textBoxcontacto;
        private System.Windows.Forms.Label L_NP;
        private System.Windows.Forms.TextBox textBoxNpaciente;
    }
}