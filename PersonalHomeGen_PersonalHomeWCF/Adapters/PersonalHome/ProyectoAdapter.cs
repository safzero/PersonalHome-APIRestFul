
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class ProyectoAdapter {
        public static ProyectoDTO Convert (ProyectoEN en)
        {
                ProyectoDTO newinstance = null;

                if (en != null) {
                        newinstance = new ProyectoDTO ();



                        newinstance.IdProyecto = en.IdProyecto;
                        newinstance.Variables = en.Variables;
                        if (en.Usuario != null) {
                                newinstance.Usuario_oid = en.Usuario.IdUsuario;
                        }
                }

                return newinstance;
        }
        }
}
