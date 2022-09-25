using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Cliente
    {
        #region "Variables Privadas"

        private int _codigoCliente;
        private String _numeroDni;
        private String _nombres;
        private String _apellidos;
        private int _codigoDistrito;
        private String _direccion;
        private String _telefono;
        private String _correo;
        private bool _vigente;
        #endregion


        #region "Propiedades de Lectura y Escritura"
        public int CodigoCliente { get => _codigoCliente; set => _codigoCliente = value; }
        public string NumeroDni { get => _numeroDni; set => _numeroDni = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public int CodigoDistrito { get => _codigoDistrito; set => _codigoDistrito = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }

        #endregion

        #region "Propiedades de solo lectura"
        public String NombresApellidos
        {
            get
            {
                return _nombres + " " + _apellidos;
            }
        }
        #endregion
    }
}
