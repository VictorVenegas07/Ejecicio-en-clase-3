using System;
using Datos;
using Entity;

namespace Logica
{
    public class PagoService
    {
        private readonly ConnectionManager connectionManager;
        private readonly PagoRepository pagoRepositorio;
        public PagoService(String cadena)
        {
            connectionManager = new ConnectionManager(cadena);
            pagoRepositorio = new PagoRepository(connectionManager);
        }
         public GuardarPagoResponse Guardar(Pago pago)
        {
            try
            {
                
                connectionManager.Open();
                pagoRepositorio.Guardar(pago);
            
                return new GuardarPagoResponse(pago);
            }
            catch (Exception e)
            {
                return new GuardarPagoResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally {  connectionManager.Close(); }
        }

    }
     public class GuardarPagoResponse 
    {
         public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Pago Pago { get; set; }
        public GuardarPagoResponse(Pago pago)
        {
            Error = false;
            Pago = pago;
        }
        public GuardarPagoResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
       
    }
}
