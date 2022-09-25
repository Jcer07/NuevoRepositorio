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
        public void Registrar(E_TipoPersonal objTipoPersonal)
        {
            try
            {
                D_TipoPersonal dTipoPersonal = new D_TipoPersonal();
                dTipoPersonal.Registrar(objTipoPersonal);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_TipoPersonal objTipoPersonal)
        {
            try
            {
                D_TipoPersonal dTipoPersonal = new D_TipoPersonal();
                dTipoPersonal.Actualizar(objTipoPersonal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_TipoPersonal LeerTipoPersonal(int codTipoPersonal)
        {
            E_TipoPersonal obj;
            try
            {
                D_TipoPersonal dTipoPersonal = new D_TipoPersonal();
                obj = dTipoPersonal.LeerTipoPersonal(codTipoPersonal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<E_TipoPersonal> ListadoTipoPersonal()
        {
            List<E_TipoPersonal> listado;
            try
            {
                D_TipoPersonal dTipoPersonal = new D_TipoPersonal();
                listado = dTipoPersonal.ListadoTipoPersonal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public void DarBajaTipoPersonal(int codTipoPersonal)
        {
            try
            {
                D_TipoPersonal dTipoPersonal = new D_TipoPersonal();
                dTipoPersonal.DarBajaTipoPersonal(codTipoPersonal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_TipoPersonal> ListadoTipoPersonalCbo()
        {
            List<E_TipoPersonal> listado;
            D_TipoPersonal datosTP;

            try
            {
                datosTP = new D_TipoPersonal();
                listado = datosTP.ListadoTipoPersonalCbo();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
