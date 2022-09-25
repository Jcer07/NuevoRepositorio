using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_UnidadMedida
    {
        public List<E_UnidadMedida> ListadoCbo()
        {
            List<E_UnidadMedida> listado;
            try
            {
                D_UnidadMedida und = new D_UnidadMedida();
                listado = und.ListadoCbo();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return listado;
        }
    }
}
