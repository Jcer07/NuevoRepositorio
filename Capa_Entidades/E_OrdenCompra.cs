using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_OrdenCompra
    {
        #region "Variables privadas"
        private int _codigoOrdenCompra;
        private DateTime _fechaCompra;
        private DateTime _fechaEntrega;
        private double _montoCotizacion;
        private bool _cotizada;
        private int _codigoProveedor;
        private bool _vigente;
        private int _cantProductos;
        private String _razonSocialProveedor;
        #endregion

        #region "Propiedades de lectura y Escritura"
        public int CodigoOrdenCompra { get => _codigoOrdenCompra; set => _codigoOrdenCompra = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public DateTime FechaEntrega { get => _fechaEntrega; set => _fechaEntrega = value; }
        public double MontoCotizacion { get => _montoCotizacion; set => _montoCotizacion = value; }
        public bool Cotizada { get => _cotizada; set => _cotizada = value; }
        public int CodigoProveedor { get => _codigoProveedor; set => _codigoProveedor = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        public int CantProductos { get => _cantProductos; set => _cantProductos = value; }
        public string RazonSocialProveedor { get => _razonSocialProveedor; set => _razonSocialProveedor = value; }
        #endregion
    }
}
