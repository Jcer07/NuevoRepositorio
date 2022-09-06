using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_TipoPersonal
    {
        public List<E_TipoPersonal> ListadoTpCbo()
        {
            List<E_TipoPersonal> listado;
            D_TipoPersonal datosTP;

            try
            {
                datosTP = new D_TipoPersonal();
                listado = datosTP.ListaTipoPersonalCbo();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
