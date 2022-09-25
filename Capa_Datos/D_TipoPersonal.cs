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
    public class D_TipoPersonal
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public List<E_TipoPersonal> ListaTipoPersonalCbo()
        {
            List<E_TipoPersonal> listado = null;

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd  = new SqlCommand(query, con))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_TipoPersonal>();
                            while (dr.Read())
                            {
                                listado.Add(new E_TipoPersonal()
                                {
                                    CodigoTipoPersonal = dr.GetByte(dr.GetOrdinal("CodigoTipoPersonal")),
                                    NombreTipo = dr.GetString(dr.GetOrdinal("NombreTipo"))
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
    }
}
