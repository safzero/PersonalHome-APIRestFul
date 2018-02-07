
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
        {
        public System.Collections.Generic.IList<EN.PersonalHome.ProyectoEN>    GetAllProyectoOfUsuario_PersonalHome (int idUsuario)
        {
                System.Collections.Generic.IList<EN.PersonalHome.ProyectoEN> result = null;
                try
                {
                        using (ISession session = NHibernateHelper.OpenSession ())
                                using (ITransaction tx = session.BeginTransaction ())
                                {
                                        String sql = @"select self FROM ProyectoEN self inner join self.Usuario as target with target.IdUsuario=:p_IdUsuario";
                                        IQuery query = session.CreateQuery (sql).SetParameter ("p_IdUsuario", idUsuario);



                                        result = query.List<EN.PersonalHome.ProyectoEN>();
                                }
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }

                return result;
        }
        }
}
