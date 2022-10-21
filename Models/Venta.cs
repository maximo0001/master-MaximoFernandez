﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega.Models
{
    public class Venta
    {
        
        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public Venta()
        {
            Id = 0;
            Comentarios = String.Empty;
            IdUsuario = 0; 
        }

        public void Mostrar()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Comentarios: " + this.Comentarios);
            Console.WriteLine("IdUsuario: " + this.IdUsuario);
        }
    }

}
