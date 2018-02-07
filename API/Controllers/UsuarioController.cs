using API.Models;
using NHibernate;
using PersonalHomeGenNHibernate.CAD;
using PersonalHomeGenNHibernate.CAD.PersonalHome;
using PersonalHomeGenNHibernate.CEN.PersonalHome;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UsuarioController : ApiController
    {
       
        [HttpPost]
        public string Usuarios(DataUser datos)
        {
            string retorno="";
            
            switch (datos.Action)
            {
                case "create":
                    break;
                case "update":
                    break;
                case "search":
                    break;
                case "link":
                    break;
                case "unlink":
                    break;
            }

            return retorno;
        }

        [HttpPost]
        public string Create (DataUser datos)
        {
            string retorno = "ko";
            PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD(session);
                    adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN(_IadminCAD);

                    adminCEN.CrearAdmin(datos.User.Email, datos.User.Passwd, datos.User.Nombre);
                    tx.Commit();
                    retorno = "ok";
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        [HttpGet]
        public IList<AdminEN> GetAll ()
        {
            IList<AdminEN> administradores = new List<AdminEN>();

            PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
            PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction tx = session.BeginTransaction())
                {
                    _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD(session);
                    adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN(_IadminCAD);

                    administradores = adminCEN.DameTodos(0, -1);
                    tx.Commit();
                    
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return administradores;
        }
    }
}
