
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class TipoEstanciaCAD : BasicCAD, ITipoEstanciaCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.FamiliaPackEN>         GetAllFamiliaPackOfTipoEstancia_PersonalHome (int idTipoEstancia)
        {
                System.Collections.Generic.IList<EN.PersonalHome.FamiliaPackEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM FamiliaPackEN self inner join self.TipoEstancia as target with target.IdTipoEstancia=:p_IdTipoEstancia";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdTipoEstancia", idTipoEstancia);



                                        result = query.List<EN.PersonalHome.FamiliaPackEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }

                return result;
        }

        public System.Collections.Generic.IList<EN.PersonalHome.EstanciaEN>    GetAllEstanciaOfTipoEstancia_PersonalHome (int idTipoEstancia)
        {
                System.Collections.Generic.IList<EN.PersonalHome.EstanciaEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM EstanciaEN self inner join self.TipoEstancia as target with target.IdTipoEstancia=:p_IdTipoEstancia";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdTipoEstancia", idTipoEstancia);



                                        result = query.List<EN.PersonalHome.EstanciaEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }

                return result;
        }
        }
}
