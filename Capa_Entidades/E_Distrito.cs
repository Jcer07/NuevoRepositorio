using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Distrito
    {
        private int _codigoDistrito;
        private String _nombreDistrito;

        public int CodigoDistrito { get => _codigoDistrito; set => _codigoDistrito = value; }
        public String NombreDistrito { get => _nombreDistrito;  set => _nombreDistrito = value; }

    }
}
