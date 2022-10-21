using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega.Models
{
    public class ProductoVenta
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public ProductoVenta()
        {
            Id = 0;
            Stock = 0;
            IdProducto = 0;
            IdVenta = 0;
        }

        public void Mostrar()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Stock: " + this.Stock);
            Console.WriteLine("IdProducto: " + this.IdProducto);
            Console.WriteLine("IdVenta: " + this.IdVenta);
        }
    }
}
