using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Cliente
    {
        public void Registrar(E_Cliente objCliente)
        {
            try
            {
                D_Cliente d_Cliente = new D_Cliente();
                d_Cliente.Registrar(objCliente);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Cliente objCliente)
        {
            try
            {
                D_Cliente d_Cliente = new D_Cliente();
                d_Cliente.Actualizar(objCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Cliente LeerCliente(int codCliente)
        {
            E_Cliente obj;
            try
            {
                D_Cliente d_Cliente = new D_Cliente();
                obj = d_Cliente.LeerCliente(codCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<E_Cliente> Listado(String nombre)
        {
            List<E_Cliente> listado;
            try
            {
                D_Cliente d_Cliente = new D_Cliente();
                listado = d_Cliente.Listado(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public void DarBajaCliente(int codCliente)
        {
            try
            {
                D_Cliente d_Cliente = new D_Cliente();
                d_Cliente.DarBajaCliente(codCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Cliente BuscarCliente(String dniCliente)
        {
            E_Cliente obj;
            try
            {
                D_Cliente datos = new D_Cliente();
                obj = datos.BuscarCliente(dniCliente);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return obj;
        }
    }
}
