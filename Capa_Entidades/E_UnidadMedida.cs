using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class E_UnidadMedida
    {
        private int _codigoUnidad;
        private String _nombre;
        private String _siglas;
        private bool _vigente;

        #region Propiedades de Lectura y Escritura
        public int CodigoUnidad { get => _codigoUnidad; set => _codigoUnidad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Siglas { get => _siglas; set => _siglas = value; }
        public bool Vigente { get => _vigente; set => _vigente = value; }

        #endregion
    }
}
