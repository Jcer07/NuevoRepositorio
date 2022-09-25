using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_Proveedor
    {
        public void Registrar(E_Proveedor objProveedor)
        {
            try
            {
                D_Proveedor datos = new D_Proveedor();
                datos.Registrar(objProveedor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_Proveedor objProveedor)
        {
            try
            {
                D_Proveedor datos = new D_Proveedor();
                datos.Actualizar(objProveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Proveedor LeerProveedor(int codProveedor)
        {
            E_Proveedor obj;
            try
            {
                D_Proveedor datos = new D_Proveedor();
                obj = datos.LeerProveedor(codProveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj;
        }

        public List<E_Proveedor> Listado(String nombre)
        {
            List<E_Proveedor> listado;
            try
            {
                D_Proveedor datos = new D_Proveedor();
                listado = datos.Listado(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public void DarBajaProveedor(int codProveedor)
        {
            try
            {
                D_Proveedor datos = new D_Proveedor();
                datos.DarBajaProveedor(codProveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Proveedor BuscarProveedor(String ruc)
        {
            E_Proveedor obj;

            try
            {
                D_Proveedor datos = new D_Proveedor();
                obj = datos.BuscarProveedor(ruc);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<E_Proveedor> ListadoProveedoresBusqueda(String razonSocial)
        {
            List<E_Proveedor> listado;

            try
            {
                D_Proveedor datos = new D_Proveedor();
                listado = datos.ListadoProveedoresBusqueda(razonSocial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }
    }
}
