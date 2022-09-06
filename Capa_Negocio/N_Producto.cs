using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Producto
    {
        public void RegistrarProducto(E_Producto p)
        {
            D_Producto producto;
            try
            {
                producto = new D_Producto();
                producto.RegistrarProducto(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Producto> ListarProductos(String nombre)
        {
            List<E_Producto> lista;
            try
            {
                D_Producto datos = new D_Producto();
                lista = datos.ListarProductos(nombre);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lista;
        }
    }
}
