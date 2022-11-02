using Capa_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class N_MetodoPago
    {
        public List<E_MetodoPago> ListadoMetodosPago()
        {
            List<E_MetodoPago> listado;
            try
            {
                D_MetodoPago dMetodoPago = new D_MetodoPago();
                listado = dMetodoPago.listadoMetodosPago();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return listado;
        }
    }
}
