
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class VariableEN
        {
        /**
         *
         */

        private int idVariable;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private String caracteristicas;

        /**
         *
         */

        private double precio;

        /**
         *
         */

        private String imagen;

        /**
         *
         */

        private int iva;

        /**
         *
         */

        private String miniatura;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> pack;





        public virtual int IdVariable { get { return idVariable; } set { idVariable = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual String Caracteristicas { get { return caracteristicas; } set { caracteristicas = value;  } }


        public virtual double Precio { get { return precio; } set { precio = value;  } }


        public virtual String Imagen { get { return imagen; } set { imagen = value;  } }


        public virtual int Iva { get { return iva; } set { iva = value;  } }


        public virtual String Miniatura { get { return miniatura; } set { miniatura = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> Pack { get { return pack; } set { pack = value;  } }



        public VariableEN()
        {
        }



        public VariableEN(int idVariable, String nombre, String caracteristicas, double precio, String imagen, int iva, String miniatura, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> pack)
        {
                this.init (idVariable, nombre, caracteristicas, precio, imagen, iva, miniatura, pack);
        }


        public VariableEN(VariableEN variable)
        {
                this.init (variable.IdVariable, variable.Nombre, variable.Caracteristicas, variable.Precio, variable.Imagen, variable.Iva, variable.Miniatura, variable.Pack);
        }

        private void init (int idVariable, String nombre, String caracteristicas, double precio, String imagen, int iva, String miniatura, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> pack)
        {
                this.IdVariable = idVariable;


                this.Nombre = nombre;

                this.Caracteristicas = caracteristicas;

                this.Precio = precio;

                this.Imagen = imagen;

                this.Iva = iva;

                this.Miniatura = miniatura;

                this.Pack = pack;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                VariableEN t = obj as VariableEN;
                if (t == null)
                        return false;
                if (IdVariable.Equals (t.IdVariable))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdVariable ? 0 : this.IdVariable.GetHashCode ());
                return hash;
        }
        }
}
