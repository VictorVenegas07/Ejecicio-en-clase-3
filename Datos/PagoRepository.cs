using System;
using System.Data.SqlClient;
using Entity;

namespace Datos
{
    public class PagoRepository
    {
         private readonly SqlConnection connection;
         public PagoRepository(ConnectionManager _connection)
         {
            connection = _connection.connection;
        }
        
        public void Guardar(Pago pago)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Pago(Valor,Fecha) VALUES(@Valor,@Fecha)";
                command.Parameters.AddWithValue("@Valor", pago.Valor);
                command.Parameters.AddWithValue("@Fecha", pago.Fecha);
                command.ExecuteNonQuery();
            }
        }
    }
}
