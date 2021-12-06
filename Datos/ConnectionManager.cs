using System.Data;
using System.Security.AccessControl;
using System;
using System.Data.SqlClient;
namespace Datos
{
    public class ConnectionManager
    {
        public SqlConnection connection;

        public ConnectionManager(string cadena)
        {
            connection = new SqlConnection(cadena);
        }

        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
        
    }
}
