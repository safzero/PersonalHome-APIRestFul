
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class PackDTOENAdapter {
        public static PackEN Convert (PackDTO dto)
        {
                PackEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new PackEN ();



                                newinstance.IdPack = dto.IdPack;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Familia = dto.Familia;
                                newinstance.Descripción = dto.Descripción;
                                newinstance.Color = dto.Color;
                                newinstance.Codigo = dto.Codigo;
                                if (dto.Variable_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD variableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD ();

                                        newinstance.Variable = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN>();
                                        foreach (int entry in dto.Variable_oid) {
                                                newinstance.Variable.Add (variableCAD.ReadOIDDefault (entry));
                                        }
                                }
                                if (dto.FamiliaPack_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD familiaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD ();

                                        newinstance.FamiliaPack = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN>();
                                        foreach (int entry in dto.FamiliaPack_oid) {
                                                newinstance.FamiliaPack.Add (familiaPackCAD.ReadOIDDefault (entry));
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
