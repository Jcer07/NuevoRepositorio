using System;
using System.Collections.Generic;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_Personal
    {
        public List<E_Personal> ListadoPersonal(String nombre)
        {
            List<E_Personal> listado;
            D_Personal datos;
            try
            {
                datos = new D_Personal();
                listado = datos.ListarPersonal(nombre);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public List<E_Personal> ListadoPersonalCbo()
        {
            List<E_Personal> listado = null;
            D_Personal datos;

            try
            {
                datos = new D_Personal();
                listado = datos.ListadoPersonalCbo();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }

        public void RegistrarPersonal(E_Personal objPersonal)
        {
            try
            {
                D_Personal datos = new D_Personal();
                datos.Registrar(objPersonal);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPersonal(E_Personal personal)
        {
            try
            {
                D_Personal datos = new D_Personal();
                datos.Actualizar(personal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Personal LeerPersonal(int codPersonal)
        {
            E_Personal personal;
            D_Personal datos;
            try
            {
                datos = new D_Personal();
                personal = datos.LeerPersonal(codPersonal);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return personal;
        }

        public void DarDeBaja(E_Personal p)
        {
            D_Personal datos;

            try
            {
                datos = new D_Personal();
                datos.DarBaja(p.CodigoPersonal);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public E_Personal RetornaPersonal(String Dni)
        {
            E_Personal personal;
            try
            {
                D_Personal datos = new D_Personal();
                personal = datos.RetornaPersonal(Dni);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return personal;
        }
    }
}
