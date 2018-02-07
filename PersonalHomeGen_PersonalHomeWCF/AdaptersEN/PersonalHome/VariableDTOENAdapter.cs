
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class VariableDTOENAdapter {
        public static VariableEN Convert (VariableDTO dto)
        {
                VariableEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new VariableEN ();



                                newinstance.IdVariable = dto.IdVariable;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Caracteristicas = dto.Caracteristicas;
                                newinstance.Precio = dto.Precio;
                                newinstance.Imagen = dto.Imagen;
                                newinstance.Iva = dto.Iva;
                                newinstance.Miniatura = dto.Miniatura;
                                if (dto.Pack_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD packCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD ();

                                        newinstance.Pack = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN>();
                                        foreach (int entry in dto.Pack_oid) {
                                                newinstance.Pack.Add (packCAD.ReadOIDDefault (entry));
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
