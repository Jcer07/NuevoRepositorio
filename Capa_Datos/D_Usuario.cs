using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_Usuario
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public List<E_Usuario> ListadoUsuarios(String usuario)
        {
            List<E_Usuario> listado = null;
            String query = $@"select U.CodigoUsuario, P.Nombres, P.Apellidos, U.NombreUsuario, U.TipoUsuario, U.SiglasUsuario, U.Vigente 
                                    from Usuario as U
	                                join Personal as P on U.CodigoPersonal = P.CodigoPersonal
	                            where U.NombreUsuario like '{usuario}%' order by P.Nombres";

            try
            {
                using(SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_Usuario>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_Usuario()
                                    {
                                        CodigoUsuario = dr.GetInt32(dr.GetOrdinal("CodigoUsuario")),
                                        Personal = new E_Personal()
                                        {
                                            Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                            Apellidos = dr.GetString(dr.GetOrdinal("Apellidos"))
                                        },
                                        NombreUsuario = dr.GetString(dr.GetOrdinal("NombreUsuario")),
                                        TipoUsuario = dr.GetString(dr.GetOrdinal("TipoUsuario")),
                                        SiglasUsuario = dr.GetString(dr.GetOrdinal("SiglasUsuario")),
                                        Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                    });
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

            return listado;
        }

        public E_Usuario ObtenerUsuario(int codUsuario)
        {
            E_Usuario objUsuario = null;

            try
            {
                String query = $@"select P.NumeroDni, P.Nombres, P.Apellidos, U.TipoUsuario, U.NombreUsuario, U.SiglasUsuario from Usuario as U
	                                    join Personal as P on U.CodigoPersonal = P.CodigoPersonal
	                                where U.CodigoUsuario = @codUsuario";

                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@codUsuario", codUsuario);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    objUsuario = new E_Usuario()
                                    {
                                        CodigoUsuario = codUsuario,
                                        Personal = new E_Personal()
                                        {
                                            NumeroDni = dr.GetString(dr.GetOrdinal("NumeroDni")),
                                            Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                            Apellidos = dr.GetString(dr.GetOrdinal("Apellidos"))
                                        },
                                        TipoUsuario = dr.GetString(dr.GetOrdinal("TipoUsuario")),
                                        NombreUsuario = dr.GetString(dr.GetOrdinal("NombreUsuario")),
                                        SiglasUsuario = dr.GetString(dr.GetOrdinal("SiglasUsuario"))
                                    };
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return objUsuario;
        }

        public void Registrar(E_Usuario objUsuario)
        {
            String query = $@"insert into Usuario(NombreUsuario, Clave, TipoUsuario, SiglasUsuario,
                        Vigente, CodigoPersonal) values(@nombreUsuario, @clave, @tipoUsuario, @siglasUsuario,
                        1, @codigoPersonal)";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombreUsuario", objUsuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@clave", objUsuario.Clave);
                        cmd.Parameters.AddWithValue("@tipoUsuario", objUsuario.TipoUsuario);
                        cmd.Parameters.AddWithValue("@siglasUsuario", objUsuario.SiglasUsuario);
                        cmd.Parameters.AddWithValue("@codigoPersonal", objUsuario.Personal.CodigoPersonal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Usuario objUsuario)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_modificaUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigoUsuario", objUsuario.CodigoUsuario);
                        cmd.Parameters.AddWithValue("@nombreUsuario", objUsuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@clave", objUsuario.Clave);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void DarDeBajaUsuario(int codUsuario)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_darBajaUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoUsuario", codUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
