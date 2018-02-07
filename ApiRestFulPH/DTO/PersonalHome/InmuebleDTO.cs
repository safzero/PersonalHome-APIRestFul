
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "InmuebleDTO")]
        public class InmuebleDTO
        {
        private int idInmueble;
        [DataMember]
        public int IdInmueble { get { return idInmueble; } set { idInmueble = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private double superficie;
        [DataMember]
        public double Superficie { get { return superficie; } set { superficie = value;  } }
        private int dormitorios;
        [DataMember]
        public int Dormitorios { get { return dormitorios; } set { dormitorios = value;  } }
        private int aseos;
        [DataMember]
        public int Aseos { get { return aseos; } set { aseos = value;  } }
        private double importeDesde;
        [DataMember]
        public double ImporteDesde { get { return importeDesde; } set { importeDesde = value;  } }
        private double iva;
        [DataMember]
        public double Iva { get { return iva; } set { iva = value;  } }
        private String imagen;
        [DataMember]
        public String Imagen { get { return imagen; } set { imagen = value;  } }
        private String plano;
        [DataMember]
        public String Plano { get { return plano; } set { plano = value;  } }

        private System.Collections.Generic.IList<Int32> vista_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Vista_oid { get { return vista_oid; } set { vista_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> Vista;

        private bool recomendado;
        [DataMember]
        public bool Recomendado { get { return recomendado; } set { recomendado = value;  } }
        }
}
