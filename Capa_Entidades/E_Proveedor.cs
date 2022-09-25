using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Proveedor
    {
        #region Variables Privadas
        private int _codigoProveedor;
        private String _numeroRuc;
        private String _razonSocial;
        private String _telefono;
        private E_Distrito _distrito;
        private String _direccion;
        private String _sitioWeb;
        private String _correo;
        private bool _vigente;
        #endregion


        #region Propiedades de Lectura y Escritura
        public int CodigoProveedor { get => _codigoProveedor; set => _codigoProveedor = value; }
        public string NumeroRuc { get => _numeroRuc; set => _numeroRuc = value; }
        public string RazonSocial { get => _razonSocial; set => _razonSocial = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public E_Distrito Distrito { get => _distrito; set => _distrito = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string SitioWeb { get => _sitioWeb; set => _sitioWeb = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }

        #endregion

        #region "Propiedades de solo Lectura"
        public String NombreDistrito
        {
            get
            {
                return _distrito.NombreDistrito;
            }
        }

        public int CodigoDistrito
        {
            get
            {
                return _distrito.CodigoDistrito;
            }
        }
        #endregion
    }
}
