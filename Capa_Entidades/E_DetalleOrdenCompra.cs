using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_DetalleOrdenCompra
    {
        #region "Variables privadas"
        private int _codigoOrdenCompra;
        private int _codigoProducto;
        private int cantidad;
        #endregion


        #region "Propiedades de Lectura y Escritura"
        public int CodigoOrdenCompra { get => _codigoOrdenCompra; set => _codigoOrdenCompra = value; }
        public int CodigoProducto { get => _codigoProducto; set => _codigoProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        #endregion
    }
}
