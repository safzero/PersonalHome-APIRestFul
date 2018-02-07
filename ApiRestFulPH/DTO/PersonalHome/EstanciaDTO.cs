
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "EstanciaDTO")]
        public class EstanciaDTO
        {
        private int idEstancia;
        [DataMember]
        public int IdEstancia { get { return idEstancia; } set { idEstancia = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private String descripcion;
        [DataMember]
        public String Descripcion { get { return descripcion; } set { descripcion = value;  } }
        private String codigo;
        [DataMember]
        public String Codigo { get { return codigo; } set { codigo = value;  } }
        private String plano;
        [DataMember]
        public String Plano { get { return plano; } set { plano = value;  } }

        private System.Collections.Generic.IList<Int32> tipoEstancia_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> TipoEstancia_oid { get { return tipoEstancia_oid; } set { tipoEstancia_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> TipoEstancia;


        private System.Collections.Generic.IList<Int32> vista_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Vista_oid { get { return vista_oid; } set { vista_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> Vista;
        }
}
