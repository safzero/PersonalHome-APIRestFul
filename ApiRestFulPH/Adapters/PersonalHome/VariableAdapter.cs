
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class VariableAdapter {
        public static VariableDTO Convert (VariableEN en)
        {
                VariableDTO newinstance = null;

                if (en != null) {
                        newinstance = new VariableDTO ();



                        newinstance.IdVariable = en.IdVariable;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Caracteristicas = en.Caracteristicas;
                        newinstance.Precio = en.Precio;
                        newinstance.Imagen = en.Imagen;
                        newinstance.Iva = en.Iva;
                        newinstance.Miniatura = en.Miniatura;
                        if (en.Pack != null) {
                                newinstance.Pack_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.PackEN entry in en.Pack)
                                        newinstance.Pack_oid.Add (entry.IdPack);
                        }
                }

                return newinstance;
        }
        }
}
