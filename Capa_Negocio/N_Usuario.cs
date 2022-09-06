using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_Usuario
    {
        public void Registrar(E_Usuario objUsuario)
        {
            try
            {
                D_Usuario datos = new D_Usuario();
                datos.Registrar(objUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Usuario objUsuario)
        {
            try
            {
                D_Usuario datos = new D_Usuario();
                datos.Actualizar(objUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DarDeBajaUsuario(int codUsuario)
        {
            try
            {
                D_Usuario datos = new D_Usuario();
                datos.DarDeBajaUsuario(codUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Usuario> ListarUsuarios(String usuario)
        {
            List<E_Usuario> listado;

            try
            {
                D_Usuario datos = new D_Usuario();
                listado = datos.ListadoUsuarios(usuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }

        public E_Usuario ObtenerUsuario(int codUsuario)
        {
            E_Usuario objUsuario;
            try
            {
                D_Usuario datos = new D_Usuario();
                objUsuario = datos.ObtenerUsuario(codUsuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return objUsuario;
        }
    }
}
