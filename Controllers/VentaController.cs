using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreEntrega.Models;
using System.Data.SqlClient;

namespace PreEntrega.Controllers
{
    public class VentaController
    {
        public List<Venta> TraerVentas(int IdUsuario)
        {
            var listaVentas = new List<Venta>();

            SqlConnectionStringBuilder connectionbuilder = new();
            connectionbuilder.DataSource = "DESKTOP-H515FHI";
            connectionbuilder.InitialCatalog = "SistemaGestion";
            connectionbuilder.IntegratedSecurity = true;
            var cs = connectionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM venta WHERE IdUsuario = @idUsu";

                SqlParameter param = cmd.CreateParameter();
                param.ParameterName = "idUsu";
                param.Value = IdUsuario;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var venta = new Venta();
                    venta.Id = Convert.ToInt32(reader.GetValue(0));
                    venta.Comentarios = reader.GetValue(1).ToString();
                    venta.IdUsuario = Convert.ToInt32(reader.GetValue(2));

                    listaVentas.Add(venta);
                }

                reader.Close();
                connection.Close();
                
                foreach (var venta in listaVentas)
                {
                    venta.Mostrar();
                    Console.WriteLine("-----------------");
                }    
                return listaVentas;
            }
        }
    }
}