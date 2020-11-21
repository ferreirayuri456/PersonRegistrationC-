using Cadastro.Dao;
using System;

namespace cadastroPessoas.VO
{
    class CrudVO
    {
        private int _id;
        private String _nome;
        private String _cpf;
        private String _endereco;
        private String _telefone;
       private Cadastro.Dao.PessoaDao dao;

        public CrudVO()
        {

        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public String endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public String telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public void Inserir()
        {
            dao = new PessoaDao();
            dao.Insira(nome, cpf, endereco,telefone);
        }

        public void Atualizar()
        {
            dao = new PessoaDao();
            dao.Altera(nome, cpf, endereco, telefone);
        }

        public void Excluir()
        {
            dao = new PessoaDao();
            dao.Exclua (cpf);
        }

 

    }
}
