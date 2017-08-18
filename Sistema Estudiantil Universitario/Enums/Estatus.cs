
using System.ComponentModel;


namespace Sistema_Estudiantil_Universitario.Enums
{
    class Estatus
    {
        public enum TipoEstatus
        {

            [Description("Activo")]
            Activo = 1,
            [Description("Inactivo")]
            Inactivo = 2,
            [Description("Eliminado")]
            Eliminado = 3
        }

        public enum Resultado
        {
            OK,
            Error
        }
    }
}
