
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IAdminCAD
        {
        AdminEN ReadOIDDefault (int idAdmin);

        int CrearAdmin (AdminEN admin);

        void ModificarAdmin (AdminEN admin);


        void EliminarAdmin (int idAdmin);


        AdminEN DamePorID (int idAdmin);


        System.Collections.Generic.IList<AdminEN> DameTodos (int first, int size);


        System.Collections.Generic.IList<AdminEN> DamePorEmail (String p_email);


        System.Collections.Generic.IList<AdminEN> DamePorEmailPassword (String p_email, String p_passwd);
        }
}
