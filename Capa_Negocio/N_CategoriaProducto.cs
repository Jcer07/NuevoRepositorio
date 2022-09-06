using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_CategoriaProducto
    {
        public List<E_CategoriaProducto> ListadoCategorias()
        {
            List<E_CategoriaProducto> listado;
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                listado = datos.GetListado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }
    }
}
