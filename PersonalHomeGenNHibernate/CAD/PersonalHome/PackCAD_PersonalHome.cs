
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class PackCAD : BasicCAD, IPackCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.VariableEN>    GetAllVariableOfPack_PersonalHome (int idPack)
        {
                System.Collections.Generic.IList<EN.PersonalHome.VariableEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM VariableEN self inner join self.Pack as target with target.IdPack=:p_IdPack";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdPack", idPack);



                                        result = query.List<EN.PersonalHome.VariableEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }

                return result;
        }

        public System.Collections.Generic.IList<EN.PersonalHome.FamiliaPackEN>         GetAllFamiliaPackOfPack_PersonalHome (int idPack)
        {
                System.Collections.Generic.IList<EN.PersonalHome.FamiliaPackEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM FamiliaPackEN self inner join self.Pack as target with target.IdPack=:p_IdPack";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdPack", idPack);



                                        result = query.List<EN.PersonalHome.FamiliaPackEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }

                return result;
        }
        }
}
