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
    public class D_Cliente
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public void Registrar(E_Cliente objCliente)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_insertaCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@numeroDni", objCliente.NumeroDni);
                        cmd.Parameters.AddWithValue("@nombres", objCliente.Nombres);
                        cmd.Parameters.AddWithValue("@apellidos", objCliente.Apellidos);
                        cmd.Parameters.AddWithValue("@codigoDistrito", objCliente.CodigoDistrito);
                        cmd.Parameters.AddWithValue("@direccion", objCliente.Direccion);
                        cmd.Parameters.AddWithValue("@telefono", objCliente.Telefono);
                        cmd.Parameters.AddWithValue("@correo", objCliente.Correo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Cliente objCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_modificaCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigoCliente", objCliente.CodigoCliente);
                        cmd.Parameters.AddWithValue("@numeroDni", objCliente.NumeroDni);
                        cmd.Parameters.AddWithValue("@nombres", objCliente.Nombres);
                        cmd.Parameters.AddWithValue("@apellidos", objCliente.Apellidos);
                        cmd.Parameters.AddWithValue("@codigoDistrito", objCliente.CodigoDistrito);
                        cmd.Parameters.AddWithValue("@direccion", objCliente.Direccion);
                        cmd.Parameters.AddWithValue("@telefono", objCliente.Telefono);
                        cmd.Parameters.AddWithValue("@correo", objCliente.Correo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_Cliente LeerCliente(int codCliente)
        {
            E_Cliente obj = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_leerCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoCliente", codCliente);
                        
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_Cliente()
                                {
                                    CodigoCliente = codCliente,
                                    NumeroDni = dr.GetString(dr.GetOrdinal("NumeroDni")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    CodigoDistrito = dr.GetInt32(dr.GetOrdinal("CodDistrito")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo"))
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

        public List<E_Cliente> Listado(String nombre)
        {
            List<E_Cliente> listado = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoClientes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombres", nombre);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Cliente>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Cliente()
                                {
                                    CodigoCliente = dr.GetInt32(dr.GetOrdinal("CodigoCliente")),
                                    NumeroDni = dr.GetString(dr.GetOrdinal("NumeroDni")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
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

        public void DarBajaCliente(int codCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_darBajaCliente", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoCliente", codCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_Cliente BuscarCliente(String dniCliente)
        {
            E_Cliente obj = null;

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_buscarCliente", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dniCliente", dniCliente);
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                obj = new E_Cliente()
                                {
                                    CodigoCliente = dr.GetInt32(dr.GetOrdinal("CodigoCliente")),
                                    NumeroDni = dr.GetString(dr.GetOrdinal("NumeroDni")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos"))
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
    }
}
