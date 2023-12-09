using System;
using System.Collections.Generic;
using System.IO;

namespace projeto_clinicaveterinária
{
    public class gestor
    {

        //declaração
        private List<animais> LA;
        private List<veterinario> LV;
        private List<agenda> LI;
        protected string fich = "../../../Ficheiros/";

        //construtor
        public gestor()
        {
            LA = new List<animais>();
            LV = new List<veterinario>();
            LI = new List<agenda>();
        }

        public List<animais> getListaanimais()
        {
            return LA;
        }
        public List<veterinario> getListaVets()
        {
            return LV;
        }
        public List<agenda> getListaAgenda()
        {
            return LI;
        }
        public string inseriranimal(string nome_dono, string dataN_dono, int contactoD, string nome_animal, int n_paciente, string dataN_animal, double peso_animal, char sexo, string raça, string especie, string cor_pelagem, string p_informaçoes)
        {
            string s = "";

            foreach (animais t in LA)
                if (t.getN_paciente().Equals(n_paciente))
                {
                    s = "Animal já existente!";
                    return s;
                }

            animais AN = new animais(nome_dono, dataN_dono, contactoD, nome_animal, n_paciente, dataN_animal, peso_animal, sexo, raça, especie, cor_pelagem, p_informaçoes);
            LA.Add(AN);
            s = "Animal inserido com sucesso!";
            return s;

        }

        public string inserirveterinario(string nome_veterinario, string dataN_veterinario, int contactoV, int n_medico, string especialidade)
        {
            string s = "";

            foreach (veterinario t in LV)
                if (t.getN_medico().Equals(n_medico))
                {
                    s = "Animal já existente!";
                    return s;
                }

            veterinario VET = new veterinario(nome_veterinario, dataN_veterinario, contactoV, n_medico, especialidade);
            LV.Add(VET);
            s = "Veterinário inserido com sucesso!";
            return s;

        }


        public string inseriragendamento(string data, string tipomarcaçao, string observaçoes, string vet, double custo, int Numero_paciente)
        {
            string s = "";


            agenda AG = new agenda(data, tipomarcaçao, observaçoes, vet, custo, Numero_paciente);
            LI.Add(AG);
            s = "Marcação agendada";
            return s;

        }

        public string pesquisarNP(string NP)
        {
            string s = "";
            foreach (animais t in LA)
                if (t.getN_paciente() == Convert.ToInt32(NP))
                {
                    s = "Paciente: " + t.getnome_animal() + " - Dono: " + t.getnome_dono();
                    break;
                }
            return s;
        }

        public string pesquisarND(string ND)
        {
            string s = "";
            foreach (animais t in LA)
                if (t.getnome_dono().Equals(ND))
                {
                    s = "Dono: " + t.getnome_dono() + " - Paciente: " + t.getnome_animal();
                    break;
                }
            return s;
        }

        public string pesquisarNV(string NV)
        {
            string s = "";
            foreach (veterinario t in LV)
                if (t.getN_medico() == Convert.ToInt32(NV))
                {
                    s = t.getN_medico().ToString();
                    break;
                }
            return s;
        }



        public string especieComMaisAgendamentos()
        {
            Dictionary<string, int> tipomaisint = new Dictionary<string, int>();
            string especie_animal;
            int cont = 0;
            int cont2 = 0;
            string s = "";
            int maior = -100;
            foreach (animais an in getListaanimais())
            {
                especie_animal = an.getespecie();
                foreach (agenda a in getListaAgenda())
                {
                    if (an.getN_paciente() == a.getNumero_paciente())
                    {
                        cont = cont + 1;

                        if (tipomaisint.ContainsKey(especie_animal))
                        {
                            tipomaisint[especie_animal] = cont2 + cont;
                        }
                        else
                        {
                            tipomaisint.Add(especie_animal, cont);
                        }
                    }
                }
            }
            foreach (KeyValuePair<string, int> Y in tipomaisint)
            {
                if (Y.Value > maior)
                {
                    maior = Y.Value;
                    s = "O tipo de animal com mais intervenções é " + Y.Key + " com " + maior + " de intervenções.";
                }
                if (maior == 0)
                {
                    s = "";
                }
            }


            return s;
        }




