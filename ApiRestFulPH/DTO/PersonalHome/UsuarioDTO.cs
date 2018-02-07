
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "UsuarioDTO")]
        public class UsuarioDTO
        {
        private int idUsuario;
        [DataMember]
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private String email;
        [DataMember]
        public String Email { get { return email; } set { email = value;  } }
        private String telefono;
        [DataMember]
        public String Telefono { get { return telefono; } set { telefono = value;  } }
        private String passwd;
        [DataMember]
        public String Passwd { get { return passwd; } set { passwd = value;  } }

        private System.Collections.Generic.IList<Int32> proyecto_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Proyecto_oid { get { return proyecto_oid; } set { proyecto_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> Proyecto;
        }
}
