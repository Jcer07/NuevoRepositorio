using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_UbigeoPeru
    {
        public List<E_Departamento> ListadoDepartamentos()
        {
            D_Departamento departamentos = new D_Departamento();
            List<E_Departamento> listado = departamentos.ListaDepartamentos();

            return listado;
        }

        public List<E_Provincia> ListadoProvincias(int codDepartamento)
        {
            D_Provincia provincias = new D_Provincia();
            List<E_Provincia> listado = provincias.ListaProvincias(codDepartamento);

            return listado;
        }

        public List<E_Distrito> ListadoDistritos(int codProvincia)
        {
            D_Distrito distritos = null;
            List<E_Distrito> listado = null;
            try
            {
                distritos = new D_Distrito();
                listado = distritos.ListaDistritos(codProvincia);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return listado;
        }

        public int GetCodigoProvincia(int codDistrito)
        {
            D_Distrito distrito;
            int codigoProvincia = -1;

            try
            {
                distrito = new D_Distrito();
                codigoProvincia = distrito.GetCodigoProvincia(codDistrito);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return codigoProvincia;
        }

        public int GetCodigoDepartamento(int codProvincia)
        {
            D_Provincia provincia;
            int codigoDepartamento = -1;

            try
            {
                provincia = new D_Provincia();
                codigoDepartamento = provincia.GetCodigoDepartamento(codProvincia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return codigoDepartamento;
        }
    }
}
