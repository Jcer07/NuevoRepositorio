using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Venta
    {
        #region "Variables privadas"
        private int _codigoVenta;
        private DateTime _fechaVenta;
        private double _montoVenta;
        private bool _entregado;
        private bool _vigente;
        private int _codigoCliente;
        private int _codigoMetodoPago;
        private int _codigoPersonal;
        #endregion

        #region "Propiedades de lectura y escritura"
        public int CodigoVenta { get => _codigoVenta; set => _codigoVenta = value; }
        public DateTime FechaVenta { get => _fechaVenta; set => _fechaVenta = value; }
        public double MontoVenta { get => _montoVenta; set => _montoVenta = value; }
        public bool Entregado { get => _entregado; set => _entregado = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        public int CodigoCliente { get => _codigoCliente; set => _codigoCliente = value; }
        public int CodigoMetodoPago { get => _codigoMetodoPago; set => _codigoMetodoPago = value; }
        public int CodigoPersonal { get => _codigoPersonal; set => _codigoPersonal = value; }
        #endregion
    }
}
