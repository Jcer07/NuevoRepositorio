using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Producto
    {
        private int _codigoProducto;
        private E_CategoriaProducto _categoria;
        private int _codigoMarca;
        private String _nombre;
        private String _descripcion;
        private double _precio;
        private bool _vigente;

        #region Propiedades de lectura y escritura
        public int CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public E_CategoriaProducto Categoria { get => _categoria; set => _categoria = value; }
        public int CodigoMarca { get => _codigoMarca; set => _codigoMarca = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        #endregion

        #region Propiedades de solo lectura
        public String NombreCategoria
        {
            get
            {
                String nombreCat = "";
                if(_categoria != null)
                {
                    nombreCat = _categoria.Nombre;
                }
                return nombreCat;
            }
        }
        #endregion
    }
}
