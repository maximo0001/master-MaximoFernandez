using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreEntrega.Models;
using System.Data.SqlClient;


namespace PreEntrega.Controllers
{
    public class UsuarioController
    {
        public Usuario TraerUsuario(string nombreDeUsuario) 
        {
            Usuario usu = new Usuario();
            SqlConnectionStringBuilder connectionbuilder = new();
            connectionbuilder.DataSource = "DESKTOP-H515FHI";
            connectionbuilder.InitialCatalog = "SistemaGestion";
            connectionbuilder.IntegratedSecurity = true;
            var cs = connectionbuilder.ConnectionString;

            using(SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario WHERE nombreUsuario = @usu";

                SqlParameter param = cmd.CreateParameter();
                param.ParameterName = "usu";
                param.Value = nombreDeUsuario;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usu.Id = Convert.ToInt32(reader.GetValue(0));
                    usu.Nombre = reader.GetValue(1).ToString();
                    usu.Apellido = reader.GetValue(2).ToString();
                    usu.NombreUsuario = reader.GetValue(3).ToString();
                    usu.Contraseña = reader.GetValue(4).ToString();
                    usu.Mail = reader.GetValue(5).ToString();
                }

                reader.Close();
                connection.Close();

                usu.Mostrar();
            }
            return usu;
        }

//   ------------------------------------------------------------
        
        public Usuario InicioDeSesion(string nombreDeUsuario, string pass)
        {
            Usuario usu = new Usuario();
            SqlConnectionStringBuilder connectionbuilder = new();
            connectionbuilder.DataSource = "DESKTOP-H515FHI";
            connectionbuilder.InitialCatalog = "SistemaGestion";
            connectionbuilder.IntegratedSecurity = true;
            var cs = connectionbuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario WHERE nombreUsuario = @usu AND Contraseña = @pass";

                SqlParameter param = cmd.CreateParameter();
                param.ParameterName = "usu";
                param.Value = nombreDeUsuario;
                cmd.Parameters.Add(param);

                SqlParameter param2 = cmd.CreateParameter();
                param2.ParameterName = "pass";
                param2.Value = pass;
                cmd.Parameters.Add(param2);

                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usu.Id = Convert.ToInt32(reader.GetValue(0));
                    usu.Nombre = reader.GetValue(1).ToString();
                    usu.Apellido = reader.GetValue(2).ToString();
                    usu.NombreUsuario = reader.GetValue(3).ToString();
                    usu.Contraseña = reader.GetValue(4).ToString();
                    usu.Mail = reader.GetValue(5).ToString();
                }

                reader.Close();
                connection.Close();

                usu.Mostrar();
            }
            return usu;
        }
    }
}
