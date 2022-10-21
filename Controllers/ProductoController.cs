using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreEntrega.Models;
using System.Data.SqlClient;

namespace PreEntrega.Controllers
{
    public class ProductoController
    {
        public List<Producto> TraerProducto(int IdUsuario)
        {
            var listaProductos = new List<Producto>();

            SqlConnectionStringBuilder connectionbuilder = new();
            connectionbuilder.DataSource = "DESKTOP-H515FHI";
            connectionbuilder.InitialCatalog = "SistemaGestion";
            connectionbuilder.IntegratedSecurity = true;
            var cs = connectionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM producto WHERE IdUsuario = @idUsu";

                SqlParameter param = cmd.CreateParameter();
                param.ParameterName = "idUsu";
                param.Value = IdUsuario;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto prod = new Producto();

                    prod.Id = Convert.ToInt32(reader.GetValue(0));
                    prod.Descripciones = reader.GetValue(1).ToString();
                    prod.Costo = Convert.ToDouble(reader.GetValue(2));
                    prod.PrecioVenta = Convert.ToDouble(reader.GetValue(3));
                    prod.Stock = Convert.ToInt32(reader.GetValue(4));
                    prod.IdUsuario = Convert.ToInt32(reader.GetValue(5));

                    listaProductos.Add(prod);
                }

                reader.Close();
                connection.Close();
                
                foreach (var p in listaProductos)
                {
                    p.Mostrar();
                    Console.WriteLine("-----------------");
                }
            }
            return listaProductos;
        }
    }
}
