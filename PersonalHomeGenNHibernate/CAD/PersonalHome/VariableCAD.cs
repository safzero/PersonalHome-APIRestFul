
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
        public partial class VariableCAD : BasicCAD, IVariableCAD
        {
        public VariableCAD() : base ()
        {
        }

        public VariableCAD(ISession sessionAux) : base (sessionAux)
        {
        }



        public VariableEN ReadOIDDefault (int idVariable)
        {
                VariableEN variableEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        variableEN = (VariableEN)session.Load (typeof(VariableEN),
                                idVariable

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return variableEN;
        }


        public void Eliminar (int idVariable)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        VariableEN variableEN = (VariableEN)session.Load (typeof(VariableEN),
                                idVariable

                                );
                        session.Delete (variableEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public VariableEN DamePorID (int idVariable)
        {
                VariableEN variableEN = null;

                try
                {
                        SesssionInitializeTransaction ();
                        variableEN = (VariableEN)session.Load (typeof(VariableEN),
                                idVariable

                                );
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return variableEN;
        }

        public System.Collections.Generic.IList<VariableEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<VariableEN> result = null;
                try
                {
                        SesssionInitializeTransaction ();
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VariableEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<VariableEN>();
                        else
                                result = session.CreateCriteria (typeof(VariableEN)).List<VariableEN>();
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return result;
        }

        public void AsignarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN variableEN = null;
                try
                {
                        SesssionInitializeTransaction ();
                        variableEN = (VariableEN)session.Load (typeof(VariableEN), p_Variable_OID);
                        PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;
                        if (variableEN.Pack == null) {
                                variableEN.Pack = new System.Collections.Generic.List<EN.PersonalHome.PackEN>();
                        }

                        foreach (int item in p_pack_OIDs) {
                                packEN = new EN.PersonalHome.PackEN ();
                                packEN = (EN.PersonalHome.PackEN)session.Load (typeof(EN.PersonalHome.PackEN), item);
                                variableEN.Pack.Add (packEN);
                        }


                        session.Update (variableEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }

        public void QuitarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN variableEN = null;
                        variableEN = (VariableEN)session.Load (typeof(VariableEN), p_Variable_OID);

                        EN.PersonalHome.PackEN packEN = null;
                        if (variableEN.Pack != null) {
                                foreach (int item in p_pack_OIDs) {
                                        packEN = (PackEN)session.Load (typeof(PackEN), item);
                                        if (variableEN.Pack.Contains (packEN) == true)
                                                variableEN.Pack.Remove (packEN);
                                        else
                                                throw new ModelException ("The identifier " + item + " in p_pack_OIDs you are trying to unrelationer, doesn't exist in VariableEN");
                                }
                        }

                        session.Update (variableEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        public int Crear (VariableEN variable)
        {
                try
                {
                        SesssionInitializeTransaction ();

                        session.Save (variable);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }

                return variable.IdVariable;
        }

        public void Modificar (VariableEN variable)
        {
                try
                {
                        SesssionInitializeTransaction ();
                        VariableEN variableEN = (VariableEN)session.Load (typeof(VariableEN), variable.IdVariable);

                        variableEN.Nombre = variable.Nombre;


                        variableEN.Caracteristicas = variable.Caracteristicas;


                        variableEN.Precio = variable.Precio;


                        variableEN.Imagen = variable.Imagen;


                        variableEN.Iva = variable.Iva;


                        variableEN.Miniatura = variable.Miniatura;

                        session.Update (variableEN);
                        SessionCommit ();
                }

                catch (Exception ex) {
                        SessionRollBack ();
                        if (ex is ModelException)
                                throw ex;
                        throw new DataLayerException ("Error in VariableCAD.", ex);
                }


                finally
                {
                        SessionClose ();
                }
        }
        }
}
