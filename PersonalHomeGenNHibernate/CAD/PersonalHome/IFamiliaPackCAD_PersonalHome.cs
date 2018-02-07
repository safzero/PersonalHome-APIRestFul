
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IFamiliaPackCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.PackEN>        GetAllPackOfFamiliaPack_PersonalHome (int idFamPack);

        System.Collections.Generic.IList<EN.PersonalHome.TipoEstanciaEN>        GetAllTipoEstanciaOfFamiliaPack_PersonalHome (int idFamPack);
        }
}
