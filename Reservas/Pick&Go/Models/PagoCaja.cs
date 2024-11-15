using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_Go.Models
{
   internal class PagoCaja
   {
      public string Nombre { get; set; }

      public PagoCaja(string nombre)
      {
         Nombre = nombre;
      }

      public string ProcesarPago(Pedido pedido, double montoPagado)
      {
         if (montoPagado >= pedido.Total)
         {
            double cambio = montoPagado - pedido.Total;
            return $"Pago aceptado. Cambio: ${cambio:F2}";
         }
         else
         {
            return $"El monto es insuficiente. Se necesita ${pedido.Total - montoPagado:F2} más.";
         }
      }
   }
}