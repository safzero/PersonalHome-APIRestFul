
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class UsuarioDTOENAdapter {
        public static UsuarioEN Convert (UsuarioDTO dto)
        {
                UsuarioEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new UsuarioEN ();



                                newinstance.IdUsuario = dto.IdUsuario;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Email = dto.Email;
                                newinstance.Telefono = dto.Telefono;
                                newinstance.Passwd = dto.Passwd;
                                if (dto.Proyecto_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD proyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD ();

                                        newinstance.Proyecto = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN>();
                                        foreach (int entry in dto.Proyecto_oid) {
                                                newinstance.Proyecto.Add (proyectoCAD.ReadOIDDefault (entry));
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
