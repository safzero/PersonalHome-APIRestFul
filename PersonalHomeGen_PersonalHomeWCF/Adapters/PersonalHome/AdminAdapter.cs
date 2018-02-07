
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome
{
        public class AdminAdapter {
        public static AdminDTO Convert (AdminEN en)
        {
                AdminDTO newinstance = null;

                if (en != null) {
                        newinstance = new AdminDTO ();



                        newinstance.IdAdmin = en.IdAdmin;
                        newinstance.Email = en.Email;
                        newinstance.Passwd = en.Passwd;
                        newinstance.Nombre = en.Nombre;
                }

                return newinstance;
        }
        }
}
