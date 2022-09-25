using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_IngresoProducto
    {
        public void RegistrarIngreso(int codOrdenCompra, DataTable listadoDetalle)
        {
            try
            {
                D_IngresoProducto dIngreso = new D_IngresoProducto();
                dIngreso.RegistrarIngreso(codOrdenCompra, listadoDetalle);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
