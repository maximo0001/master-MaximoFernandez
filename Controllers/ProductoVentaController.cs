using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreEntrega.Models;
using System.Data.SqlClient;

namespace PreEntrega.Controllers
{
    public class ProductoVentaController
    {
        public List<ProductoVenta> TraerProductosVendidos(int idUsuario)
        {
            
            var listaProductosVendidos = new List<ProductoVenta>();

            SqlConnectionStringBuilder connectionbuilder = new();
            connectionbuilder.DataSource = "DESKTOP-H515FHI";
            connectionbuilder.InitialCatalog = "SistemaGestion";
            connectionbuilder.IntegratedSecurity = true;
            var cs = connectionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select pv.* from ProductoVendido pv " +
                    "inner join producto p on p.id = pv.IdProducto and p.IdUsuario = @idUsu";
                
                SqlParameter param = cmd.CreateParameter();
                param.ParameterName = "idUsu";
                param.Value = idUsuario;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductoVenta prodVenta = new ProductoVenta();

                    prodVenta.Id = Convert.ToInt32(reader.GetValue(0));
                    prodVenta.Stock = Convert.ToInt32(reader.GetValue(1)); ;
                    prodVenta.IdProducto = Convert.ToInt32(reader.GetValue(2));
                    prodVenta.IdVenta = Convert.ToInt32(reader.GetValue(3));

                    listaProductosVendidos.Add(prodVenta);
                }

                foreach (var p in listaProductosVendidos)
                {
                    p.Mostrar();
                    Console.WriteLine("-------------");
                }
                reader.Close();
                connection.Close();

            }
            return listaProductosVendidos;
        }
    }
}
