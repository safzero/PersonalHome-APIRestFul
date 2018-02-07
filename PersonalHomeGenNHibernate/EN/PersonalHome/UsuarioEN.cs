
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class UsuarioEN
        {
        /**
         *
         */

        private int idUsuario;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private String email;

        /**
         *
         */

        private String telefono;

        /**
         *
         */

        private String passwd;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> proyecto;





        public virtual int IdUsuario { get { return idUsuario; } set { idUsuario = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual String Email { get { return email; } set { email = value;  } }


        public virtual String Telefono { get { return telefono; } set { telefono = value;  } }


        public virtual String Passwd { get { return passwd; } set { passwd = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> Proyecto { get { return proyecto; } set { proyecto = value;  } }



        public UsuarioEN()
        {
        }



        public UsuarioEN(int idUsuario, String nombre, String email, String telefono, String passwd, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> proyecto)
        {
                this.init (idUsuario, nombre, email, telefono, passwd, proyecto);
        }


        public UsuarioEN(UsuarioEN usuario)
        {
                this.init (usuario.IdUsuario, usuario.Nombre, usuario.Email, usuario.Telefono, usuario.Passwd, usuario.Proyecto);
        }

        private void init (int idUsuario, String nombre, String email, String telefono, String passwd, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> proyecto)
        {
                this.IdUsuario = idUsuario;


                this.Nombre = nombre;

                this.Email = email;

                this.Telefono = telefono;

                this.Passwd = passwd;

                this.Proyecto = proyecto;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                UsuarioEN t = obj as UsuarioEN;
                if (t == null)
                        return false;
                if (IdUsuario.Equals (t.IdUsuario))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdUsuario ? 0 : this.IdUsuario.GetHashCode ());
                return hash;
        }
        }
}
