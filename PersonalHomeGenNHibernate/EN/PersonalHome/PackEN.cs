
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class PackEN
        {
        /**
         *
         */

        private int idPack;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private String familia;

        /**
         *
         */

        private String descripción;

        /**
         *
         */

        private String color;

        /**
         *
         */

        private String codigo;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> variable;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPack;





        public virtual int IdPack { get { return idPack; } set { idPack = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual String Familia { get { return familia; } set { familia = value;  } }


        public virtual String Descripción { get { return descripción; } set { descripción = value;  } }


        public virtual String Color { get { return color; } set { color = value;  } }


        public virtual String Codigo { get { return codigo; } set { codigo = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> Variable { get { return variable; } set { variable = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> FamiliaPack { get { return familiaPack; } set { familiaPack = value;  } }



        public PackEN()
        {
        }



        public PackEN(int idPack, String nombre, String familia, String descripción, String color, String codigo, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> variable, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPack)
        {
                this.init (idPack, nombre, familia, descripción, color, codigo, variable, familiaPack);
        }


        public PackEN(PackEN pack)
        {
                this.init (pack.IdPack, pack.Nombre, pack.Familia, pack.Descripción, pack.Color, pack.Codigo, pack.Variable, pack.FamiliaPack);
        }

        private void init (int idPack, String nombre, String familia, String descripción, String color, String codigo, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> variable, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPack)
        {
                this.IdPack = idPack;


                this.Nombre = nombre;

                this.Familia = familia;

                this.Descripción = descripción;

                this.Color = color;

                this.Codigo = codigo;

                this.Variable = variable;

                this.FamiliaPack = familiaPack;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                PackEN t = obj as PackEN;
                if (t == null)
                        return false;
                if (IdPack.Equals (t.IdPack))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdPack ? 0 : this.IdPack.GetHashCode ());
                return hash;
        }
        }
}
