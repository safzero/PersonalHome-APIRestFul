
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class VistaCAD : BasicCAD, IVistaCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.EstanciaEN>    GetAllEstanciaOfVista_PersonalHome (int idVista)
        {
                System.Collections.Generic.IList<EN.PersonalHome.EstanciaEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM EstanciaEN self inner join self.Vista as target with target.IdVista=:p_IdVista";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdVista", idVista);



                                        result = query.List<EN.PersonalHome.EstanciaEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }

                return result;
        }

        public System.Collections.Generic.IList<EN.PersonalHome.InmuebleEN>    GetAllInmuebleOfVista_PersonalHome (int idVista)
        {
                System.Collections.Generic.IList<EN.PersonalHome.InmuebleEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM InmuebleEN self inner join self.Vista as target with target.IdVista=:p_IdVista";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdVista", idVista);



                                        result = query.List<EN.PersonalHome.InmuebleEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }

                return result;
        }
        }
}
