﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega.Models
{
    public class Usuario
    { 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }

        public Usuario()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;
            Mail = string.Empty;
        }

        public void Mostrar()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Nombre: " + this.Nombre);
            Console.WriteLine("Apellido: " + this.Apellido);
            Console.WriteLine("NombreUsuario: " + this.NombreUsuario);
            Console.WriteLine("Contraseña: " + this.Contraseña);
            Console.WriteLine("Mail: " + this.Mail);
        }
    }
}
