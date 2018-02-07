using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;
using System.Runtime.Serialization;

namespace ApiRestFulPH.Clases
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public string Action { get; set; }
        
        [DataMember]
        public string Type { get; set; }

    }
}

    
