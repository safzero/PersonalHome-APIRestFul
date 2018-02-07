
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class ProyectoCAD : BasicCAD, IProyectoCAD
        {
        public EN.PersonalHome.UsuarioEN               GetUsuarioOfProyecto_PersonalHome (int idProyecto)
        {
                EN.PersonalHome.UsuarioEN result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM UsuarioEN self inner join self.Proyecto as target with target.IdProyecto=:p_IdProyecto";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdProyecto", idProyecto);



                                        result = query.UniqueResult<EN.PersonalHome.UsuarioEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }

                return result;
        }
        }
}
