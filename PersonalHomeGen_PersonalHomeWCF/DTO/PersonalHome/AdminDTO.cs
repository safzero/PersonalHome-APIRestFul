
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "AdminDTO")]
        public class AdminDTO
        {
        private int idAdmin;
        [DataMember]
        public int IdAdmin { get { return idAdmin; } set { idAdmin = value;  } }
        private String email;
        [DataMember]
        public String Email { get { return email; } set { email = value;  } }
        private String passwd;
        [DataMember]
        public String Passwd { get { return passwd; } set { passwd = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        }
}
