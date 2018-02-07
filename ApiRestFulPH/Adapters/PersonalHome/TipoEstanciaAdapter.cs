
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class TipoEstanciaAdapter {
        public static TipoEstanciaDTO Convert (TipoEstanciaEN en)
        {
                TipoEstanciaDTO newinstance = null;

                if (en != null) {
                        newinstance = new TipoEstanciaDTO ();



                        newinstance.IdTipoEstancia = en.IdTipoEstancia;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Descripcion = en.Descripcion;
                        newinstance.Imagen = en.Imagen;
                        if (en.FamiliaPack != null) {
                                newinstance.FamiliaPack_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN entry in en.FamiliaPack)
                                        newinstance.FamiliaPack_oid.Add (entry.IdFamPack);
                        }
                        if (en.Estancia != null) {
                                newinstance.Estancia_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN entry in en.Estancia)
                                        newinstance.Estancia_oid.Add (entry.IdEstancia);
                        }
                }

                return newinstance;
        }
        }
}
