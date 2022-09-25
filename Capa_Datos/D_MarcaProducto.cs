using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;
using System.Runtime.InteropServices;

namespace Capa_Datos
{
    public class D_MarcaProducto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void Registrar(E_MarcaProducto objMarca)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_guardarMarcaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 0);
                        cmd.Parameters.AddWithValue("@codigoMarca", 0);
                        cmd.Parameters.AddWithValue("@nombreMarca", objMarca.NombreMarca);
                        cmd.Parameters.AddWithValue("@descripcion", objMarca.Descripcion);
                        cmd.Parameters.AddWithValue("@codigoCategoria", objMarca.CodigoCategoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_MarcaProducto objMarca)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarMarcaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        cmd.Parameters.AddWithValue("@codigoMarca", objMarca.CodigoMarca);
                        cmd.Parameters.AddWithValue("@nombreMarca", objMarca.NombreMarca);
                        cmd.Parameters.AddWithValue("@descripcion", objMarca.Descripcion);
                        cmd.Parameters.AddWithValue("@codigoCategoria", objMarca.CodigoCategoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_MarcaProducto LeerMarcaProducto(int codMarca)
        {
            E_MarcaProducto obj = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_leerMarcaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoMarca", codMarca);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_MarcaProducto()
                                {
                                    CodigoMarca = codMarca,
                                    NombreMarca = dr.GetString(dr.GetOrdinal("NombreMarca")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                                    CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria"))
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

        public List<E_MarcaProducto> ListadoMarcas(String nombre)
        {
            List<E_MarcaProducto> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoMarcaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 0);
                        cmd.Parameters.AddWithValue("@nombreMarca", nombre);
                        cmd.Parameters.AddWithValue("@codigoCategoria", 0);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_MarcaProducto>();
                            while (dr.Read())
                            {
                                listado.Add(new E_MarcaProducto()
                                {
                                    CodigoMarca = dr.GetInt16(dr.GetOrdinal("CodigoMarca")),
                                    NombreMarca = dr.GetString(dr.GetOrdinal("NombreMarca")),
                                    CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                    NombreCategoria = dr.GetString(dr.GetOrdinal("Nombre")),
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

        public void DarBajaMarca(int codMarca)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_darBajaMarcaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoMarca", codMarca);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<E_MarcaProducto> ListadoMarcasCbo(int codCategoria)
        {
            List<E_MarcaProducto> listado = null;
            
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoMarcaProducto", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        cmd.Parameters.AddWithValue("@nombreMarca", "");
                        cmd.Parameters.AddWithValue("@codigoCategoria", codCategoria);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_MarcaProducto>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_MarcaProducto()
                                    {
                                        CodigoMarca = dr.GetInt16(dr.GetOrdinal("CodigoMarca")),
                                        NombreMarca = dr.GetString(dr.GetOrdinal("NombreMarca"))
                                    });
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

            return listado;
        }
    }
}
