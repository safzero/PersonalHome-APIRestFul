using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using NHibernate;
using PersonalHomeGenNHibernate.CAD;
using ApiRestFulPH.Clases;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Services;

namespace ApiRestFulPH
{

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        
        public bool Usuario(Usuario data)
        {
            bool retorno = false;
            UsuarioDTO usuarioDTO;

            //Usuario user = JsonConvert.DeserializeObject<Usuario>(data.ToString());

            //string tipo=data.GetType().GetProperty("idUsuario").ToString();
            JsonSerializer serializer = new JsonSerializer();
           // Usuario usuario = serializer.Deserialize(data);
            retorno = true;
           /* switch (action)
            {
                case "update":
                    if (type == "name") {

                        usuarioDTO = new UsuarioDTO();            
                        usuarioDTO = PersonalHome_Usuario_DamePorID(data.IdUsuario);
                        PersonalHome_Usuario_Modificar(data.IdUsuario, data.Nombre, usuarioDTO.Email, usuarioDTO.Telefono, usuarioDTO.Passwd);
                    }
                    if (type=="email")
                    {
                        usuarioDTO = new UsuarioDTO();
                        usuarioDTO = PersonalHome_Usuario_DamePorID(data.IdUsuario);
                        PersonalHome_Usuario_Modificar(data.IdUsuario, usuarioDTO.Nombre, data.Email, usuarioDTO.Telefono, usuarioDTO.Passwd);
                    }
                    break;
                default:
                    break;
            }*/

            return retorno;
        }
        public void PersonalHome_Variable_Eliminar(int p_Variable_OID)
        {
            PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD(session);
                    variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN(_IvariableCAD);

                    variableCEN.Eliminar(p_Variable_OID);
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO> PersonalHome_Variable_DameTodas()
        {
            System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO> variableDTOs = null;


            System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> variableENs = null;

            PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    variableDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO>();


                    variableENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN>();
                    _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD(session);
                    variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN(_IvariableCAD);
                    variableENs = variableCEN.DameTodas(0, -1);
                    if (variableENs != null)
                    {
                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN item in variableENs)
                        {
                            variableDTOs.Add(PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VariableAdapter.Convert(item));
                        }
                    }
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return variableDTOs;
        }

       
        public int PersonalHome_Usuario_Crear(String p_nombre, String p_email, String p_telefono, String p_passwd)
        {
            PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
            int returnValue = -1;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD(session);
                    usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN(_IusuarioCAD);

                    returnValue = usuarioCEN.Crear(p_nombre, p_email, p_telefono, p_passwd);
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        

        public void PersonalHome_Usuario_Modificar(int p_Usuario_OID, String p_nombre, String p_email, String p_telefono, String p_passwd)
        {
            PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD(session);
                    usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN(_IusuarioCAD);

                    usuarioCEN.Modificar(p_Usuario_OID, p_nombre, p_email, p_telefono, p_passwd);
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public void PersonalHome_Usuario_Eliminar(int p_Usuario_OID)
        {
            PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD(session);
                    usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN(_IusuarioCAD);

                    usuarioCEN.Eliminar(p_Usuario_OID);
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public UsuarioDTO PersonalHome_Usuario_DamePorID(int p_Usuario_OID)
        {
            PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO usuarioDTO = null;

            PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN usuarioEN = null;

            PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    usuarioDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO();

                    usuarioEN = new PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN();
                    _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD(session);
                    usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN(_IusuarioCAD);
                    usuarioEN = usuarioCEN.DamePorID(p_Usuario_OID);
                    usuarioDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.UsuarioAdapter.Convert(usuarioEN);
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return usuarioDTO;
        }



        public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO> PersonalHome_Usuario_DameTodos()
        {
            System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO> usuarioDTOs = null;


            System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN> usuarioENs = null;

            PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    usuarioDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO>();


                    usuarioENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN>();
                    _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD(session);
                    usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN(_IusuarioCAD);
                    usuarioENs = usuarioCEN.DameTodos(0, -1);
                    if (usuarioENs != null)
                    {
                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN item in usuarioENs)
                        {
                            usuarioDTOs.Add(PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.UsuarioAdapter.Convert(item));
                        }
                    }
                    tx.Commit();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return usuarioDTOs;
        }


    }
}
