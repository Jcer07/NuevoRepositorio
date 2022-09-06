using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_Distrito
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public List<E_Distrito> ListaDistritos(int cod)
        {
            String query = $"select * from Distrito where CodigoProvincia = {cod}";
            List<E_Distrito> listado = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Distrito>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Distrito()
                                {
                                    CodigoDistrito = dr.GetInt32(dr.GetOrdinal("CodigoDistrito")),
                                    NombreDistrito = dr.GetString(dr.GetOrdinal("NombreDistrito"))
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

        public int GetCodigoProvincia(int codDistrito)
        {
            int codigo = -1;
            String query = $"select CodigoProvincia from Distrito where CodigoDistrito = {codDistrito}";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                codigo = dr.GetInt32(dr.GetOrdinal("CodigoProvincia"));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return codigo;
        }
    }
}
