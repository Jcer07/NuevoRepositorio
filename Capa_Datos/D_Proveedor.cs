using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;
using System.Runtime.Remoting.Messaging;

namespace Capa_Datos
{
    public class D_Proveedor
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void Registrar(E_Proveedor objProveedor)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_insertaProveedor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@numeroRuc", objProveedor.NumeroRuc);
                        cmd.Parameters.AddWithValue("@razonSocial", objProveedor.RazonSocial);
                        cmd.Parameters.AddWithValue("@telefono", objProveedor.Telefono);
                        cmd.Parameters.AddWithValue("@codigoDistrito", objProveedor.Distrito.CodigoDistrito);
                        cmd.Parameters.AddWithValue("@direccion", objProveedor.Direccion);
                        cmd.Parameters.AddWithValue("@sitioWeb", objProveedor.SitioWeb);
                        cmd.Parameters.AddWithValue("@correo", objProveedor.Correo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Proveedor objProveedor)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_modificaProveedor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigoProveedor", objProveedor.CodigoProveedor);
                        cmd.Parameters.AddWithValue("@numeroRuc", objProveedor.NumeroRuc);
                        cmd.Parameters.AddWithValue("@razonSocial", objProveedor.RazonSocial);
                        cmd.Parameters.AddWithValue("@telefono", objProveedor.Telefono);
                        cmd.Parameters.AddWithValue("@codigoDistrito", objProveedor.Distrito.CodigoDistrito);
                        cmd.Parameters.AddWithValue("@direccion", objProveedor.Direccion);
                        cmd.Parameters.AddWithValue("@sitioWeb", objProveedor.SitioWeb);
                        cmd.Parameters.AddWithValue("@correo", objProveedor.Correo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_Proveedor LeerProveedor(int codProveedor)
        {
            E_Proveedor obj = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_leerProveedor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoProveedor", codProveedor);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                obj = new E_Proveedor()
                                {
                                    CodigoProveedor = codProveedor,
                                    NumeroRuc = reader.GetString(reader.GetOrdinal("NumeroRuc")),
                                    RazonSocial = reader.GetString(reader.GetOrdinal("RazonSocial")),
                                    Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                                    Distrito = new E_Distrito()
                                    {
                                        CodigoDistrito = reader.GetInt32(reader.GetOrdinal("CodigoDistrito")),
                                    },
                                    Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
                                    SitioWeb = reader.GetString(reader.GetOrdinal("SitioWeb")),
                                    Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                    Vigente = reader.GetBoolean(reader.GetOrdinal("Vigente")),
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

        public List<E_Proveedor> Listado(String nombre)
        {
            List<E_Proveedor> listado = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoProveedores", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@razonSocial", nombre);

                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Proveedor>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Proveedor()
                                {
                                    CodigoProveedor = dr.GetInt32(dr.GetOrdinal("CodigoProveedor")),
                                    NumeroRuc = dr.GetString(dr.GetOrdinal("NumeroRuc")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Distrito = new E_Distrito()
                                    {
                                        CodigoDistrito = dr.GetInt32(dr.GetOrdinal("CodigoDistrito")),
                                        NombreDistrito = dr.GetString(dr.GetOrdinal("NombreDistrito"))
                                    },
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    SitioWeb = dr.GetString(dr.GetOrdinal("SitioWeb")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente")),
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

        public void DarBajaProveedor(int codProveedor)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_darBajaProveedor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigoProveedor", codProveedor);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public E_Proveedor BuscarProveedor(String rucProveedor)
        {
            E_Proveedor obj = null;

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_buscarProveedor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ruc", rucProveedor);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_Proveedor()
                                {
                                    CodigoProveedor = dr.GetInt32(dr.GetOrdinal("CodigoProveedor")),
                                    NumeroRuc = dr.GetString(dr.GetOrdinal("NumeroRuc")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"))
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

        public List<E_Proveedor> ListadoProveedoresBusqueda(String razonSocial)
        {
            List<E_Proveedor> listado = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoProveedoresBusqueda", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@razonSocial", razonSocial);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Proveedor>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Proveedor()
                                {
                                    CodigoProveedor = dr.GetInt32(dr.GetOrdinal("CodigoProveedor")),
                                    NumeroRuc = dr.GetString(dr.GetOrdinal("NumeroRuc")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    SitioWeb = dr.GetString(dr.GetOrdinal("SitioWeb"))
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
