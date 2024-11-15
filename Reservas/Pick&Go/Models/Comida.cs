using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_Go.Models
{
   internal class Comida
   {
      public int IdComida { get; set; }
      public string Nombre { get; set; }
      public double Precio { get; set; }

      public Comida(int idComida, string nombre, double precio)
      {
         IdComida = idComida;
         Nombre = nombre;
         Precio = precio;
      }

      public override string ToString()
      {
         return $"{Nombre} - ${Precio}";
      }
   }
}