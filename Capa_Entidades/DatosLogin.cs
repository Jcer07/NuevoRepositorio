using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public static class DatosLogin
    {
        private static int codigoUsuario;
        private static String tipoUsuario;
        private static String nombrePersonal;
        private static String apellidoPersonal;
        private static int codigoAlmacen;
        private static int codigoPersonal;
        private static String descripcionAlmacen;

        public static int CodigoUsuario { get => codigoUsuario; set => codigoUsuario = value; }
        public static string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public static string NombrePersonal { get => nombrePersonal; set => nombrePersonal = value; }
        public static string ApellidoPersonal { get => apellidoPersonal; set => apellidoPersonal = value; }
        public static int CodigoAlmacen { get => codigoAlmacen; set => codigoAlmacen = value; }
        public static int CodigoPersonal { get => codigoPersonal; set => codigoPersonal = value; }
        public static string DescripcionAlmacen { get => descripcionAlmacen; set => descripcionAlmacen = value; }
    }
}
