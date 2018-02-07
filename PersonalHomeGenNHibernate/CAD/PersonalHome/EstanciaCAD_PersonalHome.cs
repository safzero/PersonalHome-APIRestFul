
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class EstanciaCAD : BasicCAD, IEstanciaCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.TipoEstanciaEN>        GetAllTipoEstanciaOfEstancia_PersonalHome (int idEstancia)
        {
                System.Collections.Generic.IList<EN.PersonalHome.TipoEstanciaEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM TipoEstanciaEN self inner join self.Estancia as target with target.IdEstancia=:p_IdEstancia";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdEstancia", idEstancia);



                                        result = query.List<EN.PersonalHome.TipoEstanciaEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }

                return result;
        }

        public System.Collections.Generic.IList<EN.PersonalHome.VistaEN>       GetAllVistaOfEstancia_PersonalHome (int idEstancia)
        {
                System.Collections.Generic.IList<EN.PersonalHome.VistaEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM VistaEN self inner join self.Estancia as target with target.IdEstancia=:p_IdEstancia";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdEstancia", idEstancia);



                                        result = query.List<EN.PersonalHome.VistaEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }

                return result;
        }
        }
}
