
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class VistaEN
        {
        /**
         *
         */

        private int idVista;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estancia;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> inmueble;





        public virtual int IdVista { get { return idVista; } set { idVista = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> Estancia { get { return estancia; } set { estancia = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> Inmueble { get { return inmueble; } set { inmueble = value;  } }



        public VistaEN()
        {
        }



        public VistaEN(int idVista, String nombre, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estancia, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> inmueble)
        {
                this.init (idVista, nombre, estancia, inmueble);
        }


        public VistaEN(VistaEN vista)
        {
                this.init (vista.IdVista, vista.Nombre, vista.Estancia, vista.Inmueble);
        }

        private void init (int idVista, String nombre, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estancia, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> inmueble)
        {
                this.IdVista = idVista;


                this.Nombre = nombre;

                this.Estancia = estancia;

                this.Inmueble = inmueble;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                VistaEN t = obj as VistaEN;
                if (t == null)
                        return false;
                if (IdVista.Equals (t.IdVista))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdVista ? 0 : this.IdVista.GetHashCode ());
                return hash;
        }
        }
}
