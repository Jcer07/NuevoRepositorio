using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_Almacen
    {
        public List<E_Almacen> ListadoAlmacen()
        {
            List<E_Almacen> listado;
            try
            {
                D_Almacen datos = new D_Almacen();
                listado = datos.ListadoAlmacen();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
