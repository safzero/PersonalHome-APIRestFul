
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "VistaDTO")]
        public class VistaDTO
        {
        private int idVista;
        [DataMember]
        public int IdVista { get { return idVista; } set { idVista = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }

        private System.Collections.Generic.IList<Int32> estancia_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Estancia_oid { get { return estancia_oid; } set { estancia_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> Estancia;


        private System.Collections.Generic.IList<Int32> inmueble_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Inmueble_oid { get { return inmueble_oid; } set { inmueble_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> Inmueble;
        }
}
