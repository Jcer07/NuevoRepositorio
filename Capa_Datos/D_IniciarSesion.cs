using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
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
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_Login", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
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
                                    DatosLogin.ApellidoPersonal = reader.GetString(reader.GetOrdinal("Apellidos"));
                                    DatosLogin.CodigoAlmacen = reader.GetByte(reader.GetOrdinal("CodigoAlmacen"));
                                    DatosLogin.DescripcionAlmacen = reader.GetString(reader.GetOrdinal("Descripcion"));
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
