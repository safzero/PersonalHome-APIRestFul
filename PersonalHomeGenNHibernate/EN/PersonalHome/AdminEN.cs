
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class AdminEN
        {
        /**
         *
         */

        private int idAdmin;

        /**
         *
         */

        private String email;

        /**
         *
         */

        private String passwd;

        /**
         *
         */

        private String nombre;





        public virtual int IdAdmin { get { return idAdmin; } set { idAdmin = value;  } }


        public virtual String Email { get { return email; } set { email = value;  } }


        public virtual String Passwd { get { return passwd; } set { passwd = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }



        public AdminEN()
        {
        }



        public AdminEN(int idAdmin, String email, String passwd, String nombre)
        {
                this.init (idAdmin, email, passwd, nombre);
        }


        public AdminEN(AdminEN admin)
        {
                this.init (admin.IdAdmin, admin.Email, admin.Passwd, admin.Nombre);
        }

        private void init (int idAdmin, String email, String passwd, String nombre)
        {
                this.IdAdmin = idAdmin;


                this.Email = email;

                this.Passwd = passwd;

                this.Nombre = nombre;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                AdminEN t = obj as AdminEN;
                if (t == null)
                        return false;
                if (IdAdmin.Equals (t.IdAdmin))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdAdmin ? 0 : this.IdAdmin.GetHashCode ());
                return hash;
        }
        }
}
