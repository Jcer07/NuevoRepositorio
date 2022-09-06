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
    public class D_MarcaProducto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public List<E_MarcaProducto> GetListado()
        {
            List<E_MarcaProducto> listado = null;
            String query = $"select CodigoMarca, NombreMarca, Vigente from Marca where Vigente = 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_MarcaProducto>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_MarcaProducto()
                                    {
                                        CodigoMarca = dr.GetInt16(dr.GetOrdinal("CodigoMarca")),
                                        NombreMarca = dr.GetString(dr.GetOrdinal("NombreMarca")),
                                        Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                    });
                                }
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
