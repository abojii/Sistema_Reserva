using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_Go.Models
{
   internal class Cliente
   {
      public int IdCliente { get; set; }
      public string Nombre { get; set; }

      public Cliente(int idCliente, string nombre)
      {
         IdCliente = idCliente;
         Nombre = nombre;
      }
   }
}