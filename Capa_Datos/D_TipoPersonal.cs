using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Capa_Entidades;
using System.Data;

namespace Capa_Datos
{
    public class D_TipoPersonal
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void Registrar(E_TipoPersonal objTipoPersonal)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarTipoPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 0);
                        cmd.Parameters.AddWithValue("@codigoTipoPersonal", 0);
                        cmd.Parameters.AddWithValue("@nombreTipo", objTipoPersonal.NombreTipo);
                        cmd.Parameters.AddWithValue("@descripcion", objTipoPersonal.Descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_TipoPersonal objTipoPersonal)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarTipoPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        cmd.Parameters.AddWithValue("@codigoTipoPersonal", objTipoPersonal.CodigoTipoPersonal);
                        cmd.Parameters.AddWithValue("@nombreTipo", objTipoPersonal.NombreTipo);
                        cmd.Parameters.AddWithValue("@descripcion", objTipoPersonal.Descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DarBajaTipoPersonal(int codTipoPersonal)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_darBajaTipoPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoTipoPersonal", codTipoPersonal);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_TipoPersonal LeerTipoPersonal(int codTipoPersonal)
        {
            E_TipoPersonal obj = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_leerTipoPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoTipoPersonal", codTipoPersonal);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_TipoPersonal()
                                {
                                    CodigoTipoPersonal = codTipoPersonal,
                                    NombreTipo = dr.GetString(dr.GetOrdinal("NombreTipo")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return obj;
        }

        public List<E_TipoPersonal> ListadoTipoPersonal()
        {
            List<E_TipoPersonal> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoTipoPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 0);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_TipoPersonal>();
                            while (dr.Read())
                            {
                                listado.Add(new E_TipoPersonal()
                                {
                                    CodigoTipoPersonal = dr.GetByte(dr.GetOrdinal("CodigoTipoPersonal")),
                                    NombreTipo = dr.GetString(dr.GetOrdinal("NombreTipo")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return listado;
        }

        public List<E_TipoPersonal> ListadoTipoPersonalCbo()
        {
            List<E_TipoPersonal> listado = null;

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd  = new SqlCommand("sp_listadoTipoPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_TipoPersonal>();
                            while (dr.Read())
                            {
                                listado.Add(new E_TipoPersonal()
                                {
                                    CodigoTipoPersonal = dr.GetByte(dr.GetOrdinal("CodigoTipoPersonal")),
                                    NombreTipo = dr.GetString(dr.GetOrdinal("NombreTipo"))
                                });
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
    }
}
