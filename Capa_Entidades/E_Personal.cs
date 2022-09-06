using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Personal
    {
        private int _codigoPersonal;
        private String _numeroDni;
        private String _nombres;
        private String _apellidos;
        private int _codigoDistrito;
        private String _direccion;
        private String _telefono;
        private String _correo;
        private int _edad;
        private bool _vigente;
        private E_TipoPersonal _tipoPersonal;
        private int _codigoAlmacen;

        public int CodigoPersonal { get => _codigoPersonal; set => _codigoPersonal = value; }
        public String NumeroDni { get => _numeroDni; set => _numeroDni = value; }
        public String Nombres { get => _nombres; set => _nombres = value; }
        public String Apellidos { get => _apellidos; set => _apellidos = value; }
        public int CodigoDistrito { get => _codigoDistrito; set => _codigoDistrito = value; }
        public String Direccion { get => _direccion; set => _direccion = value; }
        public String Telefono { get => _telefono; set => _telefono = value; }
        public String Correo { get => _correo; set => _correo = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        public E_TipoPersonal TipoPersonal { get => _tipoPersonal; set => _tipoPersonal = value; }
        public int CodigoAlmacen { get => _codigoAlmacen; set => _codigoAlmacen = value; }


        #region Propiedades de solo lectura
        public String NombresApellidos
        {
            get
            {
                return Nombres + " " + Apellidos;
            }
        }

        public String TiPersonal
        {
            get
            {
                return TipoPersonal.NombreTipo;
            }
        }
        #endregion
    }
}
