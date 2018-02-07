

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGenNHibernate.CAD.PersonalHome;

namespace PersonalHomeGenNHibernate.CEN.PersonalHome
{
        public partial class UsuarioCEN
        {
        private IUsuarioCAD _IUsuarioCAD;

        public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
        {
                this._IUsuarioCAD = _IUsuarioCAD;
        }

        public int Crear (String p_nombre, String p_email, String p_telefono, String p_passwd)
        {
                UsuarioEN usuarioEN = null;
                int oid;

                //Initialized UsuarioEN
                usuarioEN = new UsuarioEN ();
                usuarioEN.Nombre = p_nombre;
                usuarioEN.Email = p_email;
                usuarioEN.Telefono = p_telefono;
                usuarioEN.Passwd = p_passwd;
                //Call to UsuarioCAD

                oid = _IUsuarioCAD.Crear (usuarioEN);
                return oid;
        }

        public void Modificar (int p_Usuario_OID, String p_nombre, String p_email, String p_telefono, String p_passwd)
        {
                UsuarioEN usuarioEN = null;

                //Initialized UsuarioEN
                usuarioEN = new UsuarioEN ();
                usuarioEN.IdUsuario = p_Usuario_OID;
                usuarioEN.Nombre = p_nombre;
                usuarioEN.Email = p_email;
                usuarioEN.Telefono = p_telefono;
                usuarioEN.Passwd = p_passwd;
                //Call to UsuarioCAD

                _IUsuarioCAD.Modificar (usuarioEN);
        }

        public void Eliminar (int idUsuario)
        {
                _IUsuarioCAD.Eliminar (
                        idUsuario

                        );
        }

        public UsuarioEN DamePorID (int idUsuario)
        {
                UsuarioEN usuarioEN = null;

                usuarioEN = _IUsuarioCAD.DamePorID (
                        idUsuario

                        );
                return usuarioEN;
        }

        public System.Collections.Generic.IList<UsuarioEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<UsuarioEN> list = null;

                list = _IUsuarioCAD.DameTodos (first, size);
                return list;
        }
        }
}
