using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_Usuario
    {
        #region Atributos privados
        private int _codigoUsuario;
        private String _nombreUsuario;
        private String _clave;
        private String _tipoUsuario;
        private String _siglasUsuario;
        private bool _vigente;
        private E_Personal _personal;
        #endregion

        #region Propiedades de Lectura y Escritura
        public int CodigoUsuario { get => _codigoUsuario; set => _codigoUsuario = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public string TipoUsuario { get => _tipoUsuario; set => _tipoUsuario = value; }
        public string SiglasUsuario { get => _siglasUsuario; set => _siglasUsuario = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }
        public E_Personal Personal { get => _personal; set => _personal = value; }
        #endregion

        #region Propiedades de solo lectura

        public String NombrePersonal
        {
            get
            {
                return _personal.NombresApellidos;
            }
        }

        #endregion
    }
}
