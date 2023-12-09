namespace projeto_clinicaveterinária
{
    public class agenda
    {

        private string data;
        private string tipomarcaçao;
        private string observaçoes;
        private string vet;
        private double custo;
        private int Numero_paciente;

        public agenda(string data, string tipomarcaçao, string observaçoes, string vet, double custo, int Numero_paciente)
        {
            this.data = data;

            this.tipomarcaçao = tipomarcaçao;
            this.observaçoes = observaçoes;
            this.vet = vet;
            this.custo = custo;
            this.Numero_paciente = Numero_paciente;
        }

        public int getNumero_paciente()
        {
            return Numero_paciente;
        }

        public string getvet()
        {
            return vet;
        }
        public double getcusto()
        {
            return custo;
        }

        public void setdata(string _data)
        {
            data = _data;
        }


        public string getdata()
        {
            return data;
        }



        public void settipomarcaçao(string _tipomarcaçao)
        {
            tipomarcaçao = _tipomarcaçao;
        }


        public string gettipomarcaçao()
        {
            return tipomarcaçao;
        }

        public void setobservaçoes(string _observaçoes)
        {
            observaçoes = _observaçoes;
        }


        public string getobservaçoes()
        {
            return observaçoes;
        }




    }
}
