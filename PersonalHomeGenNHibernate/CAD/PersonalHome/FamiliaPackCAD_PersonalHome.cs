
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class FamiliaPackCAD : BasicCAD, IFamiliaPackCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.PackEN>        GetAllPackOfFamiliaPack_PersonalHome (int idFamPack)
        {
                System.Collections.Generic.IList<EN.PersonalHome.PackEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM PackEN self inner join self.FamiliaPack as target with target.IdFamPack=:p_IdFamPack";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdFamPack", idFamPack);



                                        result = query.List<EN.PersonalHome.PackEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }

                return result;
        }

        public System.Collections.Generic.IList<EN.PersonalHome.TipoEstanciaEN>        GetAllTipoEstanciaOfFamiliaPack_PersonalHome (int idFamPack)
        {
                System.Collections.Generic.IList<EN.PersonalHome.TipoEstanciaEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM TipoEstanciaEN self inner join self.FamiliaPack as target with target.IdFamPack=:p_IdFamPack";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdFamPack", idFamPack);



                                        result = query.List<EN.PersonalHome.TipoEstanciaEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }

                return result;
        }
        }
}
