
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
        public partial class InmuebleCAD : BasicCAD, IInmuebleCAD
        {
        public InmuebleCAD() : base ()
        {
        }

        public InmuebleCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public InmuebleEN ReadOIDDefault (int idInmueble)
        {
                InmuebleEN inmuebleEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN),
                                idInmueble

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return inmuebleEN;
        }


        public int Crear (InmuebleEN inmueble)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (inmueble);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return inmueble.IdInmueble;
        }

        public void Modificar (InmuebleEN inmueble)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        InmuebleEN inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN), inmueble.IdInmueble);

                        inmuebleEN.Nombre = inmueble.Nombre;


                        inmuebleEN.Superficie = inmueble.Superficie;


                        inmuebleEN.Dormitorios = inmueble.Dormitorios;


                        inmuebleEN.Aseos = inmueble.Aseos;


                        inmuebleEN.ImporteDesde = inmueble.ImporteDesde;


                        inmuebleEN.Iva = inmueble.Iva;


                        inmuebleEN.Imagen = inmueble.Imagen;


                        inmuebleEN.Plano = inmueble.Plano;


                        inmuebleEN.Recomendado = inmueble.Recomendado;

                        session.Update (inmuebleEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idInmueble)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        InmuebleEN inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN),
                                idInmueble

                                );
                        session.Delete (inmuebleEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public InmuebleEN DamePorID (int idInmueble)
        {
                InmuebleEN inmuebleEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN),
                                idInmueble

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return inmuebleEN;
        }

        public System.Collections.Generic.IList<InmuebleEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<InmuebleEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InmuebleEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<InmuebleEN>();
                        else
                                result = session.CreateCriteria (typeof(InmuebleEN)).List<InmuebleEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN inmuebleEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN), p_Inmueble_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;
                        if (inmuebleEN.Vista == null) {
                                inmuebleEN.Vista = new System.Collections.Generic.List<EN.PersonalHome.VistaEN>();
                        }

                        foreach (int item in p_vista_OIDs) {
                                vistaEN = new EN.PersonalHome.VistaEN ();
                                vistaEN = (EN.PersonalHome.VistaEN)session.Load (typeof(EN.PersonalHome.VistaEN), item);
                                inmuebleEN.Vista.Add (vistaEN);
                        }


                        session.Update (inmuebleEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN inmuebleEN = null;
                        inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN), p_Inmueble_OID);

                        EN.PersonalHome.VistaEN vistaEN = null;
                        if (inmuebleEN.Vista != null) {
                                foreach (int item in p_vista_OIDs) {
                                        vistaEN = (VistaEN)session.Load (typeof(VistaEN), item);
                                        if (inmuebleEN.Vista.Contains (vistaEN) == true)
                                                inmuebleEN.Vista.Remove (vistaEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_vista_OIDs you are trying to unrelationer, doesn't exist in InmuebleEN");
                                }
                        }

                        session.Update (inmuebleEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in InmuebleCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
