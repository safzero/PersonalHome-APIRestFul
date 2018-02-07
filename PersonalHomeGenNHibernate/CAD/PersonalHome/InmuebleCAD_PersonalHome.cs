
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class InmuebleCAD : BasicCAD, IInmuebleCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.VistaEN>       GetAllVistaOfInmueble_PersonalHome (int idInmueble)
        {
                System.Collections.Generic.IList<EN.PersonalHome.VistaEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM VistaEN self inner join self.Inmueble as target with target.IdInmueble=:p_IdInmueble";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdInmueble", idInmueble);



                                        result = query.List<EN.PersonalHome.VistaEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }

                return result;
        }
        }
}
