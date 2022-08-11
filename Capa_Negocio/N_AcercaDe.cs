using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    public class N_AcercaDe
    {
        public E_AcercaDe GetEmpresa()
        {
            D_AcercaDe d = new D_AcercaDe();
            E_AcercaDe data = d.GetDatos();
            return data;
        }
    }
}
