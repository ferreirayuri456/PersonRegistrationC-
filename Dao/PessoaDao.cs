using System;
using MySql.Data.MySqlClient;

namespace Cadastro.Dao
{
    class PessoaDao
    {
        private Service.connectiondb connectiondb;
        private MySqlConnection connection;

        public PessoaDao() 
        { 
        
        }
        public void Exclua(String cpf)
        {

            connection = new MySqlConnection();
            connectiondb = new Service.connectiondb();
            connection.ConnectionString = connectiondb.getConnectionString();
            var query = "DELETE FROM pessoa ";
            query+= "WHERE cpf = ?cpf";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                connection.Close();
            }
        }

        public void Insira(String nome, String cpf, String endereco, String telefone)
        {
            connection = new MySqlConnection();
            connectiondb = new Service.connectiondb();
            connection.ConnectionString = connectiondb.getConnectionString();
            var query = "INSERT INTO pessoa(nome, cpf, endereco, telefone) VALUES";
            query += "(?nome, ?cpf, ?endereco, ?telefone)";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?endereco", endereco);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally 
            {
                connection.Close();
            }
            
        }


        public void Altera(String nome, String cpf, String endereco, String telefone)
        {
            connection = new MySqlConnection();
            connectiondb = new Service.connectiondb();
            connection.ConnectionString = connectiondb.getConnectionString();
            string query = "UPDATE pessoa SET nome = ?nome, endereco = ?endereco, telefone = ?telefone"; 
            query += " WHERE cpf = ?cpf";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?cpf", cpf);
                cmd.Parameters.AddWithValue("?endereco", endereco);
                cmd.Parameters.AddWithValue("?telefone", telefone);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                connection.Close();
            }

        }


    }
}
