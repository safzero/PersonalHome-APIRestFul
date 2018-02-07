
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IInmuebleCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.VistaEN>       GetAllVistaOfInmueble_PersonalHome (int idInmueble);
        }
}