        public void gravarAnimaisDono(string fich)
        {
            StreamWriter f = new StreamWriter(fich);

            foreach(animais an in LA)
            {
                f.WriteLine(an.getnome_dono() + ";" + an.getdataN_dono() + ";" + an.getcontactoS() + ";" + an.getnome_animal() + ";" + an.getN_paciente() + ";" + an.getdataN_animal() + ";" + an.getpeso_animal() + ";" + an.getsexo() + ";" + an.getraça() + ";" + an.getespecie() + ";" + an.getcor_pelagem() + ";" + an.getP_informaçoes());
            }
            f.Close();

        }

        public void gravaragenda(string fich)
        {
            StreamWriter f = new StreamWriter(fich);

            foreach(agenda a in LI)
            {
                f.WriteLine(a.getdata() + ";" + a.gettipomarcaçao() + ";" + a.getobservaçoes() + ";" + a.getvet() + ";" + a.getcusto() + ";" + a.getNumero_paciente());
            }
            f.Close();
        }

        public void gravarvets(string fich)
        {
            StreamWriter f = new StreamWriter(fich);

            foreach (veterinario v in LV)
            {
                f.WriteLine(v.getNome_veterinario() + ";" + v.getdataN_veterinario() + ";" + v.getcontactoV() + ";" + v.getN_medico() + ";" + v.getespecialidade());
            }
            f.Close();
        }

        public void leranimaisdono(List<animais> LA, string fich)
        {
            StreamReader sr = new StreamReader(fich);

            string linha;
            string[] partes;
            while ((linha = sr.ReadLine()) != null)
            {
                partes = linha.Split(';');
                string nome_dono = partes[0];
                string dataN_dono = partes[1];
                int contactoD = Convert.ToInt32(partes[2]);
                string nome_animal = partes[3];
                int N_paciente = Convert.ToInt32(partes[4]);
                string dataN_animal = partes[5];
                double peso_animal = Convert.ToDouble(partes[6]);
                char sexo = Convert.ToChar(partes[7]);
                string raça = partes[8];
                string especie = partes[9];
                string cor_pelagem = partes[10];
                string P_informaçoes = partes[11];

                animais AN = new animais(nome_dono, dataN_dono, contactoD, nome_animal, N_paciente, dataN_animal, peso_animal, sexo, raça, especie, cor_pelagem, P_informaçoes);
                LA.Add(AN);
            }
            sr.Close();
        }

        public void leragenda(List<agenda> LI, string fich)
        {
            StreamReader sr = new StreamReader(fich);
            string linha;
            string[] partes;
            while ((linha = sr.ReadLine()) != null)
            {
                partes = linha.Split(';');
                string data = partes[0];
                string tipomarcaçao = partes[1];
                string observaçoes = partes[2];
                string vet = partes[3];
                double custo = Convert.ToDouble(partes[4]);
                int Numero_paciente = Convert.ToInt32(partes[5]);


                agenda AG = new agenda(data, tipomarcaçao, observaçoes, vet, custo, Numero_paciente);
                LI.Add(AG);
            }
            sr.Close();
        }

        public void lervets(List<veterinario> LV, string fich)
        {
            StreamReader sr = new StreamReader(fich);
            string linha;
            string[] partes;
            while ((linha = sr.ReadLine()) != null)
            {
                partes = linha.Split(';');
                string nome_veterinario = partes[0];
                string dataN_veterinario = partes[1];
                int contactoV = Convert.ToInt32(partes[2]);
                int N_medico = Convert.ToInt32(partes[3]);
                string especialidade = partes[4];
              


                veterinario VET = new veterinario(nome_veterinario, dataN_veterinario, contactoV, N_medico, especialidade);
                LV.Add(VET);
            }
            sr.Close();
        }


        



    }
}
