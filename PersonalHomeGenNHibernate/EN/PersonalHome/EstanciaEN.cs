
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class EstanciaEN
        {
        /**
         *
         */

        private int idEstancia;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private String descripcion;

        /**
         *
         */

        private String codigo;

        /**
         *
         */

        private String plano;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstancia;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vista;





        public virtual int IdEstancia { get { return idEstancia; } set { idEstancia = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual String Descripcion { get { return descripcion; } set { descripcion = value;  } }


        public virtual String Codigo { get { return codigo; } set { codigo = value;  } }


        public virtual String Plano { get { return plano; } set { plano = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> TipoEstancia { get { return tipoEstancia; } set { tipoEstancia = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> Vista { get { return vista; } set { vista = value;  } }



        public EstanciaEN()
        {
        }



        public EstanciaEN(int idEstancia, String nombre, String descripcion, String codigo, String plano, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstancia, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vista)
        {
                this.init (idEstancia, nombre, descripcion, codigo, plano, tipoEstancia, vista);
        }


        public EstanciaEN(EstanciaEN estancia)
        {
                this.init (estancia.IdEstancia, estancia.Nombre, estancia.Descripcion, estancia.Codigo, estancia.Plano, estancia.TipoEstancia, estancia.Vista);
        }

        private void init (int idEstancia, String nombre, String descripcion, String codigo, String plano, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstancia, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vista)
        {
                this.IdEstancia = idEstancia;


                this.Nombre = nombre;

                this.Descripcion = descripcion;

                this.Codigo = codigo;

                this.Plano = plano;

                this.TipoEstancia = tipoEstancia;

                this.Vista = vista;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                EstanciaEN t = obj as EstanciaEN;
                if (t == null)
                        return false;
                if (IdEstancia.Equals (t.IdEstancia))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdEstancia ? 0 : this.IdEstancia.GetHashCode ());
                return hash;
        }
        }
}
