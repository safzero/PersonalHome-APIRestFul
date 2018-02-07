
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
        public partial class VistaCAD : BasicCAD, IVistaCAD
        {
        public VistaCAD() : base ()
        {
        }

        public VistaCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public VistaEN ReadOIDDefault (int idVista)
        {
                VistaEN vistaEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        vistaEN = (VistaEN)session.Load (typeof(VistaEN),
                                idVista

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return vistaEN;
        }


        public int Crear (VistaEN vista)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (vista);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return vista.IdVista;
        }

        public void Modificar (VistaEN vista)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        VistaEN vistaEN = (VistaEN)session.Load (typeof(VistaEN), vista.IdVista);

                        vistaEN.Nombre = vista.Nombre;

                        session.Update (vistaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idVista)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        VistaEN vistaEN = (VistaEN)session.Load (typeof(VistaEN),
                                idVista

                                );
                        session.Delete (vistaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public VistaEN DamePorID (int idVista)
        {
                VistaEN vistaEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        vistaEN = (VistaEN)session.Load (typeof(VistaEN),
                                idVista

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return vistaEN;
        }

        public System.Collections.Generic.IList<VistaEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<VistaEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VistaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<VistaEN>();
                        else
                                result = session.CreateCriteria (typeof(VistaEN)).List<VistaEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        vistaEN = (VistaEN)session.Load (typeof(VistaEN), p_Vista_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;
                        if (vistaEN.Estancia == null) {
                                vistaEN.Estancia = new System.Collections.Generic.List<EN.PersonalHome.EstanciaEN>();
                        }

                        foreach (int item in p_estancia_OIDs) {
                                estanciaEN = new EN.PersonalHome.EstanciaEN ();
                                estanciaEN = (EN.PersonalHome.EstanciaEN)session.Load (typeof(EN.PersonalHome.EstanciaEN), item);
                                vistaEN.Estancia.Add (estanciaEN);
                        }


                        session.Update (vistaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;
                        vistaEN = (VistaEN)session.Load (typeof(VistaEN), p_Vista_OID);

                        EN.PersonalHome.EstanciaEN estanciaEN = null;
                        if (vistaEN.Estancia != null) {
                                foreach (int item in p_estancia_OIDs) {
                                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), item);
                                        if (vistaEN.Estancia.Contains (estanciaEN) == true)
                                                vistaEN.Estancia.Remove (estanciaEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_estancia_OIDs you are trying to unrelationer, doesn't exist in VistaEN");
                                }
                        }

                        session.Update (vistaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void AsignarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        vistaEN = (VistaEN)session.Load (typeof(VistaEN), p_Vista_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN inmuebleEN = null;
                        if (vistaEN.Inmueble == null) {
                                vistaEN.Inmueble = new System.Collections.Generic.List<EN.PersonalHome.InmuebleEN>();
                        }

                        foreach (int item in p_inmueble_OIDs) {
                                inmuebleEN = new EN.PersonalHome.InmuebleEN ();
                                inmuebleEN = (EN.PersonalHome.InmuebleEN)session.Load (typeof(EN.PersonalHome.InmuebleEN), item);
                                vistaEN.Inmueble.Add (inmuebleEN);
                        }


                        session.Update (vistaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;
                        vistaEN = (VistaEN)session.Load (typeof(VistaEN), p_Vista_OID);

                        EN.PersonalHome.InmuebleEN inmuebleEN = null;
                        if (vistaEN.Inmueble != null) {
                                foreach (int item in p_inmueble_OIDs) {
                                        inmuebleEN = (InmuebleEN)session.Load (typeof(InmuebleEN), item);
                                        if (vistaEN.Inmueble.Contains (inmuebleEN) == true)
                                                vistaEN.Inmueble.Remove (inmuebleEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_inmueble_OIDs you are trying to unrelationer, doesn't exist in VistaEN");
                                }
                        }

                        session.Update (vistaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VistaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
