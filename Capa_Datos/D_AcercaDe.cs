using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Capa_Datos
{
    public class D_AcercaDe
    {
        //private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        
        public E_AcercaDe GetDatos()
        {
            E_AcercaDe empresa = null;

            String query = $@"select * from Empresa where CodigoEmpresa = 1";

            try
            {
                using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    empresa = new E_AcercaDe()
                                    {
                                        CodigoEmpresa = dr.GetByte(dr.GetOrdinal("CodigoEmpresa")),
                                        NumeroRuc = dr.GetString(dr.GetOrdinal("NumeroRuc")),
                                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                        Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                        Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                        Correo = dr.GetString(dr.GetOrdinal("Correo"))
                                    };
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

            return empresa;
        }
    }
}
