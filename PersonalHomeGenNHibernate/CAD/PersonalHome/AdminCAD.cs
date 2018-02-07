
using System;
using System.Text;
using PersonalHomeGenNHibernate.CEN;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial class AdminCAD : BasicCAD, IAdminCAD
        {
        public AdminCAD() : base ()
        {
        }

        public AdminCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public AdminEN ReadOIDDefault (int idAdmin)
        {
                AdminEN adminEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        adminEN = (AdminEN)session.Load (typeof(AdminEN),
                                idAdmin

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return adminEN;
        }


        public int CrearAdmin (AdminEN admin)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (admin);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return admin.IdAdmin;
        }

        public void ModificarAdmin (AdminEN admin)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        AdminEN adminEN = (AdminEN)session.Load (typeof(AdminEN), admin.IdAdmin);

                        adminEN.Email = admin.Email;


                        adminEN.Passwd = admin.Passwd;


                        adminEN.Nombre = admin.Nombre;

                        session.Update (adminEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void EliminarAdmin (int idAdmin)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        AdminEN adminEN = (AdminEN)session.Load (typeof(AdminEN),
                                idAdmin

                                );
                        session.Delete (adminEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public AdminEN DamePorID (int idAdmin)
        {
                AdminEN adminEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        adminEN = (AdminEN)session.Load (typeof(AdminEN),
                                idAdmin

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return adminEN;
        }

        public System.Collections.Generic.IList<AdminEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<AdminEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdminEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdminEN>();
                        else
                                result = session.CreateCriteria (typeof(AdminEN)).List<AdminEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public System.Collections.Generic.IList<AdminEN> DamePorEmail (String p_email)
        {
                System.Collections.Generic.IList<AdminEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        String sql = @"FROM AdminEN self where :p_email like Email";
                        IQuery query = session.CreateQuery (sql);
                        query.SetParameter ("p_email", p_email);
                        result = query.List<AdminEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }
        public System.Collections.Generic.IList<AdminEN> DamePorEmailPassword (String p_email, String p_passwd)
        {
                System.Collections.Generic.IList<AdminEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        String sql = @"FROM AdminEN self where :p_email like Email and :p_passwd like Passwd";
                        IQuery query = session.CreateQuery (sql);
                        query.SetParameter ("p_email", p_email);
                        query.SetParameter ("p_passwd", p_passwd);
                        result = query.List<AdminEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in AdminCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }
        }
}
