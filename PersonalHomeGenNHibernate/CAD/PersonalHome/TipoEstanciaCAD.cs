
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
        public partial class TipoEstanciaCAD : BasicCAD, ITipoEstanciaCAD
        {
        public TipoEstanciaCAD() : base ()
        {
        }

        public TipoEstanciaCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public TipoEstanciaEN ReadOIDDefault (int idTipoEstancia)
        {
                TipoEstanciaEN tipoEstanciaEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN),
                                idTipoEstancia

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return tipoEstanciaEN;
        }


        public int Crear (TipoEstanciaEN tipoEstancia)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (tipoEstancia);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return tipoEstancia.IdTipoEstancia;
        }

        public void Modificar (TipoEstanciaEN tipoEstancia)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        TipoEstanciaEN tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), tipoEstancia.IdTipoEstancia);

                        tipoEstanciaEN.Nombre = tipoEstancia.Nombre;


                        tipoEstanciaEN.Descripcion = tipoEstancia.Descripcion;


                        tipoEstanciaEN.Imagen = tipoEstancia.Imagen;

                        session.Update (tipoEstanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idTipoEstancia)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        TipoEstanciaEN tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN),
                                idTipoEstancia

                                );
                        session.Delete (tipoEstanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public TipoEstanciaEN DamePorID (int idTipoEstancia)
        {
                TipoEstanciaEN tipoEstanciaEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN),
                                idTipoEstancia

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return tipoEstanciaEN;
        }

        public System.Collections.Generic.IList<TipoEstanciaEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<TipoEstanciaEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TipoEstanciaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TipoEstanciaEN>();
                        else
                                result = session.CreateCriteria (typeof(TipoEstanciaEN)).List<TipoEstanciaEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), p_TipoEstancia_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                        if (tipoEstanciaEN.FamiliaPack == null) {
                                tipoEstanciaEN.FamiliaPack = new System.Collections.Generic.List<EN.PersonalHome.FamiliaPackEN>();
                        }

                        foreach (int item in p_familiaPack_OIDs) {
                                familiaPackEN = new EN.PersonalHome.FamiliaPackEN ();
                                familiaPackEN = (EN.PersonalHome.FamiliaPackEN)session.Load (typeof(EN.PersonalHome.FamiliaPackEN), item);
                                tipoEstanciaEN.FamiliaPack.Add (familiaPackEN);
                        }


                        session.Update (tipoEstanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), p_TipoEstancia_OID);

                        EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                        if (tipoEstanciaEN.FamiliaPack != null) {
                                foreach (int item in p_familiaPack_OIDs) {
                                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), item);
                                        if (tipoEstanciaEN.FamiliaPack.Contains (familiaPackEN) == true)
                                                tipoEstanciaEN.FamiliaPack.Remove (familiaPackEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_familiaPack_OIDs you are trying to unrelationer, doesn't exist in TipoEstanciaEN");
                                }
                        }

                        session.Update (tipoEstanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void AsignarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), p_TipoEstancia_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;
                        if (tipoEstanciaEN.Estancia == null) {
                                tipoEstanciaEN.Estancia = new System.Collections.Generic.List<EN.PersonalHome.EstanciaEN>();
                        }

                        foreach (int item in p_estancia_OIDs) {
                                estanciaEN = new EN.PersonalHome.EstanciaEN ();
                                estanciaEN = (EN.PersonalHome.EstanciaEN)session.Load (typeof(EN.PersonalHome.EstanciaEN), item);
                                tipoEstanciaEN.Estancia.Add (estanciaEN);
                        }


                        session.Update (tipoEstanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), p_TipoEstancia_OID);

                        EN.PersonalHome.EstanciaEN estanciaEN = null;
                        if (tipoEstanciaEN.Estancia != null) {
                                foreach (int item in p_estancia_OIDs) {
                                        estanciaEN = (EstanciaEN)session.Load (typeof(EstanciaEN), item);
                                        if (tipoEstanciaEN.Estancia.Contains (estanciaEN) == true)
                                                tipoEstanciaEN.Estancia.Remove (estanciaEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_estancia_OIDs you are trying to unrelationer, doesn't exist in TipoEstanciaEN");
                                }
                        }

                        session.Update (tipoEstanciaEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in TipoEstanciaCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
