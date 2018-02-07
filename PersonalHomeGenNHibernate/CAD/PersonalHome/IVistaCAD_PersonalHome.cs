
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IVistaCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.EstanciaEN>    GetAllEstanciaOfVista_PersonalHome (int idVista);

        System.Collections.Generic.IList<EN.PersonalHome.InmuebleEN>    GetAllInmuebleOfVista_PersonalHome (int idVista);
        }
}
