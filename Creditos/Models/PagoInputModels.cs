using System;
using Entity;

namespace Creditos.Models
{
    public class PagoInputModels
    {
        public decimal Valor { get; set; }  
        public DateTime Fecha { get; set; }
    }
    public class PagoViewModels:PagoInputModels
    {
        public int Id { get; set; }
        public PagoViewModels(Pago pago)
        {
            Id = pago.ID;
            Valor = pago.Valor;
            Fecha = pago.Fecha;
        }
    }
    
}
