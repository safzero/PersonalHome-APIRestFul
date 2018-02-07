
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "FamiliaPackDTO")]
        public class FamiliaPackDTO
        {
        private int idFamPack;
        [DataMember]
        public int IdFamPack { get { return idFamPack; } set { idFamPack = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private String codigo;
        [DataMember]
        public String Codigo { get { return codigo; } set { codigo = value;  } }
        private String color;
        [DataMember]
        public String Color { get { return color; } set { color = value;  } }

        private System.Collections.Generic.IList<Int32> pack_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Pack_oid { get { return pack_oid; } set { pack_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> Pack;


        private System.Collections.Generic.IList<Int32> tipoEstancia_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> TipoEstancia_oid { get { return tipoEstancia_oid; } set { tipoEstancia_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> TipoEstancia;
        }
}
