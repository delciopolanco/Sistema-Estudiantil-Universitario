using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiantil_Universitario.Datos
{
    class DocentesModel
    {
        protected readonly UniBDEntities Context;

        public DocentesModel()
        {
            Context = new UniBDEntities();
        }

        public IEnumerable<Docentes> Filtrar()
        {
            return Context.Set<Docentes>().ToList();
        }


        public IEnumerable<Docentes> Filtrar(string condicion)
        {
            return Context.Set<Docentes>().Where(p =>
                 p.Nombres.Contains(condicion) ||
                 p.Apellidos.Contains(condicion) ||
                 p.Identificacion.Contains(condicion) || 
                 p.Profesiones.Profesion.Contains(condicion)).ToList();
        }

        public void Agregar(Docentes docente)
        {
            using (var cx = new UniBDEntities())
            {
                cx.Set<Docentes>().Add(docente);
                docente.FechaCreacion = DateTime.Now;
                docente.Estatus = (int)Enums.Estatus.TipoEstatus.Activo;
                cx.SaveChanges();
            }

            var iDocente = Context.Docentes.Where(d => d.Id == docente.Id).FirstOrDefault();
            iDocente.Matricula = Helpers.Utilitario.ObtenerMatricula(docente.FechaCreacion, docente.CodigoProfesion, docente.Tanda, docente.TipoDocente, docente.Id);
            Context.SaveChanges();
        }

        public bool Existe(string identificacion)
        {
            var docente = this.Filtrar(identificacion);
            return docente.Count() > 0 ? true : false;
        }
    }
}
