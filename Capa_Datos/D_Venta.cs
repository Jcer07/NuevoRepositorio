using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidades;

namespace Capa_Datos
{
    public class D_Venta
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void RegistrarVenta(E_Venta venta, DataTable listadoDetalle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_registraVenta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@montoVenta", venta.MontoVenta);
                        cmd.Parameters.AddWithValue("@codigoCliente", venta.CodigoCliente);
                        cmd.Parameters.AddWithValue("@codigoMetodoPago", venta.CodigoMetodoPago);
                        cmd.Parameters.AddWithValue("@codigoPersonal", venta.CodigoPersonal);
                        cmd.Parameters.AddWithValue("@codigoAlmacen", DatosLogin.CodigoAlmacen);
                        cmd.Parameters.AddWithValue("@detalleVenta", SqlDbType.Structured).Value = listadoDetalle;

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
