
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class VistaAdapter {
        public static VistaDTO Convert (VistaEN en)
        {
                VistaDTO newinstance = null;

                if (en != null) {
                        newinstance = new VistaDTO ();



                        newinstance.IdVista = en.IdVista;
                        newinstance.Nombre = en.Nombre;
                        if (en.Estancia != null) {
                                newinstance.Estancia_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN entry in en.Estancia)
                                        newinstance.Estancia_oid.Add (entry.IdEstancia);
                        }
                        if (en.Inmueble != null) {
                                newinstance.Inmueble_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN entry in en.Inmueble)
                                        newinstance.Inmueble_oid.Add (entry.IdInmueble);
                        }
                }

                return newinstance;
        }
        }
}
