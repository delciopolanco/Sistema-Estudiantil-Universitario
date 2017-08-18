using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiantil_Universitario.Enums
{
    class TipoDocentes
    {
        public enum TipoDocente
        {

            [Description("Estudiante")]
            Estudiante = 1,
            [Description("Maestro")]
            Maestro = 2
        }

        public enum Sexo
        {
            [Description("Femenino")]
            Femenino = 1,
            [Description("Masculino")]
            Masculino = 2
        }
    }
}
