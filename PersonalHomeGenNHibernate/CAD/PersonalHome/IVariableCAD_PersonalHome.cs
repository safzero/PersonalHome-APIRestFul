
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IVariableCAD
        {
        System.Collections.Generic.IList<EN.PersonalHome.PackEN>        GetAllPackOfVariable_PersonalHome (int idVariable);
        }
}
