using Capa_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class N_Venta
    {
        public void RegistrarVenta(E_Venta venta, DataTable listadoDetalle)
        {
            try
            {
                D_Venta dVenta = new D_Venta();
                dVenta.RegistrarVenta(venta, listadoDetalle);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
