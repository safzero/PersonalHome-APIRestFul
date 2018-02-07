
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IUsuarioCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.ProyectoEN>    GetAllProyectoOfUsuario_PersonalHome (int idUsuario);
        }
}
