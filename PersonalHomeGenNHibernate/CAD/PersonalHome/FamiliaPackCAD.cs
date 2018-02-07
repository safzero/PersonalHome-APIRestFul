
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
        public partial class FamiliaPackCAD : BasicCAD, IFamiliaPackCAD
        {
        public FamiliaPackCAD() : base ()
        {
        }

        public FamiliaPackCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public FamiliaPackEN ReadOIDDefault (int idFamPack)
        {
                FamiliaPackEN familiaPackEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN),
                                idFamPack

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return familiaPackEN;
        }


        public int Crear (FamiliaPackEN familiaPack)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (familiaPack);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return familiaPack.IdFamPack;
        }

        public void Modificar (FamiliaPackEN familiaPack)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        FamiliaPackEN familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), familiaPack.IdFamPack);

                        familiaPackEN.Nombre = familiaPack.Nombre;


                        familiaPackEN.Codigo = familiaPack.Codigo;


                        familiaPackEN.Color = familiaPack.Color;

                        session.Update (familiaPackEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idFamPack)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        FamiliaPackEN familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN),
                                idFamPack

                                );
                        session.Delete (familiaPackEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public FamiliaPackEN DamePorID (int idFamPack)
        {
                FamiliaPackEN familiaPackEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN),
                                idFamPack

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return familiaPackEN;
        }

        public System.Collections.Generic.IList<FamiliaPackEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<FamiliaPackEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FamiliaPackEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FamiliaPackEN>();
                        else
                                result = session.CreateCriteria (typeof(FamiliaPackEN)).List<FamiliaPackEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), p_FamiliaPack_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;
                        if (familiaPackEN.Pack == null) {
                                familiaPackEN.Pack = new System.Collections.Generic.List<EN.PersonalHome.PackEN>();
                        }

                        foreach (int item in p_pack_OIDs) {
                                packEN = new EN.PersonalHome.PackEN ();
                                packEN = (EN.PersonalHome.PackEN)session.Load (typeof(EN.PersonalHome.PackEN), item);
                                familiaPackEN.Pack.Add (packEN);
                        }


                        session.Update (familiaPackEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), p_FamiliaPack_OID);

                        EN.PersonalHome.PackEN packEN = null;
                        if (familiaPackEN.Pack != null) {
                                foreach (int item in p_pack_OIDs) {
                                        packEN = (PackEN)session.Load (typeof(PackEN), item);
                                        if (familiaPackEN.Pack.Contains (packEN) == true)
                                                familiaPackEN.Pack.Remove (packEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_pack_OIDs you are trying to unrelationer, doesn't exist in FamiliaPackEN");
                                }
                        }

                        session.Update (familiaPackEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void AsignarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), p_FamiliaPack_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                        if (familiaPackEN.TipoEstancia == null) {
                                familiaPackEN.TipoEstancia = new System.Collections.Generic.List<EN.PersonalHome.TipoEstanciaEN>();
                        }

                        foreach (int item in p_tipoEstancia_OIDs) {
                                tipoEstanciaEN = new EN.PersonalHome.TipoEstanciaEN ();
                                tipoEstanciaEN = (EN.PersonalHome.TipoEstanciaEN)session.Load (typeof(EN.PersonalHome.TipoEstanciaEN), item);
                                familiaPackEN.TipoEstancia.Add (tipoEstanciaEN);
                        }


                        session.Update (familiaPackEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), p_FamiliaPack_OID);

                        EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;
                        if (familiaPackEN.TipoEstancia != null) {
                                foreach (int item in p_tipoEstancia_OIDs) {
                                        tipoEstanciaEN = (TipoEstanciaEN)session.Load (typeof(TipoEstanciaEN), item);
                                        if (familiaPackEN.TipoEstancia.Contains (tipoEstanciaEN) == true)
                                                familiaPackEN.TipoEstancia.Remove (tipoEstanciaEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_tipoEstancia_OIDs you are trying to unrelationer, doesn't exist in FamiliaPackEN");
                                }
                        }

                        session.Update (familiaPackEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in FamiliaPackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
