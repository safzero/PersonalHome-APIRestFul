
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class FamiliaPackAdapter {
        public static FamiliaPackDTO Convert (FamiliaPackEN en)
        {
                FamiliaPackDTO newinstance = null;

                if (en != null) {
                        newinstance = new FamiliaPackDTO ();



                        newinstance.IdFamPack = en.IdFamPack;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Codigo = en.Codigo;
                        newinstance.Color = en.Color;
                        if (en.Pack != null) {
                                newinstance.Pack_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.PackEN entry in en.Pack)
                                        newinstance.Pack_oid.Add (entry.IdPack);
                        }
                        if (en.TipoEstancia != null) {
                                newinstance.TipoEstancia_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN entry in en.TipoEstancia)
                                        newinstance.TipoEstancia_oid.Add (entry.IdTipoEstancia);
                        }
                }

                return newinstance;
        }
        }
}
