using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Capa_Entidades;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class D_CategoriaProducto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        public List<E_CategoriaProducto> GetListado()
        {
            List<E_CategoriaProducto> listado = null;
            String query = $"select CodigoCategoria, Nombre, Vigente from CategoriaProducto where Vigente = 1";
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_CategoriaProducto>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_CategoriaProducto()
                                    {
                                        CodigoCategoria = dr.GetInt32(dr.GetOrdinal("CodigoCategoria")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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
