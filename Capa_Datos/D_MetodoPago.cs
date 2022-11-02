using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_MetodoPago
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public List<E_MetodoPago> listadoMetodosPago()
        {
            List<E_MetodoPago> listado = null;

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_listadoMetodoPago", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_MetodoPago>();
                            while (dr.Read())
                            {
                                listado.Add(new E_MetodoPago()
                                {
                                    CodigoMetodoPago = dr.GetInt32(dr.GetOrdinal("CodigoMetodoPago")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
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
