using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_IniciarSesion
    {
        public bool ValidaUsuario(String nombreUsuario, String clave)
        {
            bool existe;

            try
            {
                D_IniciarSesion login = new D_IniciarSesion();
                existe = login.ValidarUsuario(nombreUsuario, clave);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return existe;
        }
    }
}
