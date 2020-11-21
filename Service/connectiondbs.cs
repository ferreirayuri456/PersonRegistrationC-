using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Cadastro.Service
{
    class connectiondb
    {
        private string connectionString;

        public string getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["cadastroPessoas.Properties.Settings.cadastroConnectionString"].ConnectionString;
            return connectionString;
        }


    }
}
