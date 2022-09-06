using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Provincia
    {
        private int _codigoProvincia;
        private String _nombreProvincia;

        public int CodigoProvincia { get =>_codigoProvincia; set => _codigoProvincia = value; }
        public String NombreProvincia { get => _nombreProvincia; set => _nombreProvincia = value; }
    }
}
