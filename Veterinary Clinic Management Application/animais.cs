using System.Collections.Generic;

namespace projeto_clinicaveterinária
{
    public class animais
    {
        private string nome_dono;
        private string dataN_dono;
        private int contactoD;
        private string nome_animal;
        private int N_paciente;
        private string dataN_animal;
        private double peso_animal;
        private char sexo;
        private string raça;
        private string especie;
        private string cor_pelagem;
        private string P_informaçoes;

        private List<agenda> LI;

        public animais(string nome_dono, string dataN_dono, int contactoD, string nome_animal, int n_paciente, string dataN_animal, double peso_animal, char sexo, string raça, string especie, string cor_pelagem, string p_informaçoes)
        {
            this.nome_dono = nome_dono;
            this.dataN_dono = dataN_dono;
            this.contactoD = contactoD;
            this.nome_animal = nome_animal;
            N_paciente = n_paciente;
            this.dataN_animal = dataN_animal;
            this.peso_animal = peso_animal;
            this.sexo = sexo;
            this.raça = raça;
            this.especie = especie;
            this.cor_pelagem = cor_pelagem;
            P_informaçoes = p_informaçoes;
            LI = new List<agenda>();
        }


        public void setnome_dono(string _nome_dono)
        {
            nome_dono = _nome_dono;
        }


        public string getnome_dono()
        {
            return nome_dono;
        }

        public void setdataN_dono(string _dataN_dono)
        {
            dataN_dono = _dataN_dono;
        }


        public string getdataN_dono()
        {
            return dataN_dono;
        }

        public void setcontactoD(int _contactoD)
        {
            contactoD = _contactoD;
        }


        public int getcontactoS()
        {
            return contactoD;
        }

        public void setnome_animal(string _nome_animal)
        {
            nome_animal = _nome_animal;
        }


        public string getnome_animal()
        {
            return nome_animal;
        }

        public void setN_paciente(int _N_paciente)
        {
            N_paciente = _N_paciente;
        }


        public int getN_paciente()
        {
            return N_paciente;
        }

        public void setdataN_animal(string _dataN_animal)
        {
            dataN_animal = _dataN_animal;
        }


        public string getdataN_animal()
        {
            return dataN_animal;
        }

        public void setpeso_animal(double _peso_animal)
        {
            peso_animal = _peso_animal;
        }


        public double getpeso_animal()
        {
            return peso_animal;
        }

        public void setsexo(char _sexo)
        {
            sexo = _sexo;
        }


        public char getsexo()
        {
            return sexo;
        }

        public void setraça(string _raça)
        {
            raça = _raça;
        }


        public string getraça()
        {
            return raça;
        }

        public void setespecie(string _especie)
        {
            especie = _especie;
        }


        public string getespecie()
        {
            return especie;
        }

        public void setcor_pelagem(string _cor_pelagem)
        {
            cor_pelagem = _cor_pelagem;
        }


        public string getcor_pelagem()
        {
            return cor_pelagem;
        }

        public void setP_informaçoes(string _P_informaçoes)
        {
            P_informaçoes = _P_informaçoes;
        }


        public string getP_informaçoes()
        {
            return P_informaçoes;
        }

        public List<agenda> getLI()
        {
            return LI;
        }



    }
}
