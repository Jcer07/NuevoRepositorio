using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_TipoPersonal
    {
        private int _codigoTipoPersonal;
        private String _nombreTipo;
        private String _descripcion;
        private bool _vigente;

        public int CodigoTipoPersonal { get => _codigoTipoPersonal; set => _codigoTipoPersonal = value; }
        public String NombreTipo { get => _nombreTipo; set => _nombreTipo = value; }
        public String Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
    }
}
