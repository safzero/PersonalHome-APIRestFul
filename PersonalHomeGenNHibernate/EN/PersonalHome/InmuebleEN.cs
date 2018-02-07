
using System;

namespace PersonalHomeGenNHibernate.EN.PersonalHome
{
        public class InmuebleEN
        {
        /**
         *
         */

        private int idInmueble;

        /**
         *
         */

        private String nombre;

        /**
         *
         */

        private double superficie;

        /**
         *
         */

        private int dormitorios;

        /**
         *
         */

        private int aseos;

        /**
         *
         */

        private double importeDesde;

        /**
         *
         */

        private double iva;

        /**
         *
         */

        private String imagen;

        /**
         *
         */

        private String plano;

        /**
         *
         */

        private System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vista;

        /**
         *
         */

        private bool recomendado;





        public virtual int IdInmueble { get { return idInmueble; } set { idInmueble = value;  } }


        public virtual String Nombre { get { return nombre; } set { nombre = value;  } }


        public virtual double Superficie { get { return superficie; } set { superficie = value;  } }


        public virtual int Dormitorios { get { return dormitorios; } set { dormitorios = value;  } }


        public virtual int Aseos { get { return aseos; } set { aseos = value;  } }


        public virtual double ImporteDesde { get { return importeDesde; } set { importeDesde = value;  } }


        public virtual double Iva { get { return iva; } set { iva = value;  } }


        public virtual String Imagen { get { return imagen; } set { imagen = value;  } }


        public virtual String Plano { get { return plano; } set { plano = value;  } }


        public virtual System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> Vista { get { return vista; } set { vista = value;  } }


        public virtual bool Recomendado { get { return recomendado; } set { recomendado = value;  } }



        public InmuebleEN()
        {
        }



        public InmuebleEN(int idInmueble, String nombre, double superficie, int dormitorios, int aseos, double importeDesde, double iva, String imagen, String plano, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vista, bool recomendado)
        {
                this.init (idInmueble, nombre, superficie, dormitorios, aseos, importeDesde, iva, imagen, plano, vista, recomendado);
        }


        public InmuebleEN(InmuebleEN inmueble)
        {
                this.init (inmueble.IdInmueble, inmueble.Nombre, inmueble.Superficie, inmueble.Dormitorios, inmueble.Aseos, inmueble.ImporteDesde, inmueble.Iva, inmueble.Imagen, inmueble.Plano, inmueble.Vista, inmueble.Recomendado);
        }

        private void init (int idInmueble, String nombre, double superficie, int dormitorios, int aseos, double importeDesde, double iva, String imagen, String plano, System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vista, bool recomendado)
        {
                this.IdInmueble = idInmueble;


                this.Nombre = nombre;

                this.Superficie = superficie;

                this.Dormitorios = dormitorios;

                this.Aseos = aseos;

                this.ImporteDesde = importeDesde;

                this.Iva = iva;

                this.Imagen = imagen;

                this.Plano = plano;

                this.Vista = vista;

                this.Recomendado = recomendado;
        }

        public override bool Equals (object obj)
        {
                if (obj == null)
                        return false;
                InmuebleEN t = obj as InmuebleEN;
                if (t == null)
                        return false;
                if (IdInmueble.Equals (t.IdInmueble))
                        return true;
                else
                        return false;
        }

        public override int GetHashCode ()
        {
                int hash = 13;

                hash += (null == IdInmueble ? 0 : this.IdInmueble.GetHashCode ());
                return hash;
        }
        }
}
