using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Capa_Entidades;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class D_CategoriaProducto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        
        public void Registrar(E_CategoriaProducto objCategoria)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        cmd.Parameters.AddWithValue("@codigoCategoria", 0);
                        cmd.Parameters.AddWithValue("@nombreCategoria", objCategoria.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", objCategoria.Descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_CategoriaProducto objCategoria)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 0);
                        cmd.Parameters.AddWithValue("@codigoCategoria", objCategoria.CodigoCategoria);
                        cmd.Parameters.AddWithValue("@nombreCategoria", objCategoria.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", objCategoria.Descripcion);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DarBajaCategoria(int codCategoria)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_darBajaCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoCategoria", codCategoria);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_CategoriaProducto LeerCategoria(int codCategoria)
        {
            E_CategoriaProducto categoria = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_leerCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoCategoria", codCategoria);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                categoria = new E_CategoriaProducto()
                                {
                                    CodigoCategoria = codCategoria,
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"))
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

            return categoria;
        }

        public List<E_CategoriaProducto> ListadoCategoria()
        {
            List<E_CategoriaProducto> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 0);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_CategoriaProducto>();
                            while (dr.Read())
                            {
                                listado.Add(new E_CategoriaProducto()
                                {
                                    CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
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

        public List<E_CategoriaProducto> ListadoCategoriasCbo()
        {
            List<E_CategoriaProducto> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_listadoCategoriaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_CategoriaProducto>();
                            while (dr.Read())
                            {
                                listado.Add(new E_CategoriaProducto()
                                {
                                    CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
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
    }
}
