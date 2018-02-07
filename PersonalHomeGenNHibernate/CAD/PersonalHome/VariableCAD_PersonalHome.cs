
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class VariableCAD : BasicCAD, IVariableCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.PackEN>        GetAllPackOfVariable_PersonalHome (int idVariable)
        {
                System.Collections.Generic.IList<EN.PersonalHome.PackEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM PackEN self inner join self.Variable as target with target.IdVariable=:p_IdVariable";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdVariable", idVariable);



                                        result = query.List<EN.PersonalHome.PackEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }

                return result;
        }
        }
}
