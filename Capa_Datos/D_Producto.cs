using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;
using System.Collections;

namespace Capa_Datos
{
    public class D_Producto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void RegistrarProducto(E_Producto objProducto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@opcion", 1);
                        cmd.Parameters.AddWithValue("@codigoProducto", 0);
                        cmd.Parameters.AddWithValue("@nombreProducto", objProducto.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", objProducto.Descripcion);
                        cmd.Parameters.AddWithValue("@stockMinimo", objProducto.StockMinimo);
                        cmd.Parameters.AddWithValue("@precio", objProducto.Precio);
                        cmd.Parameters.AddWithValue("@codigoMarca", objProducto.CodigoMarca);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Producto objProducto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_guardarProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@opcion", 0);
                        cmd.Parameters.AddWithValue("@codigoProducto", objProducto.CodigoProducto);
                        cmd.Parameters.AddWithValue("@nombreProducto", objProducto.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", objProducto.Descripcion);
                        cmd.Parameters.AddWithValue("@stockMinimo", objProducto.StockMinimo);
                        cmd.Parameters.AddWithValue("@precio", objProducto.Precio);
                        cmd.Parameters.AddWithValue("@codigoMarca", objProducto.CodigoMarca);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DarBaja(int codProducto)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_darBajaProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoProducto", codProducto);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public E_Producto LeerProducto(int codProducto)
        {
            E_Producto producto = null;
            String query = $@"select P.CodigoProducto, P.NombreProducto, P.Descripcion, P.Precio, 
                                    M.CodigoCategoria, P.CodigoMarca from Producto as P
                                        join Marca as M on P.CodigoMarca = M.CodigoMarca 
                                    where CodigoProducto = @codProducto";
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@codProducto", codProducto);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                producto = new E_Producto()
                                {
                                    CodigoProducto = codProducto,
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                                    Precio = (double)dr.GetDecimal(dr.GetOrdinal("Precio")),
                                    Categoria = new E_CategoriaProducto()
                                    {
                                        CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria"))
                                    },
                                    CodigoMarca = dr.GetInt16(dr.GetOrdinal("CodigoMarca"))
                                };
       
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return producto;
        }

        public List<E_Producto> ListarProductos(String nombreProducto)
        {
            List<E_Producto> listado = null;

            String query = $@"select P.CodigoProducto, P.NombreProducto, CP.Nombre, P.Precio, P.Vigente from Producto as P
                                        join Marca as M on P.CodigoMarca = M.CodigoMarca
	                                    join CategoriaProducto as CP on M.CodigoCategoria = CP.CodigoCategoria
	                                where P.NombreProducto like '{nombreProducto}%'";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        //cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_Producto>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_Producto()
                                    {
                                        CodigoProducto = dr.GetInt32(dr.GetOrdinal("CodigoProducto")),
                                        Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                        Categoria = new E_CategoriaProducto()
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                        },
                                        Precio = (double)dr.GetDecimal(dr.GetOrdinal("Precio")),
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

        public E_Producto BuscarProducto(int codProducto)
        {
            E_Producto obj = null;

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_buscarProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codProducto", codProducto);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_Producto()
                                {
                                    CodigoProducto = dr.GetInt32(dr.GetOrdinal("CodigoProducto")),
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                    Categoria = new E_CategoriaProducto()
                                    {
                                        CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                    },
                                    Precio = (double)dr.GetDecimal(dr.GetOrdinal("Precio"))
                                };
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<E_Producto> ListadoProductosBusqueda(String nombre)
        {
            List<E_Producto> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoProductosBusqueda ", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreProducto", nombre);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Producto>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Producto()
                                {
                                    CodigoProducto = dr.GetInt32(dr.GetOrdinal("CodigoProducto")),
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                    Categoria = new E_CategoriaProducto()
                                    {
                                        CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                    },
                                    Precio = (double)dr.GetDecimal(dr.GetOrdinal("Precio"))
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

        public List<E_Producto> ListadoProductosCompras(int codCategoria)
        {
            List<E_Producto> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoProductosFaltantes", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoAlmacen", DatosLogin.CodigoAlmacen);
                        cmd.Parameters.AddWithValue("@codigoCategoria", codCategoria);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Producto>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Producto()
                                {
                                    CodigoProducto = dr.GetInt32(dr.GetOrdinal("CodigoProducto")),
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                    Categoria = new E_CategoriaProducto()
                                    {
                                        CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                    },
                                    StockActual = dr.GetInt32(dr.GetOrdinal("Stock"))
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
