
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class VistaDTOENAdapter {
        public static VistaEN Convert (VistaDTO dto)
        {
                VistaEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new VistaEN ();



                                newinstance.IdVista = dto.IdVista;
                                newinstance.Nombre = dto.Nombre;
                                if (dto.Estancia_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD estanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD ();

                                        newinstance.Estancia = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN>();
                                        foreach (int entry in dto.Estancia_oid) {
                                                newinstance.Estancia.Add (estanciaCAD.ReadOIDDefault (entry));
                                        }
                                }
                                if (dto.Inmueble_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD inmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD ();

                                        newinstance.Inmueble = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN>();
                                        foreach (int entry in dto.Inmueble_oid) {
                                                newinstance.Inmueble.Add (inmuebleCAD.ReadOIDDefault (entry));
                                        }
                                }
                        }
                }
                catch (Exception ex)
                {
                        throw ex;
                }
                return newinstance;
        }
        }
}
