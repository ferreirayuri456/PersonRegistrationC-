using System;

namespace Cadastro.model
{
    class Endereco
    {

        private int Id { get; set; }
        private string Logradouro { get; set; }
        private int Numero { get; set; }
        private int Cep { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }

        public Endereco(int id, string logradouro, int numero, int cep, string bairro, string cidade, string estado)
        {
            this.Id = id;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Cep = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;

        }


    }
}
