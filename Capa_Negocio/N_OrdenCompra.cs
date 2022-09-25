using System;
using System.Collections.Generic;
using System.Data;
using Capa_Datos;
using Capa_Entidades;
namespace Capa_Negocio
{
    public class N_OrdenCompra
    {
        public void Registrar(DataTable listadoDetalle)
        {
            try
            {
                D_OrdenCompra datos = new D_OrdenCompra();
                datos.Registrar(listadoDetalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RegistrarCotizacion(E_OrdenCompra objOrdenCompra)
        {
            try
            {
                D_OrdenCompra datos = new D_OrdenCompra();
                datos.RegistrarCotizacion(objOrdenCompra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_OrdenCompra> Listado()
        {
            List<E_OrdenCompra> listado;
            try
            {
                D_OrdenCompra datos = new D_OrdenCompra();
                listado = datos.Listado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public List<E_Producto> ListadoDetalleCompra(int codigoCompra)
        {
            List<E_Producto> listado;
            try
            {
                D_OrdenCompra datos = new D_OrdenCompra();
                listado = datos.ListadoDetalleCompra(codigoCompra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public List<E_OrdenCompra> ListadoOrdenCompraBusqueda(String razonSocial)
        {
            List<E_OrdenCompra> listado;
            try
            {
                D_OrdenCompra datos = new D_OrdenCompra();
                listado = datos.ListadoOrdenCompraBusqueda(razonSocial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public E_OrdenCompra LeerOrdenCompra(int codigoOrdenCompra)
        {
            E_OrdenCompra obj;
            try
            {
                D_OrdenCompra datos = new D_OrdenCompra();
                obj = datos.LeerOrdenCompra(codigoOrdenCompra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }
    }
}
