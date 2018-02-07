
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class ProyectoDTOENAdapter {
        public static ProyectoEN Convert (ProyectoDTO dto)
        {
                ProyectoEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new ProyectoEN ();



                                newinstance.IdProyecto = dto.IdProyecto;
                                newinstance.Variables = dto.Variables;
                                if (dto.Usuario_oid != -1) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD usuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD ();

                                        newinstance.Usuario = usuarioCAD.ReadOIDDefault (dto.Usuario_oid);
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
