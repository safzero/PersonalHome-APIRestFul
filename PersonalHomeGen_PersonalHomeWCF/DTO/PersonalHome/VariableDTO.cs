
using System;
using System.Runtime.Serialization;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome
{
        [DataContract (Name = "VariableDTO")]
        public class VariableDTO
        {
        private int idVariable;
        [DataMember]
        public int IdVariable { get { return idVariable; } set { idVariable = value;  } }
        private String nombre;
        [DataMember]
        public String Nombre { get { return nombre; } set { nombre = value;  } }
        private String caracteristicas;
        [DataMember]
        public String Caracteristicas { get { return caracteristicas; } set { caracteristicas = value;  } }
        private double precio;
        [DataMember]
        public double Precio { get { return precio; } set { precio = value;  } }
        private String imagen;
        [DataMember]
        public String Imagen { get { return imagen; } set { imagen = value;  } }
        private int iva;
        [DataMember]
        public int Iva { get { return iva; } set { iva = value;  } }
        private String miniatura;
        [DataMember]
        public String Miniatura { get { return miniatura; } set { miniatura = value;  } }

        private System.Collections.Generic.IList<Int32> pack_oid;
        [DataMember]
        public System.Collections.Generic.IList<Int32> Pack_oid { get { return pack_oid; } set { pack_oid = value;  } }

        [DataMember]
        public System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> Pack;
        }
}
