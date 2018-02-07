
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class ProyectoEN
        {
        /**
         *
         */

        private int idProyecto;

        /**
         *
         */

        private String variables;

        /**
         *
         */

        private PersonalHome.UsuarioEN usuario;





        public virtual int IdProyecto { get { return idProyecto; } set { idProyecto = value;  } }


        public virtual String Variables { get { return variables; } set { variables = value;  } }


        public virtual PersonalHome.UsuarioEN Usuario { get { return usuario; } set { usuario = value;  } }



        public ProyectoEN()
        {
        }



        public ProyectoEN(int idProyecto, String variables, PersonalHome.UsuarioEN usuario)
        {
                this.init (idProyecto, variables, usuario);
        }


        public ProyectoEN(ProyectoEN proyecto)
        {
                this.init (proyecto.IdProyecto, proyecto.Variables, proyecto.Usuario);
        }

        private void init (int idProyecto, String variables, PersonalHome.UsuarioEN usuario)
        {
                this.IdProyecto = idProyecto;


                this.Variables = variables;

                this.Usuario = usuario;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                ProyectoEN t = obj as ProyectoEN;
                if (t == null)
                        return false;
                if (IdProyecto.Equals (t.IdProyecto))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdProyecto ? 0 : this.IdProyecto.GetHashCode ());
                return hash;
        }
        }
}
