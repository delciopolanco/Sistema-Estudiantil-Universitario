using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiantil_Universitario.Enums
{
    class MenuOpciones
    {
        public enum MANTENIMIENTOS
        {
            [Description("Maestro")]
            Maestro,
            [Description("Alumno")]
            Alumno,
            [Description("Seccion")]
            Seccion,
            [Description("Asignatura")]
            Asignatura,
            [Description("Horario")]
            Horario,
            [Description("Profesion")]
            Profesion
        }

        public enum Reportes
        {
            Maestro,
            Alumno,
            Seccion,
            Asignatura,
            Horario,
            Profesion
        }

        public enum Seguridad
        {
            [Description("Cambiar contraseña")]
            Cambiar_Contraseña,
            [Description("Nuevo Usuario")]
            Crear_Usuario
        }
    }

    public class Opcion
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }

    public static class EnumExtensions
    {

        // This extension method is broken out so you can use a similar pattern with 
        // other MetaData elements in the future. This is your base method for each.
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        // This method creates a specific call to the above method, requesting the
        // Description MetaData attribute.
        public static string ToName(this Enum value, string message = "")
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? message + " " + value.ToString() : message + " " + attribute.Description;
        }

        public static Opcion GetOpcion(this Enum value)
        {
            return new Opcion
            {
                Text = value.ToName(),
                Value = value.ToString()
            };
        }

    }
}
