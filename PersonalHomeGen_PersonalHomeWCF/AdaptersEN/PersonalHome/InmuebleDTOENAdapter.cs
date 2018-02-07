
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class InmuebleDTOENAdapter {
        public static InmuebleEN Convert (InmuebleDTO dto)
        {
                InmuebleEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new InmuebleEN ();



                                newinstance.IdInmueble = dto.IdInmueble;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Superficie = dto.Superficie;
                                newinstance.Dormitorios = dto.Dormitorios;
                                newinstance.Aseos = dto.Aseos;
                                newinstance.ImporteDesde = dto.ImporteDesde;
                                newinstance.Iva = dto.Iva;
                                newinstance.Imagen = dto.Imagen;
                                newinstance.Plano = dto.Plano;
                                if (dto.Vista_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD vistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD ();

                                        newinstance.Vista = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN>();
                                        foreach (int entry in dto.Vista_oid) {
                                                newinstance.Vista.Add (vistaCAD.ReadOIDDefault (entry));
                                        }
                                }
                                newinstance.Recomendado = dto.Recomendado;
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
