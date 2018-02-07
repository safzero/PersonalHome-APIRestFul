
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "TipoEstanciaDTO")]
        public class TipoEstanciaDTO
        {
        private int idTipoEstancia;
        [DataMember]
        public int IdTipoEstancia { get { return idTipoEstancia; } set { idTipoEstancia = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private String descripcion;
        [DataMember]
        public String Descripcion { get { return descripcion; } set { descripcion = value;  } }
        private String imagen;
        [DataMember]
        public String Imagen { get { return imagen; } set { imagen = value;  } }

        private System.Collections.Generic.IList<Int32> familiaPack_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> FamiliaPack_oid { get { return familiaPack_oid; } set { familiaPack_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> FamiliaPack;


        private System.Collections.Generic.IList<Int32> estancia_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Estancia_oid { get { return estancia_oid; } set { estancia_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> Estancia;
        }
}
