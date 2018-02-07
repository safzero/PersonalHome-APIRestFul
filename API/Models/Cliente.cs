using PersonalHomeGenNHibernate.EN.PersonalHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Cliente
    {
        public string Action { get; set; }
        public string Type { get; set; }
        public UsuarioEN User { get; set; }
    }
}