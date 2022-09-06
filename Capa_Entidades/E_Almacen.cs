using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Almacen
    {
        private int _codigoAlmacen;
        private String _descripcion;
        private int _codigoDistrito;
        private String _direccion;
        private bool _vigente;

        #region Propiedades de Lectura y Escritura
        public int CodigoAlmacen { get => _codigoAlmacen; set => _codigoAlmacen = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int CodigoDistrito { get => _codigoDistrito; set => _codigoDistrito = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        #endregion
    }
}
