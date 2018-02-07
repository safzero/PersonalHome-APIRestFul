
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;

namespace PersonalHomeGen_PersonalHomeWCF.AdaptersEN.PersonalHome
{
        public class AdminDTOENAdapter {
        public static AdminEN Convert (AdminDTO dto)
        {
                AdminEN newinstance = null;

                try
                {
                        if (dto != null) {
                                newinstance = new AdminEN ();



                                newinstance.IdAdmin = dto.IdAdmin;
                                newinstance.Email = dto.Email;
                                newinstance.Passwd = dto.Passwd;
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
