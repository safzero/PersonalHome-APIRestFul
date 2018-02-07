
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
        public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
        {
        public UsuarioCAD() : base ()
        {
        }

        public UsuarioCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public UsuarioEN ReadOIDDefault (int idUsuario)
        {
                UsuarioEN usuarioEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN),
                                idUsuario

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return usuarioEN;
        }


        public int Crear (UsuarioEN usuario)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (usuario);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return usuario.IdUsuario;
        }

        public void Modificar (UsuarioEN usuario)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.IdUsuario);

                        usuarioEN.Nombre = usuario.Nombre;


                        usuarioEN.Email = usuario.Email;


                        usuarioEN.Telefono = usuario.Telefono;


                        usuarioEN.Passwd = usuario.Passwd;

                        session.Update (usuarioEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idUsuario)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN),
                                idUsuario

                                );
                        session.Delete (usuarioEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public UsuarioEN DamePorID (int idUsuario)
        {
                UsuarioEN usuarioEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN),
                                idUsuario

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return usuarioEN;
        }

        public System.Collections.Generic.IList<UsuarioEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<UsuarioEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in UsuarioCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }
        }
}
