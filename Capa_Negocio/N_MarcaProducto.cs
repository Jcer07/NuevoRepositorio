using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_MarcaProducto
    {
        public List<E_MarcaProducto> ListadoMarcas()
        {
            List<E_MarcaProducto> listado;
            D_MarcaProducto datos;

            try
            {
                datos = new D_MarcaProducto();
                listado = datos.GetListado();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
