namespace projeto_clinicaveterinária
{
    public class veterinario
    {
        private string nome_veterinario;
        private string dataN_veterinario;
        private int contactoV;
        private int N_medico;
        private string especialidade;

        public veterinario(string nome_veterinario, string dataN_veterinario, int contactoV, int n_medico, string especialidade)
        {
            this.nome_veterinario = nome_veterinario;
            this.dataN_veterinario = dataN_veterinario;
            this.contactoV = contactoV;
            N_medico = n_medico;
            this.especialidade = especialidade;
        }

        public void setNome_veterinario(string _nome_veterinario)
        {
            nome_veterinario = _nome_veterinario;
        }


        public string getNome_veterinario()
        {
            return nome_veterinario;
        }

        public void setdataN_veterinario(string _dataN_veterinario)
        {
            dataN_veterinario = _dataN_veterinario;
        }


        public string getdataN_veterinario()
        {
            return dataN_veterinario;
        }

        public void setcontactoV(int _contactoV)
        {
            contactoV = _contactoV;
        }


        public int getcontactoV()
        {
            return contactoV;
        }

        public void setN_medico(int _N_medico)
        {
            contactoV = _N_medico;
        }


        public int getN_medico()
        {
            return N_medico;
        }

        public void setespecialidade(string _especialidade)
        {
            especialidade = _especialidade;
        }


        public string getespecialidade()
        {
            return especialidade;
        }





    }



}
