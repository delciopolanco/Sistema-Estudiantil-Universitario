using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiantil_Universitario.Enums
{
    class Errores
    {
        public enum TipoErroresTxt
        {
            [Description("*Requerido")]
            Requerido,
            [Description("Incorrectos")]
            Incorrectos
        }
    }
}
