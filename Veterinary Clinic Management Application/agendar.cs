using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto_clinicaveterinária
{
    public partial class agendar : Form
    {
        gestor gestor;
        public agendar(gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RB_Cirurgia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B_REGISTAR_Click(object sender, EventArgs e)
        {

            string data = maskedTextBoxdata.Text;

            //string nomeveterinario = textBoxveterinario.Text;
            string tipomarcaçao;
            double custo;
            if (RB_consulta.Checked == true)
            {
                tipomarcaçao = "Cirurgia";
                custo = 20;
            }
            else if (RB_Vacinaçao.Checked == true)
            {
                tipomarcaçao = "Vacina";
                custo = 40;
            }
            else
            {
                tipomarcaçao = "Consulta";
                custo = 100;
            }
            string observaçoes = textBoxobservaçoes.Text;
            string vet = comboBoxVets.Text;
            int numero_paciente = Convert.ToInt32(comboBox_Npaciente.Text);
            string resp = "";
            if (data.Trim() != "")
            {
                resp = gestor.inseriragendamento(data, tipomarcaçao, observaçoes, vet, custo, numero_paciente);
                MessageBox.Show(resp);
            }
            else
                MessageBox.Show("Prencha os dados em falta!");


        }

        private void agendar_Load(object sender, EventArgs e)
        {
            List<animais> lista = gestor.getListaanimais();
            foreach (animais t in lista)
                comboBox_Npaciente.Items.Add(t.getN_paciente());

            List<veterinario> listaVet = gestor.getListaVets();
            foreach (veterinario v in listaVet)
            {
                comboBoxVets.Items.Add(v.getNome_veterinario());
            }

        }

        private void textBoxN_paciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            string id = comboBox_Npaciente.Text;

            foreach (animais an in gestor.getListaanimais())
            {
                if (Convert.ToInt32(id) == an.getN_paciente())
                {
                    textBoxNomepaciente.Text = an.getnome_animal();

                }
            }

        }

        private void textBoxveterinario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
