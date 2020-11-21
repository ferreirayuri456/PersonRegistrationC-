using System;

namespace Cadastro.model
{
    class Pessoa
    {
        public Pessoa(int id, string nome, string cpf, string endereco, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }

        private int Id { get; set; }
        private String Nome { get; set; }
        private String Cpf { get; set; }
        private string Endereco { get; set; }
        private string Telefone { get; set; }






    }
}
