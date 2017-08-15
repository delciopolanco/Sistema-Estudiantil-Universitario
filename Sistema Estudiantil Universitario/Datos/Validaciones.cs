using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiantil_Universitario.Datos
{
    public class Equal : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            return true;
        }
    }
}
