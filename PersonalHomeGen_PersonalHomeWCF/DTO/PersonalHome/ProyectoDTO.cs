
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "ProyectoDTO")]
        public class ProyectoDTO
        {
        private int idProyecto;
        [DataMember]
        public int IdProyecto { get { return idProyecto; } set { idProyecto = value;  } }
        private String variables;
        [DataMember]
        public String Variables { get { return variables; } set { variables = value;  } }

        private Int32 usuario_oid;
        [DataMember]
        public Int32 Usuario_oid { get { return usuario_oid; } set { usuario_oid = value;  } }

        [DataMember]
        public PersonalHome.UsuarioDTO Usuario;
        }
}
