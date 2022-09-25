using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_UnidadMedida
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public List<E_UnidadMedida> ListadoCbo()
        {
            List<E_UnidadMedida> listado = null;
            String query = $"select * from UnidadMedida";

            using(SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            listado = new List<E_UnidadMedida>();
                            while (dr.Read())
                            {
                                listado.Add(new E_UnidadMedida()
                                {
                                    CodigoUnidad = dr.GetByte(dr.GetOrdinal("CodigoUnidadMedida")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
                                    Vigente = true
                                });
                            }
                        }
                    }
                }
            }
            return listado;
        }
    }
}
