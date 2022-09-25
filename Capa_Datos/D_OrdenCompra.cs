using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;
using System.Collections.Generic;

namespace Capa_Datos
{
    public class D_OrdenCompra
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void Registrar(DataTable listadoDetalle)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_insertaOrdenCompra", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@listadoDetalleCompra", SqlDbType.Structured).Value = listadoDetalle;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void RegistrarCotizacion(E_OrdenCompra objOrdenCompra)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_registrarCotizacionCompra", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoOrdenCompra", objOrdenCompra.CodigoOrdenCompra);
                        cmd.Parameters.AddWithValue("@fechaEntrega", objOrdenCompra.FechaEntrega);
                        cmd.Parameters.AddWithValue("@montoCotizacion", objOrdenCompra.MontoCotizacion);
                        cmd.Parameters.AddWithValue("@codigoProveedor", objOrdenCompra.CodigoProveedor);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<E_OrdenCompra> Listado()
        {
            List<E_OrdenCompra> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoOrdenesCompra", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_OrdenCompra>();
                            while (dr.Read())
                            {
                                listado.Add(new E_OrdenCompra()
                                {
                                    CodigoOrdenCompra = dr.GetInt32(dr.GetOrdinal("CodigoOrdenCompra")),
                                    FechaCompra = dr.GetDateTime(dr.GetOrdinal("FechaOrdenCompra")),
                                    CantProductos = dr.GetInt32(dr.GetOrdinal("CantidadProductos"))
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

        public List<E_Producto> ListadoDetalleCompra(int codigoCompra)
        {
            List<E_Producto> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listarDetalleOrdenCompra", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoOrdenCompra", codigoCompra);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Producto>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Producto()
                                {
                                    CodigoProducto = dr.GetInt32(dr.GetOrdinal("CodigoProducto")),
                                    Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                    StockActual = dr.GetInt32(dr.GetOrdinal("Cantidad"))
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

        public List<E_OrdenCompra> ListadoOrdenCompraBusqueda(String razonSocial)
        {
            List<E_OrdenCompra> listado = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoOrdenCompraBusqueda", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@razonSocial", razonSocial);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_OrdenCompra>();
                            while (dr.Read())
                            {
                                listado.Add(new E_OrdenCompra()
                                {
                                    CodigoOrdenCompra = dr.GetInt32(dr.GetOrdinal("CodigoOrdenCompra")),
                                    RazonSocialProveedor = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    FechaCompra = dr.GetDateTime(dr.GetOrdinal("FechaOrdenCompra")),
                                    CantProductos = dr.GetInt32(dr.GetOrdinal("CantidadProductos")),
                                    MontoCotizacion = (double)dr.GetDecimal(dr.GetOrdinal("MontoCotizacion"))
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

        public E_OrdenCompra LeerOrdenCompra(int codigoOrdenCompra)
        {
            E_OrdenCompra obj = null;
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_leerOrdenCompra", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoOrdenCompra", codigoOrdenCompra);

                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_OrdenCompra()
                                {
                                    CodigoOrdenCompra = dr.GetInt32(dr.GetOrdinal("CodigoOrdenCompra")),
                                    RazonSocialProveedor = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    MontoCotizacion = (double)dr.GetDecimal(dr.GetOrdinal("MontoCotizacion"))
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
    }
}
