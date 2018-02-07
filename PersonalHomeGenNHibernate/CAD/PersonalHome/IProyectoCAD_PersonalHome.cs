
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IProyectoCAD
        {
        EN.PersonalHome.UsuarioEN               GetUsuarioOfProyecto_PersonalHome (int idProyecto);
        }
}
