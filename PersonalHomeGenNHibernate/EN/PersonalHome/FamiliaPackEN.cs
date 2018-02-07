
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class FamiliaPackEN
        {
        /**
         *
         */

        private int idFamPack;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private String codigo;

        /**
         *
         */

        private String color;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> pack;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstancia;





        public virtual int IdFamPack { get { return idFamPack; } set { idFamPack = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual String Codigo { get { return codigo; } set { codigo = value;  } }


        public virtual String Color { get { return color; } set { color = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> Pack { get { return pack; } set { pack = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> TipoEstancia { get { return tipoEstancia; } set { tipoEstancia = value;  } }



        public FamiliaPackEN()
        {
        }



        public FamiliaPackEN(int idFamPack, String nombre, String codigo, String color, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> pack, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstancia)
        {
                this.init (idFamPack, nombre, codigo, color, pack, tipoEstancia);
        }


        public FamiliaPackEN(FamiliaPackEN familiaPack)
        {
                this.init (familiaPack.IdFamPack, familiaPack.Nombre, familiaPack.Codigo, familiaPack.Color, familiaPack.Pack, familiaPack.TipoEstancia);
        }

        private void init (int idFamPack, String nombre, String codigo, String color, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> pack, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstancia)
        {
                this.IdFamPack = idFamPack;


                this.Nombre = nombre;

                this.Codigo = codigo;

                this.Color = color;

                this.Pack = pack;

                this.TipoEstancia = tipoEstancia;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                FamiliaPackEN t = obj as FamiliaPackEN;
                if (t == null)
                        return false;
                if (IdFamPack.Equals (t.IdFamPack))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdFamPack ? 0 : this.IdFamPack.GetHashCode ());
                return hash;
        }
        }
}
