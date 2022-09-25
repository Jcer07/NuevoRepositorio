using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_CategoriaProducto
    {
        public void Registrar(E_CategoriaProducto objCategoria)
        {
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                datos.Registrar(objCategoria);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_CategoriaProducto objCategoria)
        {
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                datos.Actualizar(objCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DarBajaCategoria(int codCategoria)
        {
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                datos.DarBajaCategoria(codCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_CategoriaProducto LeerCategoria(int codCategoria)
        {
            E_CategoriaProducto categoria;
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                categoria = datos.LeerCategoria(codCategoria);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return categoria;
        }

        public List<E_CategoriaProducto> ListadoCategorias()
        {
            List<E_CategoriaProducto> listado;
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                listado = datos.ListadoCategoria();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public List<E_CategoriaProducto> ListadoCategoriasCbo()
        {
            List<E_CategoriaProducto> listado;
            try
            {
                D_CategoriaProducto datos = new D_CategoriaProducto();
                listado = datos.ListadoCategoriasCbo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }
    }
}
