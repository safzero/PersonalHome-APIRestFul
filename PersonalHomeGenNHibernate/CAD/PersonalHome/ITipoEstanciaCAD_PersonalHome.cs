
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface ITipoEstanciaCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.FamiliaPackEN>         GetAllFamiliaPackOfTipoEstancia_PersonalHome (int idTipoEstancia);

        System.Collections.Generic.IList<EN.PersonalHome.EstanciaEN>    GetAllEstanciaOfTipoEstancia_PersonalHome (int idTipoEstancia);
        }
}
