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
    public class D_Almacen
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public List<E_Almacen> ListadoAlmacen()
        {
            List<E_Almacen> listado = null;
            String query = $"select CodigoAlmacen, Descripcion from Almacen where Vigente = 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                listado = new List<E_Almacen>();
                                while (reader.Read())
                                {
                                    listado.Add(new E_Almacen()
                                    {
                                        CodigoAlmacen = reader.GetByte(reader.GetOrdinal("CodigoAlmacen")),
                                        Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"))
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
    }
}
