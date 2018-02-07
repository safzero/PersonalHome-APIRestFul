
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
        public partial class EstanciaCAD : BasicCAD, IEstanciaCAD
        {
        public EstanciaCAD() : base ()
        {
        }

        public EstanciaCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public EstanciaEN ReadOIDDefault (int idEstancia)
        {
                EstanciaEN estanciaEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN),
                                idEstancia

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return estanciaEN;
        }


        public int Crear (EstanciaEN estancia)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (estancia);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return estancia.IdEstancia;
        }

        public void Modificar (EstanciaEN estancia)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        EstanciaEN estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), estancia.IdEstancia);

                        estanciaEN.Nombre = estancia.Nombre;


                        estanciaEN.Descripcion = estancia.Descripcion;


                        estanciaEN.Codigo = estancia.Codigo;


                        estanciaEN.Plano = estancia.Plano;

                        session.Update (estanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idEstancia)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        EstanciaEN estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN),
                                idEstancia

                                );
                        session.Delete (estanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public EstanciaEN DamePorID (int idEstancia)
        {
                EstanciaEN estanciaEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN),
                                idEstancia

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return estanciaEN;
        }

        public System.Collections.Generic.IList<EstanciaEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<EstanciaEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EstanciaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EstanciaEN>();
                        else
                                result = session.CreateCriteria (typeof(EstanciaEN)).List<EstanciaEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), p_Estancia_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                        if (estanciaEN.TipoEstancia == null) {
                                estanciaEN.TipoEstancia = new System.Collections.Generic.List<EN.PersonalHome.TipoEstanciaEN>();
                        }

                        foreach (int item in p_tipoEstancia_OIDs) {
                                tipoEstanciaEN = new EN.PersonalHome.TipoEstanciaEN ();
                                tipoEstanciaEN = (EN.PersonalHome.TipoEstanciaEN)session.Load (typeof(EN.PersonalHome.TipoEstanciaEN), item);
                                estanciaEN.TipoEstancia.Add (tipoEstanciaEN);
                        }


                        session.Update (estanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;
                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), p_Estancia_OID);

                        EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                        if (estanciaEN.TipoEstancia != null) {
                                foreach (int item in p_tipoEstancia_OIDs) {
                                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), item);
                                        if (estanciaEN.TipoEstancia.Contains (tipoEstanciaEN) == true)
                                                estanciaEN.TipoEstancia.Remove (tipoEstanciaEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_tipoEstancia_OIDs you are trying to unrelationer, doesn't exist in EstanciaEN");
                                }
                        }

                        session.Update (estanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void AsignarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), p_Estancia_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;
                        if (estanciaEN.Vista == null) {
                                estanciaEN.Vista = new System.Collections.Generic.List<EN.PersonalHome.VistaEN>();
                        }

                        foreach (int item in p_vista_OIDs) {
                                vistaEN = new EN.PersonalHome.VistaEN ();
                                vistaEN = (EN.PersonalHome.VistaEN)session.Load (typeof(EN.PersonalHome.VistaEN), item);
                                estanciaEN.Vista.Add (vistaEN);
                        }


                        session.Update (estanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;
                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), p_Estancia_OID);

                        EN.PersonalHome.VistaEN vistaEN = null;
                        if (estanciaEN.Vista != null) {
                                foreach (int item in p_vista_OIDs) {
                                        vistaEN = (VistaEN)session.Load (typeof(VistaEN), item);
                                        if (estanciaEN.Vista.Contains (vistaEN) == true)
                                                estanciaEN.Vista.Remove (vistaEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_vista_OIDs you are trying to unrelationer, doesn't exist in EstanciaEN");
                                }
                        }

                        session.Update (estanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in EstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
