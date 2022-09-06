using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_IniciarSesion
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public bool ValidarUsuario(String nombreUsuario, String clave)
        {
            bool existe = false;
            String query = $@"select U.CodigoUsuario, U.SiglasUsuario, P.CodigoPersonal, P.Nombres, P.Apellidos, A.CodigoAlmacen
	                            from Usuario as U
		                            join Personal as P on U.CodigoPersonal = P.CodigoPersonal
		                            join Almacen as A on P.CodigoAlmacen = A.CodigoAlmacen
	                            where U.Vigente = 1 and U.NombreUsuario = @usuario and Clave = @clave";
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@clave", clave);
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    existe = true;
                                    DatosLogin.CodigoUsuario = reader.GetInt32(reader.GetOrdinal("CodigoUsuario"));
                                    DatosLogin.TipoUsuario = reader.GetString(reader.GetOrdinal("SiglasUsuario"));
                                    DatosLogin.CodigoPersonal = reader.GetInt32(reader.GetOrdinal("CodigoPersonal"));
                                    DatosLogin.NombrePersonal = reader.GetString(reader.GetOrdinal("Nombres"));
                                    DatosLogin.ApellidoUsuario = reader.GetString(reader.GetOrdinal("Apellidos"));
                                    DatosLogin.CodigoAlmacen = reader.GetByte(reader.GetOrdinal("CodigoAlmacen"));
                                }
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return existe;
        }
    }
}
