
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
        public partial class PackCAD : BasicCAD, IPackCAD
        {
        public PackCAD() : base ()
        {
        }

        public PackCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public PackEN ReadOIDDefault (int idPack)
        {
                PackEN packEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        packEN = (PackEN)session.Load (typeof(PackEN),
                                idPack

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return packEN;
        }


        public int Crear (PackEN pack)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (pack);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return pack.IdPack;
        }

        public void Modificar (PackEN pack)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PackEN packEN = (PackEN)session.Load (typeof(PackEN), pack.IdPack);

                        packEN.Nombre = pack.Nombre;


                        packEN.Familia = pack.Familia;


                        packEN.Descripción = pack.Descripción;


                        packEN.Color = pack.Color;


                        packEN.Codigo = pack.Codigo;

                        session.Update (packEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void Eliminar (int idPack)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PackEN packEN = (PackEN)session.Load (typeof(PackEN),
                                idPack

                                );
                        session.Delete (packEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public PackEN DamePorID (int idPack)
        {
                PackEN packEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        packEN = (PackEN)session.Load (typeof(PackEN),
                                idPack

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return packEN;
        }

        public System.Collections.Generic.IList<PackEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<PackEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PackEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PackEN>();
                        else
                                result = session.CreateCriteria (typeof(PackEN)).List<PackEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        packEN = (PackEN)session.Load (typeof(PackEN), p_Pack_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN variableEN = null;
                        if (packEN.Variable == null) {
                                packEN.Variable = new System.Collections.Generic.List<EN.PersonalHome.VariableEN>();
                        }

                        foreach (int item in p_variable_OIDs) {
                                variableEN = new EN.PersonalHome.VariableEN ();
                                variableEN = (EN.PersonalHome.VariableEN)session.Load (typeof(EN.PersonalHome.VariableEN), item);
                                packEN.Variable.Add (variableEN);
                        }


                        session.Update (packEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;
                        packEN = (PackEN)session.Load (typeof(PackEN), p_Pack_OID);

                        EN.PersonalHome.VariableEN variableEN = null;
                        if (packEN.Variable != null) {
                                foreach (int item in p_variable_OIDs) {
                                        variableEN = (VariableEN)session.Load (typeof(VariableEN), item);
                                        if (packEN.Variable.Contains (variableEN) == true)
                                                packEN.Variable.Remove (variableEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_variable_OIDs you are trying to unrelationer, doesn't exist in PackEN");
                                }
                        }

                        session.Update (packEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public void AsignarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        packEN = (PackEN)session.Load (typeof(PackEN), p_Pack_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                        if (packEN.FamiliaPack == null) {
                                packEN.FamiliaPack = new System.Collections.Generic.List<EN.PersonalHome.FamiliaPackEN>();
                        }

                        foreach (int item in p_familiaPack_OIDs) {
                                familiaPackEN = new EN.PersonalHome.FamiliaPackEN ();
                                familiaPackEN = (EN.PersonalHome.FamiliaPackEN)session.Load (typeof(EN.PersonalHome.FamiliaPackEN), item);
                                packEN.FamiliaPack.Add (familiaPackEN);
                        }


                        session.Update (packEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;
                        packEN = (PackEN)session.Load (typeof(PackEN), p_Pack_OID);

                        EN.PersonalHome.FamiliaPackEN familiaPackEN = null;
                        if (packEN.FamiliaPack != null) {
                                foreach (int item in p_familiaPack_OIDs) {
                                        familiaPackEN = (FamiliaPackEN)session.Load (typeof(FamiliaPackEN), item);
                                        if (packEN.FamiliaPack.Contains (familiaPackEN) == true)
                                                packEN.FamiliaPack.Remove (familiaPackEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_familiaPack_OIDs you are trying to unrelationer, doesn't exist in PackEN");
                                }
                        }

                        session.Update (packEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in PackCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
