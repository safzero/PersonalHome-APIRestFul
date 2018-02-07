
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class PackAdapter {
        public static PackDTO Convert (PackEN en)
        {
                PackDTO newinstance = null;

                if (en != null) {
                        newinstance = new PackDTO ();



                        newinstance.IdPack = en.IdPack;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Familia = en.Familia;
                        newinstance.Descripción = en.Descripción;
                        newinstance.Color = en.Color;
                        newinstance.Codigo = en.Codigo;
                        if (en.Variable != null) {
                                newinstance.Variable_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN entry in en.Variable)
                                        newinstance.Variable_oid.Add (entry.IdVariable);
                        }
                        if (en.FamiliaPack != null) {
                                newinstance.FamiliaPack_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN entry in en.FamiliaPack)
                                        newinstance.FamiliaPack_oid.Add (entry.IdFamPack);
                        }
                }

                return newinstance;
        }
        }
}
