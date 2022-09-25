using System;
using System.Collections.Generic;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Producto
    {
        public void RegistrarProducto(E_Producto p)
        {
            D_Producto producto;
            try
            {
                producto = new D_Producto();
                producto.RegistrarProducto(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<E_Producto> ListarProductos(String nombre)
        {
            List<E_Producto> lista;
            try
            {
                D_Producto datos = new D_Producto();
                lista = datos.ListarProductos(nombre);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lista;
        }

        public void Actualizar(E_Producto objProducto)
        {
            try
            {
                D_Producto producto = new D_Producto();
                producto.Actualizar(objProducto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_Producto LeerProducto(int codProducto)
        {
            E_Producto producto;
            try
            {
                D_Producto datos = new D_Producto();
                producto = datos.LeerProducto(codProducto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return producto;
        }

        public void DarBajaProducto(int codProducto)
        {
            try
            {
                D_Producto datos = new D_Producto();
                datos.DarBaja(codProducto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public E_Producto BuscarProducto(int codProducto)
        {
            E_Producto obj;

            try
            {
                D_Producto datos = new D_Producto();
                obj = datos.BuscarProducto(codProducto);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return obj;
        }

        public List<E_Producto> ListadoProductosBusqueda(String nombre)
        {
            List<E_Producto> listado;
            try
            {
                D_Producto datos = new D_Producto();
                listado = datos.ListadoProductosBusqueda(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listado;
        }

        public List<E_Producto> ListadoProductosCompras(int codCategoria)
        {
            List<E_Producto> listado;
            try
            {
                D_Producto datos = new D_Producto();
                listado = datos.ListadoProductosCompras(codCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
