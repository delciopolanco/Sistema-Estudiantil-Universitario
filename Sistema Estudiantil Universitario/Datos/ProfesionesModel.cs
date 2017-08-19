using System;
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

            Context.Set<Profesiones>().Add(profesion);
            Context.SaveChanges();

            profesion.ProfesionesHorarios = profesion.Horarios.Select(ph => new ProfesionesHorarios()
            {
                IdHorario = ph.Id,
                IdProfesion = profesion.Id
            }).ToList();
            Context.SaveChanges();
        }

        public bool Existe(string profesion)
        {
            var pprofesion = this.Filtrar(profesion);
            return pprofesion.Count() > 0 ? true : false;
        }

        internal List<Horarios> ObtenerHorarios(int id)
        {
            var listaDeHorarios = (from profHo in Context.ProfesionesHorarios
                                   join Hor in Context.Horarios
                                   on profHo.IdHorario equals Hor.Id
                                   where profHo.IdProfesion == id
                                   select Hor

            ).ToList();

            return listaDeHorarios;
        }
    }
}
