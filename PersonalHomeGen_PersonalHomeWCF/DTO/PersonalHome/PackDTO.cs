
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "PackDTO")]
        public class PackDTO
        {
        private int idPack;
        [DataMember]
        public int IdPack { get { return idPack; } set { idPack = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private String familia;
        [DataMember]
        public String Familia { get { return familia; } set { familia = value;  } }
        private String descripción;
        [DataMember]
        public String Descripción { get { return descripción; } set { descripción = value;  } }
        private String color;
        [DataMember]
        public String Color { get { return color; } set { color = value;  } }
        private String codigo;
        [DataMember]
        public String Codigo { get { return codigo; } set { codigo = value;  } }

        private System.Collections.Generic.IList<Int32> variable_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Variable_oid { get { return variable_oid; } set { variable_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> Variable;


        private System.Collections.Generic.IList<Int32> familiaPack_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> FamiliaPack_oid { get { return familiaPack_oid; } set { familiaPack_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> FamiliaPack;
        }
}
