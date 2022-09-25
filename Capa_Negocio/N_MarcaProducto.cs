using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_MarcaProducto
    {
        public void Registrar(E_MarcaProducto objMarca)
        {
            try
            {
                D_MarcaProducto dMarca = new D_MarcaProducto();
                dMarca.Registrar(objMarca);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(E_MarcaProducto objMarca)
        {
            try
            {
                D_MarcaProducto dMarca = new D_MarcaProducto();
                dMarca.Actualizar(objMarca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public E_MarcaProducto LeerMarcaProducto(int codMarca)
        {
            E_MarcaProducto obj;
            try
            {
                D_MarcaProducto dMarca = new D_MarcaProducto();
                obj = dMarca.LeerMarcaProducto(codMarca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<E_MarcaProducto> ListadoMarcas(String nombre)
        {
            List<E_MarcaProducto> listado;
            try
            {
                D_MarcaProducto dMarca = new D_MarcaProducto();
                listado = dMarca.ListadoMarcas(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listado;
        }

        public void DarBajaMarca(int codMarca)
        {
            try
            {
                D_MarcaProducto dMarca = new D_MarcaProducto();
                dMarca.DarBajaMarca(codMarca);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<E_MarcaProducto> ListadoMarcasCbo(int codCategoria)
        {
            List<E_MarcaProducto> listado;
            D_MarcaProducto datos;

            try
            {
                datos = new D_MarcaProducto();
                listado = datos.ListadoMarcasCbo(codCategoria);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
