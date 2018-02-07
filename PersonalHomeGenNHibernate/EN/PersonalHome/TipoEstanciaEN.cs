
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class TipoEstanciaEN
        {
        /**
         *
         */

        private int idTipoEstancia;

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

        private String imagen;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPack;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estancia;





        public virtual int IdTipoEstancia { get { return idTipoEstancia; } set { idTipoEstancia = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual String Descripcion { get { return descripcion; } set { descripcion = value;  } }


        public virtual String Imagen { get { return imagen; } set { imagen = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> FamiliaPack { get { return familiaPack; } set { familiaPack = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> Estancia { get { return estancia; } set { estancia = value;  } }



        public TipoEstanciaEN()
        {
        }



        public TipoEstanciaEN(int idTipoEstancia, String nombre, String descripcion, String imagen, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPack, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estancia)
        {
                this.init (idTipoEstancia, nombre, descripcion, imagen, familiaPack, estancia);
        }


        public TipoEstanciaEN(TipoEstanciaEN tipoEstancia)
        {
                this.init (tipoEstancia.IdTipoEstancia, tipoEstancia.Nombre, tipoEstancia.Descripcion, tipoEstancia.Imagen, tipoEstancia.FamiliaPack, tipoEstancia.Estancia);
        }

        private void init (int idTipoEstancia, String nombre, String descripcion, String imagen, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPack, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estancia)
        {
                this.IdTipoEstancia = idTipoEstancia;


                this.Nombre = nombre;

                this.Descripcion = descripcion;

                this.Imagen = imagen;

                this.FamiliaPack = familiaPack;

                this.Estancia = estancia;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                TipoEstanciaEN t = obj as TipoEstanciaEN;
                if (t == null)
                        return false;
                if (IdTipoEstancia.Equals (t.IdTipoEstancia))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdTipoEstancia ? 0 : this.IdTipoEstancia.GetHashCode ());
                return hash;
        }
        }
}
