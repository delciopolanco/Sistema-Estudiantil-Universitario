using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Estudiantil_Universitario.Datos
{
    class AsignaturasModel
    {
        protected readonly UniBDEntities Context;

        public AsignaturasModel()
        {
            Context = new UniBDEntities();
        }

        internal IEnumerable<Asignaturas> Filtrar()
        {
            return Context.Set<Asignaturas>().ToList();
        }

        internal IEnumerable<Asignaturas> Filtrar(string condicion)
        {
            return Context.Set<Asignaturas>().Where(a => a.Asignatura.Contains(condicion)).ToList();
        }

        internal bool Existe(string asignatura)
        {
            var pasignatura = this.Filtrar(asignatura);
            return pasignatura.Count() > 0 ? true : false;
        }

        internal void Agregar(Asignaturas asignatura)
        {
            using (var bd = new UniBDEntities())
            {
                bd.Set<Asignaturas>().Add(asignatura);
                bd.SaveChanges();
            }
        }
    }
}
