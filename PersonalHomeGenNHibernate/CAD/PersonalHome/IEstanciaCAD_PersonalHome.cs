
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IEstanciaCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.TipoEstanciaEN>        GetAllTipoEstanciaOfEstancia_PersonalHome (int idEstancia);

        System.Collections.Generic.IList<EN.PersonalHome.VistaEN>       GetAllVistaOfEstancia_PersonalHome (int idEstancia);
        }
}
