using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_CategoriaProducto
    {
        private int _codigoCategoria;
        private String _nombre;
        private String _descripcion;
        private bool _vigente;

        #region Propiedades de Lectura y Escritura
        public int CodigoCategoria { get => _codigoCategoria; set => _codigoCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        #endregion
    }
}
