using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_Personal
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public List<E_Personal> ListarPersonal(String nombre)
        {
            List<E_Personal> listado = null;
            String query = $@"select p.CodigoPersonal, p.NumeroDni, p.Nombres, p.Apellidos, 
                                    p.CodigoDistrito, p.Direccion, p.Telefono, p.Correo, p.Edad, p.Vigente, 
                                    tp.CodigoTipoPersonal, tp.NombreTipo from Personal as p
                                inner join TipoPersonal as tp on tp.CodigoTipoPersonal = p.CodigoTipoPersonal
                                where p.Nombres like '{nombre}%' order by p.Nombres";
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Personal>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Personal()
                                {
                                    CodigoPersonal = dr.GetInt32(dr.GetOrdinal("CodigoPersonal")),
                                    NumeroDni = dr.GetString(dr.GetOrdinal("NumeroDni")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    CodigoDistrito = dr.GetInt32(dr.GetOrdinal("CodigoDistrito")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Edad = dr.GetInt32(dr.GetOrdinal("Edad")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente")),
                                    TipoPersonal = new E_TipoPersonal(){
                                        CodigoTipoPersonal = dr.GetByte(dr.GetOrdinal("CodigoTipoPersonal")),
                                        NombreTipo = dr.GetString(dr.GetOrdinal("NombreTipo"))
                                    }
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

        public List<E_Personal> ListadoPersonalCbo()
        {
            List<E_Personal> listado = null;
            String query = $"select CodigoPersonal, Nombres, Apellidos from Personal where Vigente = 1";

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_Personal>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_Personal()
                                    {
                                        CodigoPersonal = dr.GetInt32(dr.GetOrdinal("CodigoPersonal")),
                                        Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                        Apellidos = dr.GetString(dr.GetOrdinal("Apellidos"))
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

        public void Registrar(E_Personal objPersonal)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_insertaPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@numeroDni", objPersonal.NumeroDni));
                        cmd.Parameters.Add(new SqlParameter("@nombres", objPersonal.Nombres));
                        cmd.Parameters.Add(new SqlParameter("@apellidos", objPersonal.Apellidos));
                        cmd.Parameters.Add(new SqlParameter("@codigoDistrito", objPersonal.CodigoDistrito));
                        cmd.Parameters.Add(new SqlParameter("@direccion", objPersonal.Direccion));
                        cmd.Parameters.Add(new SqlParameter("@telefono", objPersonal.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@correo", objPersonal.Correo));
                        cmd.Parameters.Add(new SqlParameter("@edad", objPersonal.Edad));
                        cmd.Parameters.Add(new SqlParameter("@vigente", 1));
                        cmd.Parameters.Add(new SqlParameter("@codigoEmpresa", 1));
                        cmd.Parameters.Add(new SqlParameter("@codigoTipoPersonal", objPersonal.TipoPersonal.CodigoTipoPersonal));
                        cmd.Parameters.Add(new SqlParameter("@codigoAlmacen", objPersonal.CodigoAlmacen));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Personal objPersonal)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_modificaPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@codigoPersonal", objPersonal.CodigoPersonal));
                        cmd.Parameters.Add(new SqlParameter("@numeroDni", objPersonal.NumeroDni));
                        cmd.Parameters.Add(new SqlParameter("@nombres", objPersonal.Nombres));
                        cmd.Parameters.Add(new SqlParameter("@apellidos", objPersonal.Apellidos));
                        cmd.Parameters.Add(new SqlParameter("@codigoDistrito", objPersonal.CodigoDistrito));
                        cmd.Parameters.Add(new SqlParameter("@direccion", objPersonal.Direccion));
                        cmd.Parameters.Add(new SqlParameter("@telefono", objPersonal.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@correo", objPersonal.Correo));
                        cmd.Parameters.Add(new SqlParameter("@edad", objPersonal.Edad));
                        cmd.Parameters.Add(new SqlParameter("@vigente", 1));
                        cmd.Parameters.Add(new SqlParameter("@codigoTipoPersonal", objPersonal.TipoPersonal.CodigoTipoPersonal));
                        cmd.Parameters.Add(new SqlParameter("@codigoAlmacen", objPersonal.CodigoAlmacen));

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public E_Personal LeerPersonal(int codPersonal)
        {
            E_Personal datos = null;
            String query = $@"select * from Personal
								where CodigoPersonal = {codPersonal}";

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                datos = new E_Personal()
                                {
                                    CodigoPersonal = codPersonal,
                                    NumeroDni = dr.GetString(dr.GetOrdinal("NumeroDni")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    CodigoDistrito = dr.GetInt32(dr.GetOrdinal("CodigoDistrito")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Edad = dr.GetInt32(dr.GetOrdinal("Edad")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente")),
                                    TipoPersonal = new E_TipoPersonal()
                                    {
                                        CodigoTipoPersonal = dr.GetByte(dr.GetOrdinal("CodigoTipoPersonal")),
                                    },
                                    CodigoAlmacen = dr.GetByte(dr.GetOrdinal("CodigoAlmacen"))
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
            
            return datos;
        }

        public void DarBaja(int codPersonal)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_darBajaPersonal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@codigoPersonal", codPersonal);
                        cmd.Parameters.AddWithValue("@vigente", 0);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public E_Personal RetornaPersonal(String Dni)
        {
            E_Personal personal = null;
            String query = $@"select CodigoPersonal, Nombres, Apellidos, CodigoTipoPersonal
                        from Personal where NumeroDni = @dni";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dni", Dni);
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read()) {
                                    personal = new E_Personal()
                                    {
                                        CodigoPersonal = reader.GetInt32(reader.GetOrdinal("CodigoPersonal")),
                                        Nombres = reader.GetString(reader.GetOrdinal("Nombres")),
                                        Apellidos = reader.GetString(reader.GetOrdinal("Apellidos")),
                                        TipoPersonal = new E_TipoPersonal()
                                        {
                                            CodigoTipoPersonal = reader.GetByte(reader.GetOrdinal("CodigoTipoPersonal"))
                                        }
                                    };
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

            return personal;
        }
    }
}
