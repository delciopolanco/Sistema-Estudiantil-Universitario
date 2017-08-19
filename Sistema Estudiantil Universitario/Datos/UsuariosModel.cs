using Sistema_Estudiantil_Universitario.Datos;
using Sistema_Estudiantil_Universitario.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static Sistema_Estudiantil_Universitario.Enums.Estatus;

namespace Sistema_Estudiantil_Universitario.Datos
{
    public partial class UsuariosModel
    {
        protected readonly UniBDEntities Context;

        public UsuariosModel()
        {
            Context = new UniBDEntities();
        }


        public IEnumerable<Usuarios> Filtrar()
        {
            return Context.Set<Usuarios>().ToList();
        }

        public Usuarios Filtrar(string usuario, string clave)
        {
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(clave))
            {
                return null;
            }

            return Context.Set<Usuarios>().Where(u =>
                 u.Usuario == usuario.Trim() &&
                 u.Contraseña == clave.Trim()).FirstOrDefault(); ;
        }

        public Usuarios FiltrarPorUsuario(string usuario)
        {
            if (string.IsNullOrEmpty(usuario))
            {
                return null;
            }

            return Context.Set<Usuarios>().Where(u =>
                 u.Usuario == usuario).FirstOrDefault();
        }

        public IEnumerable<Usuarios> Filtrar(string condicion)
        {
            if (string.IsNullOrEmpty(condicion))
            {
                return null;
            }

            return Context.Set<Usuarios>().Where(u =>
                 u.Usuario.Contains(condicion) ||
                 u.CorreoElectronico.Contains(condicion)).ToList();
        }

        public Usuarios FiltrarPorCorreo(string correo)
        {
            if (string.IsNullOrEmpty(correo))
            {
                return null;
            }

            return Context.Set<Usuarios>().Where(u =>
                  u.CorreoElectronico == correo.Trim()).FirstOrDefault();
        }

        public void Agregar(Usuarios usuario)
        {

            using (var cx = new UniBDEntities())
            {
                usuario.Estatus = (int)TipoEstatus.Activo;
                usuario.FechaCreacion = DateTime.Now;
                cx.Set<Usuarios>().Add(usuario);
                cx.SaveChanges();
            }

        }

        public bool Existe(string usuario)
        {
            var lista =  Context.Set<Usuarios>().Where(u =>
                u.Usuario.Contains(usuario)).ToList();

            return lista.Count() > 0 ? true : false;
        }

        public bool Login(string usuario, string clave)
        {
            var pusuario = this.Filtrar(usuario, clave);
            bool existe = false;

            if (pusuario != null)
            {
                pusuario.FechaUltimoLogeo = DateTime.Now;
                pusuario.ConfirmarContraseña = pusuario.Contraseña;
                Context.SaveChanges();
                existe = true;
            }

            return existe;
        }

        internal bool ExisteCorreo(string correo)
        {
            var usuario = this.FiltrarPorCorreo(correo);
            return usuario != null ? true : false;
        }

        internal void SetearClaveTemporal(string correo, string contraseña)
        {
            var usuario = this.FiltrarPorCorreo(correo);
            if (usuario != null)
            {
                usuario.Contraseña = contraseña;
                usuario.ConfirmarContraseña = contraseña;
                Context.SaveChanges();
            }
        }

        internal void CambiarContraseña(string usuario, string contraseña)
        {
            var pusuario = this.FiltrarPorUsuario(usuario);
            if (pusuario != null)
            {
                pusuario.Contraseña = contraseña;
                pusuario.ConfirmarContraseña = contraseña;
                Context.SaveChanges();
            }
        }
    }
}
