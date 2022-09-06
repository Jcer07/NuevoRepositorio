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
    public class D_Producto
    {
        private readonly String cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public void RegistrarProducto(E_Producto p)
        {
            String query = $@"insert into Producto(NombreProducto, Descripcion, Precio, Vigente, CodigoMarca, CodigoCategoria)
                        values('{p.Nombre}', '{p.Descripcion}', {p.Precio}, 1, {p.CodigoMarca}, {p.Categoria.CodigoCategoria})";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Producto p)
        {

        }

        public void DarBaja(int codProducto)
        {

        }

        public List<E_Producto> ListarProductos(String nombre)
        {
            List<E_Producto> listado = null;
            String query = $@"select p.CodigoProducto, p.NombreProducto, cp.Nombre from Producto as p
		                            inner join CategoriaProducto as cp on cp.CodigoCategoria = p.CodigoCategoria
		                            where p.NombreProducto like '{nombre}%' order by p.NombreProducto";

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using(SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                listado = new List<E_Producto>();
                                while (dr.Read())
                                {
                                    listado.Add(new E_Producto()
                                    {
                                        CodigoProducto = dr.GetInt32(dr.GetOrdinal("CodigoProducto")),
                                        Nombre = dr.GetString(dr.GetOrdinal("NombreProducto")),
                                        Categoria = new E_CategoriaProducto()
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                        }
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
