using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Departamento
    {
        private int _codigoDepartamento;
        private String _nombreDepartamento;

        public int CodigoDepartamento { get => _codigoDepartamento; set => _codigoDepartamento = value;}
        public String NombreDepartamento { get => _nombreDepartamento; set => _nombreDepartamento = value; }

        
    }
}
