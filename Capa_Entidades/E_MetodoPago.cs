using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_MetodoPago
    {
        #region "Variables privadas"
        private int _codigoMetodoPago;
        private String _nombre;
        private String _descripcion;
        private bool _vigente;
        #endregion

        #region "Propiedades de lectura y escritura"

        public int CodigoMetodoPago { get => _codigoMetodoPago; set => _codigoMetodoPago = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        #endregion
    }
}
