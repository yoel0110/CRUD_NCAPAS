
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccessDataLayer
{
    internal class AccesData
    {
        private SqlConnection _connection = new SqlConnection("Server=[serverAddres];DataBase= " +
            "practica;Integrated Security=true; TrustServerCertificate=True;");

        public SqlConnection OpenConnection
        {
            get
            {
                if (_connection.State == ConnectionState.Open)
                {
                    return _connection;
                }
                _connection.Open();
                return _connection;
            }
        }

        public SqlConnection CloseConnection()
        {
            if( _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                return _connection;
            }
            return _connection;
        }
    }
}


