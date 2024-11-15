using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pick_Go.Models
{
    internal class Reporte
    {
        public string Titulo { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public string Descripcion { get; set; }
        public List<Pedido> PedidosIncluidos { get; set; }
        public int TotalPedidos { get; set; }
    }
}