using System;
using System.Windows.Forms;

namespace projeto_clinicaveterinária
{
    public partial class Registo : Form
    {
        gestor gestor;
        public Registo(gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void L_especie_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void B_editar_Click(object sender, EventArgs e)
        {

        }

        private void B_Registar_Click(object sender, EventArgs e)
        {
            string nomedono = textBoxnomedono.Text;
            string dataregisto = maskedTextBoxdataR.Text;
            int contacto = Convert.ToInt32(textBoxcontacto.Text);
            string nomeanimal = textBoxnomeanimal.Text;
            int N_paciente = Convert.ToInt32(textBoxNpaciente.Text);
            string datanacimentoA = maskedTextBoxdataNA.Text;
            double peso_atual = Convert.ToDouble(textBoxPA.Text);
            char sexo;
            if (B_macho.Checked == true)
            {
                sexo = 'M';
            }
            else
            {
                sexo = 'F';
            }
            string raça = textBoxraça.Text;
            string especie = textBoxespecie.Text;
            string cor_pelagem = textBoxcorpelagem.Text;
            string P_informações = textBoxinformaçoes.Text;

            string resp = "";
            if (nomedono.Trim() != "" && nomeanimal.Trim() != "" && dataregisto.Trim() != "" && datanacimentoA.Trim() != "" && raça.Trim() != "" && especie.Trim() != "" && cor_pelagem.Trim() != "" && P_informações.Trim() != "")
            {
                resp = gestor.inseriranimal(nomedono, dataregisto, contacto, nomeanimal, N_paciente, datanacimentoA, peso_atual, sexo, raça, especie, cor_pelagem, P_informações);
                MessageBox.Show(resp);
            }
            else
                MessageBox.Show("Prencha os dados em falta!");
        }

        private void Registo_Load(object sender, EventArgs e)
        {

        }

        private void textBoxcorpelagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
