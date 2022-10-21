using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PreEntrega.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }


        public Producto() 
        {
            Id = 0;
            Descripciones = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
            IdUsuario = 0;
        }

        public void Mostrar()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Descripciones: " + this.Descripciones);
            Console.WriteLine("Costo: " + this.Costo);
            Console.WriteLine("PrecioVenta: " + this.PrecioVenta);
            Console.WriteLine("Stock: " + this.Stock);
            Console.WriteLine("IdUsuario: " + this.IdUsuario);
        }
    }


}
