

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGenNHibernate.CAD.PersonalHome;

namespace PersonalHomeGenNHibernate.CEN.PersonalHome
{
        public partial class AdminCEN
        {
        private IAdminCAD _IAdminCAD;

        public AdminCEN(IAdminCAD _IAdminCAD)
        {
                this._IAdminCAD = _IAdminCAD;
        }

        public int CrearAdmin (String p_email, String p_passwd, String p_nombre)
        {
                AdminEN adminEN = null;
                int oid;

                //Initialized AdminEN
                adminEN = new AdminEN ();
                adminEN.Email = p_email;
                adminEN.Passwd = p_passwd;
                adminEN.Nombre = p_nombre;
                //Call to AdminCAD

                oid = _IAdminCAD.CrearAdmin (adminEN);
                return oid;
        }

        public void ModificarAdmin (int p_Admin_OID, String p_email, String p_passwd, String p_nombre)
        {
                AdminEN adminEN = null;

                //Initialized AdminEN
                adminEN = new AdminEN ();
                adminEN.IdAdmin = p_Admin_OID;
                adminEN.Email = p_email;
                adminEN.Passwd = p_passwd;
                adminEN.Nombre = p_nombre;
                //Call to AdminCAD

                _IAdminCAD.ModificarAdmin (adminEN);
        }

        public void EliminarAdmin (int idAdmin)
        {
                _IAdminCAD.EliminarAdmin (
                        idAdmin

                        );
        }

        public AdminEN DamePorID (int idAdmin)
        {
                AdminEN adminEN = null;

                adminEN = _IAdminCAD.DamePorID (
                        idAdmin

                        );
                return adminEN;
        }

        public System.Collections.Generic.IList<AdminEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<AdminEN> list = null;

                list = _IAdminCAD.DameTodos (first, size);
                return list;
        }
        public System.Collections.Generic.IList<AdminEN> DamePorEmail (String p_email)
        {
                return _IAdminCAD.DamePorEmail (p_email);
        }
        public System.Collections.Generic.IList<AdminEN> DamePorEmailPassword (String p_email, String p_passwd)
        {
                return _IAdminCAD.DamePorEmailPassword (p_email, p_passwd);
        }
        }
}
