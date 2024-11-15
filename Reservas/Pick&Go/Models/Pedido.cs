using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_Go.Models
{
   internal class Pedido
   {
      public int IdPedido { get; set; }
      public Cliente Cliente { get; set; }
      public List<(Comida comida, int cantidad)> Articulos { get; set; }
      public double Total { get; set; }

      public Pedido(int idPedido, Cliente cliente)
      {
         IdPedido = idPedido;
         Cliente = cliente;
         Articulos = new List<(Comida comida, int cantidad)>();
         Total = 0;
      }

      public void AgregarComida(Comida comida, int cantidad)
      {
         Articulos.Add((comida, cantidad));
         Total += comida.Precio * cantidad;
      }

      public string MostrarPedido()
      {
         string detalles = $"Pedido ID: {IdPedido}\nCliente: {Cliente.Nombre}\n";
         foreach (var item in Articulos)
         {
            detalles += $"{item.comida.Nombre} - {item.cantidad} x ${item.comida.Precio}\n";
         }
         detalles += $"Total: ${Total}\n";
         return detalles;
      }
   }
}