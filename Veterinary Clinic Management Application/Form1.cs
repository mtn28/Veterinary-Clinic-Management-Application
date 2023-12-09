using System;
using System.Windows.Forms;

namespace projeto_clinicaveterinária
{
    public partial class Form1 : Form
    {
        gestor gestor;
        protected string fich = "../../Ficheiros/";
        public Form1()
        {
            InitializeComponent();
            gestor = new gestor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestor.leragenda(gestor.getListaAgenda(), fich + "agenda.txt");
            gestor.leranimaisdono(gestor.getListaanimais(), fich + "animais.txt");
            gestor.lervets(gestor.getListaVets(), fich + "vets.txt");
        }

        private void B_registoP_Click(object sender, EventArgs e)
        {
            Form P = new Form1();
            Form RP = new Registo(gestor);
            P.Hide();
            RP.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form P = new Form1();
            Form RV = new RegistoVeterinário(gestor);
            P.Hide();
            RV.ShowDialog();
        }

        private void B_agenda_Click(object sender, EventArgs e)
        {
            Form P = new Form1();
            Form A = new agendar(gestor);
            P.Hide();
            A.ShowDialog();
        }

        private void buttonlistas_Click(object sender, EventArgs e)
        {
            Form P = new Form1();
            Form A = new Listarpacientes(gestor);
            P.Hide();
            A.ShowDialog();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            gestor.gravaragenda(fich + "agenda.txt");
            gestor.gravarAnimaisDono(fich + "animais.txt");
            gestor.gravarvets(fich + "vets.txt");
        }
    }

}
