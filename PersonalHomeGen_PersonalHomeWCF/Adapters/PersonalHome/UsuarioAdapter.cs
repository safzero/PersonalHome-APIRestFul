
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class UsuarioAdapter {
        public static UsuarioDTO Convert (UsuarioEN en)
        {
                UsuarioDTO newinstance = null;

                if (en != null) {
                        newinstance = new UsuarioDTO ();



                        newinstance.IdUsuario = en.IdUsuario;
                        newinstance.Nombre = en.Nombre;
                        newinstance.Email = en.Email;
                        newinstance.Telefono = en.Telefono;
                        newinstance.Passwd = en.Passwd;
                        if (en.Proyecto != null) {
                                newinstance.Proyecto_oid = new System.Collections.Generic.List<Int32>();
                                foreach (PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN entry in en.Proyecto)
                                        newinstance.Proyecto_oid.Add (entry.IdProyecto);
                        }
                }

                return newinstance;
        }
        }
}
