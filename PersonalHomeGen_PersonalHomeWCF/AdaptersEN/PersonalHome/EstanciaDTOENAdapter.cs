
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class EstanciaDTOENAdapter {
        public static EstanciaEN Convert (EstanciaDTO dto)
        {
                EstanciaEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new EstanciaEN ();



                                newinstance.IdEstancia = dto.IdEstancia;
                                newinstance.Nombre = dto.Nombre;
                                newinstance.Descripcion = dto.Descripcion;
                                newinstance.Codigo = dto.Codigo;
                                newinstance.Plano = dto.Plano;
                                if (dto.TipoEstancia_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD tipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD ();

                                        newinstance.TipoEstancia = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN>();
                                        foreach (int entry in dto.TipoEstancia_oid) {
                                                newinstance.TipoEstancia.Add (tipoEstanciaCAD.ReadOIDDefault (entry));
                                        }
                                }
                                if (dto.Vista_oid != null) {
                                        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD vistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD ();

                                        newinstance.Vista = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN>();
                                        foreach (int entry in dto.Vista_oid) {
                                                newinstance.Vista.Add (vistaCAD.ReadOIDDefault (entry));
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
