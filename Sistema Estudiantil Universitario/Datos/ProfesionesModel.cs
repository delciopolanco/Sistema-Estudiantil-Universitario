using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace Sistema_Estudiantil_Universitario.Datos
{
    class ProfesionesModel
    {
        protected readonly UniBDEntities Context;

        public ProfesionesModel()
        {
            Context = new UniBDEntities();
        }

        public IEnumerable<Profesiones> Filtrar()
        {
            return Context.Set<Profesiones>().ToList();
        }

        public IEnumerable<Profesiones> Filtrar(string condicion)
        {
            return Context.Set<Profesiones>().Where(p =>
                 p.Profesion.Contains(condicion) ||
                 p.Codigo.Contains(condicion) ||
                 p.Duracion.ToString().Contains(condicion)).ToList();
        }

        public void Agregar(Profesiones profesion)
        {
            using (var cx = new UniBDEntities())
            {
                Context.Set<Profesiones>().Add(profesion);
                Context.SaveChanges();
            }
        }

        public bool Existe(string profesion)
        {
            var pprofesion = this.Filtrar(profesion);
            return pprofesion.Count() > 0 ? true: false;
        }
    }
}
