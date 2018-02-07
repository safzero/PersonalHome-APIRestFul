
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IPackCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.VariableEN>    GetAllVariableOfPack_PersonalHome (int idPack);

        System.Collections.Generic.IList<EN.PersonalHome.FamiliaPackEN>         GetAllFamiliaPackOfPack_PersonalHome (int idPack);
        }
}
