using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sistema_Estudiantil_Universitario.Enums.TipoDocentes;

namespace Sistema_Estudiantil_Universitario.Datos
{
    class DocentesModel
    {
        protected readonly UniBDEntities Context;

        public DocentesModel()
        {
            Context = new UniBDEntities();
        }

        public IEnumerable<Docentes> Filtrar(TipoDocente tipoDocente)
        {
            return Context.Set<Docentes>().Where(p =>
                 p.TipoDocente == (int)tipoDocente).ToList();
        }


        public IEnumerable<Docentes> Filtrar(string condicion, TipoDocente tipoDocente)
        {
            return Context.Set<Docentes>().Where(p =>
                 p.Nombres.Contains(condicion) ||
                 p.Apellidos.Contains(condicion) ||
                 p.Identificacion.Contains(condicion) || 
                 p.Profesiones.Profesion.Contains(condicion) ||
                 p.Matricula.Contains(condicion)).ToList();
        }

        public void Agregar(Docentes docente)
        {
            using (var bd = new UniBDEntities())
            {
                bd.Set<Docentes>().Add(docente);
                docente.FechaCreacion = DateTime.Now;
                docente.Estatus = (int)Enums.Estatus.TipoEstatus.Activo;
                bd.SaveChanges();

                var iDocente = bd.Docentes.Where(d => d.Id == docente.Id).FirstOrDefault();
                iDocente.Matricula = Helpers.Utilitario.ObtenerMatricula(docente.FechaCreacion, docente.CodigoProfesion, docente.Tanda, docente.TipoDocente, docente.Id);
                bd.Entry(docente).State = EntityState.Modified;
                bd.SaveChanges();
            }
        }

        public bool Existe(string identificacion, TipoDocente tipoDocente)
        {
            var docente = this.Filtrar(identificacion, tipoDocente);
            return docente.Count() > 0 ? true : false;
        }
    }
}
