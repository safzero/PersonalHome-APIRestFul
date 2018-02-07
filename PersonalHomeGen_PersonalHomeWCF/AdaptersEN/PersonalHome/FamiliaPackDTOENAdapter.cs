
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class FamiliaPackDTOENAdapter {
        public static FamiliaPackEN Convert (FamiliaPackDTO dto)
        {
                FamiliaPackEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new FamiliaPackEN ();



                                newinstance.IdFamPack = dto.IdFamPack;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Codigo = dto.Codigo;
                                newinstance.Color = dto.Color;
                                if (dto.Pack_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD packCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD ();

                                        newinstance.Pack = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN>();
                                        foreach (int entry in dto.Pack_oid) {
                                                newinstance.Pack.Add (packCAD.ReadOIDDefault (entry));
                                        }
                                }
                                if (dto.TipoEstancia_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD tipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD ();

                                        newinstance.TipoEstancia = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN>();
                                        foreach (int entry in dto.TipoEstancia_oid) {
                                                newinstance.TipoEstancia.Add (tipoEstanciaCAD.ReadOIDDefault (entry));
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
