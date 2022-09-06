using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_MarcaProducto
    {
        private int _codigoMarca;
        private String _nombreMarca;
        private String _descripcion;
        private bool _vigente;

        #region Propiedades de Lectura y Escritura
        public int CodigoMarca { get => _codigoMarca; set => _codigoMarca = value; }
        public string NombreMarca { get => _nombreMarca; set => _nombreMarca = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        #endregion
    }
}
