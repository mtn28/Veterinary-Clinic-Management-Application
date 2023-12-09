namespace projeto_clinicaveterinária
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_registoP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.B_agenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonlistas = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_registoP
            // 
            this.B_registoP.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_registoP.Location = new System.Drawing.Point(794, 129);
            this.B_registoP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_registoP.Name = "B_registoP";
            this.B_registoP.Size = new System.Drawing.Size(236, 74);
            this.B_registoP.TabIndex = 0;
            this.B_registoP.Text = "Registo do Paciente";
            this.B_registoP.UseVisualStyleBackColor = true;
            this.B_registoP.Click += new System.EventHandler(this.B_registoP_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(794, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registo do Veterinário";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_agenda
            // 
            this.B_agenda.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_agenda.Location = new System.Drawing.Point(794, 289);
            this.B_agenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_agenda.Name = "B_agenda";
            this.B_agenda.Size = new System.Drawing.Size(236, 74);
            this.B_agenda.TabIndex = 2;
            this.B_agenda.Text = "Agenda";
            this.B_agenda.UseVisualStyleBackColor = true;
            this.B_agenda.Click += new System.EventHandler(this.B_agenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(755, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clinica Veterinária";
            // 
            // buttonlistas
            // 
            this.buttonlistas.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlistas.Location = new System.Drawing.Point(794, 371);
            this.buttonlistas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonlistas.Name = "buttonlistas";
            this.buttonlistas.Size = new System.Drawing.Size(236, 74);
            this.buttonlistas.TabIndex = 5;
            this.buttonlistas.Text = "Pesquisar";
            this.buttonlistas.UseVisualStyleBackColor = true;
            this.buttonlistas.Click += new System.EventHandler(this.buttonlistas_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Location = new System.Drawing.Point(794, 449);
            this.button_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(236, 74);
            this.button_guardar.TabIndex = 6;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1536, 846);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.buttonlistas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_agenda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B_registoP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_registoP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_agenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlistas;
        private System.Windows.Forms.Button button_guardar;
    }
}

