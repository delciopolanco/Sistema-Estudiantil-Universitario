
using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Estudiantil_Universitario.Datos
{
    public class UsuariosMetadata
    {

        public int Id { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaUltimoLogeo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "* Debe ser de 4 a 50 caracteres")]
        public string Usuario { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "* Debe ser de 4 a 50 caracteres")]
        public string Contraseña { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [EqualTo("Contraseña", ErrorMessage = "* Las contraseñas deben ser iguales")]
        public string ConfirmarContraseña { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [StringLength(50, ErrorMessage = "* No debe ser mayor a 100 caracteres")]
        [EmailAddress(ErrorMessage = "* No valido")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "* Requerido")]
        public int Estatus { get; set; }
    }

    public class ProfesionesMetadata
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "* Debe ser mayor a 0 meses ")]
        public string Profesion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "* Requerido")]
        [Min(1, ErrorMessage = "* Debe ser mayor a 0 meses ")]
        public decimal Duracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Docentes> Docentes { get; set; }
    }

}
