using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class D_Departamento
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public List<E_Departamento> ListaDepartamentos()
        {
            List<E_Departamento> listado = null;

            String query = "select * from Departamento";

            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<E_Departamento>();
                            while (dr.Read())
                            {
                                listado.Add(new E_Departamento()
                                {
                                    CodigoDepartamento = dr.GetByte(dr.GetOrdinal("CodigoDepartamento")),
                                    NombreDepartamento = dr.GetString(dr.GetOrdinal("NombreDepartamento"))
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
