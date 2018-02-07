
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class EstanciaAdapter {
        public static EstanciaDTO Convert (EstanciaEN en)
        {
                EstanciaDTO newinstance = null;

                if (en != null) {
                        newinstance = new EstanciaDTO ();



                        newinstance.IdEstancia = en.IdEstancia;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Descripcion = en.Descripcion;
                        newinstance.Codigo = en.Codigo;
                        newinstance.Plano = en.Plano;
                        if (en.TipoEstancia != null) {
                                newinstance.TipoEstancia_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN entry in en.TipoEstancia)
                                        newinstance.TipoEstancia_oid.Add (entry.IdTipoEstancia);
                        }
                        if (en.Vista != null) {
                                newinstance.Vista_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN entry in en.Vista)
                                        newinstance.Vista_oid.Add (entry.IdVista);
                        }
                }

                return newinstance;
        }
        }
}
