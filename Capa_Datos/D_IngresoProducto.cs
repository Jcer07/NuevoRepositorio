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
    public class D_IngresoProducto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void RegistrarIngreso(int codOrdenCompra, DataTable listadoDetalle)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_insertaIngresoProducto", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigoOrdenCompra", codOrdenCompra);
                        cmd.Parameters.AddWithValue("@codigoAlmacen", DatosLogin.CodigoAlmacen);
                        cmd.Parameters.AddWithValue("@listadoDetalleIngreso", SqlDbType.Structured).Value = listadoDetalle;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
