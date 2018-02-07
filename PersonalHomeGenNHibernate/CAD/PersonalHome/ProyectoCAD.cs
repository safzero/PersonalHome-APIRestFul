
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
        public partial class ProyectoCAD : BasicCAD, IProyectoCAD
        {
        public ProyectoCAD() : base ()
        {
        }

        public ProyectoCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public ProyectoEN ReadOIDDefault (int idProyecto)
        {
                ProyectoEN proyectoEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        proyectoEN = (ProyectoEN)session.Load (typeof(ProyectoEN),
                                idProyecto

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return proyectoEN;
        }


        public int Crear (ProyectoEN proyecto)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        if (proyecto.Usuario != null) {
                                proyecto.Usuario = (PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN)session.Load (typeof(PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN), proyecto.Usuario.IdUsuario);
                        }

                        session.Save (proyecto);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return proyecto.IdProyecto;
        }

        public void Modificar (ProyectoEN proyecto)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        ProyectoEN proyectoEN = (ProyectoEN)session.Load (typeof(ProyectoEN), proyecto.IdProyecto);

                        proyectoEN.Variables = proyecto.Variables;

                        session.Update (proyectoEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idProyecto)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        ProyectoEN proyectoEN = (ProyectoEN)session.Load (typeof(ProyectoEN),
                                idProyecto

                                );
                        session.Delete (proyectoEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public ProyectoEN DamePorID (int idProyecto)
        {
                ProyectoEN proyectoEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        proyectoEN = (ProyectoEN)session.Load (typeof(ProyectoEN),
                                idProyecto

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return proyectoEN;
        }

        public System.Collections.Generic.IList<ProyectoEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<ProyectoEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProyectoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProyectoEN>();
                        else
                                result = session.CreateCriteria (typeof(ProyectoEN)).List<ProyectoEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in ProyectoCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }
        }
}
