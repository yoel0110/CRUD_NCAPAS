
using Microsoft.Data.SqlClient;
using System.Data;
namespace AccessDataLayer
{
    public class CD_Products
    {
        private AccesData _connection = new AccesData();
        private SqlDataReader _reader;
        private DataTable _table = new DataTable();
        private SqlCommand _command = new SqlCommand();
        public DataTable Reads()
        {
            _command.Connection = _connection.OpenConnection;
            _command.CommandText = "selectProducts";
            _command.CommandType = CommandType.StoredProcedure;
            _reader = _command.ExecuteReader();
            _table.Load(_reader);
            return _table;
        }
        public void Insert(string name, string desc, string mark, double price, int stock)
        {
            _command.Connection = _connection.OpenConnection;
            _command.CommandText = "InsertProduct";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@nombre", name);
            _command.Parameters.AddWithValue("@descrip", desc);
            _command.Parameters.AddWithValue("@Marca", mark);
            _command.Parameters.AddWithValue("@precio", price);
            _command.Parameters.AddWithValue("@stock", stock);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void Update(string nombre, string desc, string marca, double precio, int stock, int id)
        {
            _command.Connection = _connection.OpenConnection;
            _command.CommandText = "updateProduct";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@nombre", nombre);
            _command.Parameters.AddWithValue("@descrip", desc);
            _command.Parameters.AddWithValue("@Marca", marca);
            _command.Parameters.AddWithValue("@precio", precio);
            _command.Parameters.AddWithValue("@stock", precio);
            _command.Parameters.AddWithValue("@id", id);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void Delete(int id)
        {
            _command.Connection = _connection.OpenConnection;
            _command.CommandText = "deleteProduct";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@idpro", id);
            _command.ExecuteNonQuery();
            _command.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
