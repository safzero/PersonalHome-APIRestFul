
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class InmuebleAdapter {
        public static InmuebleDTO Convert (InmuebleEN en)
        {
                InmuebleDTO newinstance = null;

                if (en != null) {
                        newinstance = new InmuebleDTO ();



                        newinstance.IdInmueble = en.IdInmueble;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Superficie = en.Superficie;
                        newinstance.Dormitorios = en.Dormitorios;
                        newinstance.Aseos = en.Aseos;
                        newinstance.ImporteDesde = en.ImporteDesde;
                        newinstance.Iva = en.Iva;
                        newinstance.Imagen = en.Imagen;
                        newinstance.Plano = en.Plano;
                        if (en.Vista != null) {
                                newinstance.Vista_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN entry in en.Vista)
                                        newinstance.Vista_oid.Add (entry.IdVista);
                        }
                        newinstance.Recomendado = en.Recomendado;
                }

                return newinstance;
        }
        }
}
