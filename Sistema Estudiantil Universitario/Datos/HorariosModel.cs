using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Sistema_Estudiantil_Universitario.Datos
{
    class HorariosModel
    {
        protected readonly UniBDEntities Context;

        public HorariosModel()
        {
            Context = new UniBDEntities();
        }

        public IEnumerable<Horarios> Filtrar()
        {
            return Context.Set<Horarios>().ToList();
        }

        public IEnumerable<Horarios> Filtrar(string condicion)
        {
            return Context.Set<Horarios>().Where(p =>
                 p.Horario.Contains(condicion)).ToList();
        }

        public void Agregar(Horarios profesion)
        {
            using (var cx = new UniBDEntities())
            {
                Context.Set<Horarios>().Add(profesion);
                Context.SaveChanges();
            }
        }

        public bool Existe(string horario)
        {
            var phorario = this.Filtrar(horario);
            return phorario.Count() > 0 ? true : false;
        }
    }
}
