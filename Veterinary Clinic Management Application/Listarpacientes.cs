using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto_clinicaveterinária
{
    public partial class Listarpacientes : Form
    {
        gestor gestor;
        public Listarpacientes(gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }


        private void Listarpacientes_Load(object sender, EventArgs e)
        {
            List<animais> lista = gestor.getListaanimais();
            foreach (animais t in lista)
            {
                comboBoxNP.Items.Add(t.getN_paciente());
                comboBox_histAnimal.Items.Add(t.getN_paciente());
            }



            foreach (animais t in lista)
                comboBoxND.Items.Add(t.getnome_dono());

            List<veterinario> listaVet = gestor.getListaVets();
            foreach (veterinario v in listaVet)
            {
                comboBox_Nmedico.Items.Add(v.getN_medico());
            }

            string maisagenda = gestor.especieComMaisAgendamentos();

            labelmaisagenda.Text = maisagenda;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonpesquisarNP_Click(object sender, EventArgs e)
        {
            string NP = comboBoxNP.Text;
            string resp = "";
            if (NP != "")
            {
                resp = gestor.pesquisarNP(NP);
                listBoxNP.Items.Add(resp);
            }
            else
                MessageBox.Show("Selecione um número!");
        }

        private void buttonpesquisarND_Click(object sender, EventArgs e)
        {
            string ND = comboBoxND.Text;
            string resp = "";
            if (ND != "")
            {
                resp = gestor.pesquisarND(ND);
                listBoxND.Items.Add(resp);
            }
            else
                MessageBox.Show("Selecione um nome!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonpesquisaeNM_Click(object sender, EventArgs e)
        {
            string id = comboBox_Nmedico.Text;

            foreach (veterinario v in gestor.getListaVets())
                if (id == Convert.ToString(v.getN_medico()))
                {
                    foreach (agenda a in gestor.getListaAgenda())
                    {
                        if (v.getNome_veterinario() == a.getvet())
                        {
                            foreach (animais an in gestor.getListaanimais())
                                if (a.getNumero_paciente() == an.getN_paciente())
                                {
                                    listBox1NM.Items.Add("Intervenção: " + a.gettipomarcaçao() + " Veterinario: " + v.getNome_veterinario() + " Paciente: " + an.getnome_animal());
                                }

                        }
                    }
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = maskedTextBoxData.Text;

            foreach (veterinario v in gestor.getListaVets())

                foreach (agenda a in gestor.getListaAgenda())
                {
                    if (data == a.getdata() && v.getNome_veterinario() == a.getvet())
                        foreach (animais an in gestor.getListaanimais())
                            if (a.getNumero_paciente() == an.getN_paciente())
                            {
                                listBoxdata.Items.Add("Intervenção: " + a.gettipomarcaçao() + " Veterinario: " + v.getNome_veterinario() + " Paciente: " + an.getnome_animal());
                            }
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox_histAnimal.Text);
            double custo = 0;
            foreach (animais an in gestor.getListaanimais())
            {
                if (id == an.getN_paciente())
                {
                    foreach (agenda a in gestor.getListaAgenda())
                    {
                        if (an.getN_paciente() == a.getNumero_paciente())
                        {
                            custo = custo + a.getcusto();
                            listBox1.Items.Add("Intervenção: " + a.gettipomarcaçao() + " Veterinario: " + a.getvet() + " Animal: " + an.getnome_animal() + " Dono: " + an.getnome_dono());


                        }
                    }
                }

            }
            labelCustoTotal.Text = "Custo Total:" + custo;
        }
    }
}
