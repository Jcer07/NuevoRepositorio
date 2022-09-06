using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class D_Provincia
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public List<E_Provincia> ListaProvincias(int cod)
        {
            List<E_Provincia> listado = null;

            String query = $"select * from Provincia where CodigoDepartamento = {cod}";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Provincia>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Provincia()
                                {
                                    CodigoProvincia = dr.GetInt32(dr.GetOrdinal("CodigoProvincia")),
                                    NombreProvincia = dr.GetString(dr.GetOrdinal("NombreProvincia"))
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

        public int GetCodigoDepartamento(int codProvincia)
        {
            int codigo = -1;
            String query = $"select CodigoDepartamento from Provincia where CodigoProvincia = {codProvincia}";

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
                                codigo = dr.GetByte(dr.GetOrdinal("CodigoDepartamento"));
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return codigo;
        }
    }
}
