
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class TipoEstanciaDTOENAdapter {
        public static TipoEstanciaEN Convert (TipoEstanciaDTO dto)
        {
                TipoEstanciaEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new TipoEstanciaEN ();



                                newinstance.IdTipoEstancia = dto.IdTipoEstancia;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Descripcion = dto.Descripcion;
                                newinstance.Imagen = dto.Imagen;
                                if (dto.FamiliaPack_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD familiaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD ();

                                        newinstance.FamiliaPack = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN>();
                                        foreach (int entry in dto.FamiliaPack_oid) {
                                                newinstance.FamiliaPack.Add (familiaPackCAD.ReadOIDDefault (entry));
                                        }
                                }
                                if (dto.Estancia_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD estanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD ();

                                        newinstance.Estancia = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN>();
                                        foreach (int entry in dto.Estancia_oid) {
                                                newinstance.Estancia.Add (estanciaCAD.ReadOIDDefault (entry));
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
