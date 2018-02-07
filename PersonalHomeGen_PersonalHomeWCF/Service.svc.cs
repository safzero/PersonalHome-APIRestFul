using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using NHibernate;
using PersonalHomeGenNHibernate.CAD;

namespace PersonalHomeGen_PersonalHomeWCF
{
[ServiceContract (Namespace = "http://Service/")]
[AspNetCompatibilityRequirements (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Service
{
/*PROTECTED REGION ID(PersonalHomeGen_PersonalHomeWCF_Other_Operations) ENABLED START*/

/*PROTECTED REGION END*/



[OperationContract]

public void PersonalHome_Admin_EliminarAdmin (int p_Admin_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD (session);
                                adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN (_IadminCAD);

                                adminCEN.EliminarAdmin (p_Admin_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.AdminDTO PersonalHome_Admin_DamePorID (int p_Admin_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.AdminDTO adminDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.AdminEN adminEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                adminDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.AdminDTO ();

                                adminEN = new PersonalHomeGenNHibernate.EN.PersonalHome.AdminEN ();
                                _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD (session);
                                adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN (_IadminCAD);
                                adminEN = adminCEN.DamePorID (p_Admin_OID);
                                adminDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.AdminAdapter.Convert (adminEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return adminDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.AdminDTO> PersonalHome_Admin_DameTodos ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.AdminDTO> adminDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.AdminEN> adminENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                adminDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.AdminDTO>();


                                adminENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.AdminEN>();
                                _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD (session);
                                adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN (_IadminCAD);
                                adminENs = adminCEN.DameTodos (0, -1);
                                if (adminENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.AdminEN item in adminENs) {
                                                adminDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.AdminAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return adminDTOs;
}




[OperationContract]
public int PersonalHome_Admin_CrearAdmin (String p_email, String p_passwd, String p_nombre)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD (session);
                                adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN (_IadminCAD);

                                returnValue = adminCEN.CrearAdmin (p_email, p_passwd, p_nombre);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Admin_ModificarAdmin (int p_Admin_OID, String p_email, String p_passwd, String p_nombre)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN adminCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IAdminCAD _IadminCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IadminCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.AdminCAD (session);
                                adminCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.AdminCEN (_IadminCAD);

                                adminCEN.ModificarAdmin (p_Admin_OID, p_email, p_passwd, p_nombre);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}




[OperationContract]

public void PersonalHome_Variable_Eliminar (int p_Variable_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);

                                variableCEN.Eliminar (p_Variable_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO PersonalHome_Variable_DamePorID (int p_Variable_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO variableDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN variableEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                variableDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO ();

                                variableEN = new PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN ();
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);
                                variableEN = variableCEN.DamePorID (p_Variable_OID);
                                variableDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VariableAdapter.Convert (variableEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return variableDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO> PersonalHome_Variable_DameTodas ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO> variableDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> variableENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                variableDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO>();


                                variableENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN>();
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);
                                variableENs = variableCEN.DameTodas (0, -1);
                                if (variableENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN item in variableENs) {
                                                variableDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VariableAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return variableDTOs;
}




[OperationContract]

public void PersonalHome_Variable_AsignarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);

                                variableCEN.AsignarPack (p_Variable_OID, p_pack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Variable_QuitarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);

                                variableCEN.QuitarPack (p_Variable_OID, p_pack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]
public int PersonalHome_Variable_Crear (String p_nombre, String p_caracteristicas, double p_precio, String p_imagen, int p_iva, String p_miniatura)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);

                                returnValue = variableCEN.Crear (p_nombre, p_caracteristicas, p_precio, p_imagen, p_iva, p_miniatura);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Variable_Modificar (int p_Variable_OID, String p_nombre, String p_caracteristicas, double p_precio, String p_imagen, int p_iva, String p_miniatura)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN variableCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD _IvariableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvariableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                variableCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VariableCEN (_IvariableCAD);

                                variableCEN.Modificar (p_Variable_OID, p_nombre, p_caracteristicas, p_precio, p_imagen, p_iva, p_miniatura);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO> PersonalHome_Variable_GetAllPackOfVariable (int idVariable)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVariableCAD variableCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                variableCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VariableCAD (session);
                                en = variableCAD.GetAllPackOfVariable_PersonalHome (idVariable);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.PackEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.PackAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_Pack_Crear (String p_nombre, String p_familia, String p_descripción, String p_color, String p_codigo)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                returnValue = packCEN.Crear (p_nombre, p_familia, p_descripción, p_color, p_codigo);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Pack_Modificar (int p_Pack_OID, String p_nombre, String p_familia, String p_descripción, String p_color, String p_codigo)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                packCEN.Modificar (p_Pack_OID, p_nombre, p_familia, p_descripción, p_color, p_codigo);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Pack_Eliminar (int p_Pack_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                packCEN.Eliminar (p_Pack_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO PersonalHome_Pack_DamePorID (int p_Pack_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO packDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.PackEN packEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                packDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO ();

                                packEN = new PersonalHomeGenNHibernate.EN.PersonalHome.PackEN ();
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);
                                packEN = packCEN.DamePorID (p_Pack_OID);
                                packDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.PackAdapter.Convert (packEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return packDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO> PersonalHome_Pack_DameTodos ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO> packDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> packENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                packDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO>();


                                packENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN>();
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);
                                packENs = packCEN.DameTodos (0, -1);
                                if (packENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.PackEN item in packENs) {
                                                packDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.PackAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return packDTOs;
}




[OperationContract]

public void PersonalHome_Pack_AsignarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                packCEN.AsignarVariable (p_Pack_OID, p_variable_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Pack_QuitarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                packCEN.QuitarVariable (p_Pack_OID, p_variable_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Pack_AsignarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                packCEN.AsignarFamiliaPack (p_Pack_OID, p_familiaPack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Pack_QuitarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN packCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD _IpackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IpackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                packCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.PackCEN (_IpackCAD);

                                packCEN.QuitarFamiliaPack (p_Pack_OID, p_familiaPack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO> PersonalHome_Pack_GetAllVariableOfPack (int idPack)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD packCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                packCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                en = packCAD.GetAllVariableOfPack_PersonalHome (idPack);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VariableDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VariableEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VariableAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}




[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO> PersonalHome_Pack_GetAllFamiliaPackOfPack (int idPack)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IPackCAD packCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                packCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.PackCAD (session);
                                en = packCAD.GetAllFamiliaPackOfPack_PersonalHome (idPack);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.FamiliaPackAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_FamiliaPack_Crear (String p_nombre, String p_codigo, String p_color)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                returnValue = familiaPackCEN.Crear (p_nombre, p_codigo, p_color);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_FamiliaPack_Modificar (int p_FamiliaPack_OID, String p_nombre, String p_codigo, String p_color)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                familiaPackCEN.Modificar (p_FamiliaPack_OID, p_nombre, p_codigo, p_color);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_FamiliaPack_Eliminar (int p_FamiliaPack_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                familiaPackCEN.Eliminar (p_FamiliaPack_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO PersonalHome_FamiliaPack_DamePorID (int p_FamiliaPack_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO familiaPackDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN familiaPackEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                familiaPackDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO ();

                                familiaPackEN = new PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN ();
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);
                                familiaPackEN = familiaPackCEN.DamePorID (p_FamiliaPack_OID);
                                familiaPackDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.FamiliaPackAdapter.Convert (familiaPackEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return familiaPackDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO> PersonalHome_FamiliaPack_DameTodas ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO> familiaPackDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> familiaPackENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                familiaPackDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO>();


                                familiaPackENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN>();
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);
                                familiaPackENs = familiaPackCEN.DameTodas (0, -1);
                                if (familiaPackENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN item in familiaPackENs) {
                                                familiaPackDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.FamiliaPackAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return familiaPackDTOs;
}




[OperationContract]

public void PersonalHome_FamiliaPack_AsignarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                familiaPackCEN.AsignarPack (p_FamiliaPack_OID, p_pack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_FamiliaPack_QuitarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                familiaPackCEN.QuitarPack (p_FamiliaPack_OID, p_pack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_FamiliaPack_AsignarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                familiaPackCEN.AsignarTipoEstancia (p_FamiliaPack_OID, p_tipoEstancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_FamiliaPack_QuitarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN familiaPackCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD _IfamiliaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IfamiliaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                familiaPackCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.FamiliaPackCEN (_IfamiliaPackCAD);

                                familiaPackCEN.QuitarTipoEstancia (p_FamiliaPack_OID, p_tipoEstancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO> PersonalHome_FamiliaPack_GetAllPackOfFamiliaPack (int idFamPack)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.PackEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD familiaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                familiaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                en = familiaPackCAD.GetAllPackOfFamiliaPack_PersonalHome (idFamPack);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.PackDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.PackEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.PackAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}




[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO> PersonalHome_FamiliaPack_GetAllTipoEstanciaOfFamiliaPack (int idFamPack)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IFamiliaPackCAD familiaPackCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                familiaPackCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.FamiliaPackCAD (session);
                                en = familiaPackCAD.GetAllTipoEstanciaOfFamiliaPack_PersonalHome (idFamPack);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.TipoEstanciaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_Estancia_Crear (String p_nombre, String p_descripcion, String p_codigo, String p_plano)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                returnValue = estanciaCEN.Crear (p_nombre, p_descripcion, p_codigo, p_plano);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Estancia_Modificar (int p_Estancia_OID, String p_nombre, String p_descripcion, String p_codigo, String p_plano)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                estanciaCEN.Modificar (p_Estancia_OID, p_nombre, p_descripcion, p_codigo, p_plano);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Estancia_Eliminar (int p_Estancia_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                estanciaCEN.Eliminar (p_Estancia_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO PersonalHome_Estancia_DamePorID (int p_Estancia_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO estanciaDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN estanciaEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                estanciaDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO ();

                                estanciaEN = new PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN ();
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);
                                estanciaEN = estanciaCEN.DamePorID (p_Estancia_OID);
                                estanciaDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.EstanciaAdapter.Convert (estanciaEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return estanciaDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO> PersonalHome_Estancia_DameTodas ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO> estanciaDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> estanciaENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                estanciaDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO>();


                                estanciaENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN>();
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);
                                estanciaENs = estanciaCEN.DameTodas (0, -1);
                                if (estanciaENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN item in estanciaENs) {
                                                estanciaDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.EstanciaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return estanciaDTOs;
}




[OperationContract]

public void PersonalHome_Estancia_AsignarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                estanciaCEN.AsignarTipoEstancia (p_Estancia_OID, p_tipoEstancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Estancia_QuitarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                estanciaCEN.QuitarTipoEstancia (p_Estancia_OID, p_tipoEstancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Estancia_AsignarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                estanciaCEN.AsignarVista (p_Estancia_OID, p_vista_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Estancia_QuitarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN estanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD _IestanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IestanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                estanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.EstanciaCEN (_IestanciaCAD);

                                estanciaCEN.QuitarVista (p_Estancia_OID, p_vista_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO> PersonalHome_Estancia_GetAllTipoEstanciaOfEstancia (int idEstancia)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD estanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                estanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                en = estanciaCAD.GetAllTipoEstanciaOfEstancia_PersonalHome (idEstancia);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.TipoEstanciaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}




[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO> PersonalHome_Estancia_GetAllVistaOfEstancia (int idEstancia)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IEstanciaCAD estanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                estanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.EstanciaCAD (session);
                                en = estanciaCAD.GetAllVistaOfEstancia_PersonalHome (idEstancia);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VistaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_Vista_Crear (String p_nombre)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                returnValue = vistaCEN.Crear (p_nombre);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Vista_Modificar (int p_Vista_OID, String p_nombre)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                vistaCEN.Modificar (p_Vista_OID, p_nombre);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Vista_Eliminar (int p_Vista_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                vistaCEN.Eliminar (p_Vista_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO PersonalHome_Vista_DamePorID (int p_Vista_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO vistaDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN vistaEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                vistaDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO ();

                                vistaEN = new PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN ();
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);
                                vistaEN = vistaCEN.DamePorID (p_Vista_OID);
                                vistaDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VistaAdapter.Convert (vistaEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return vistaDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO> PersonalHome_Vista_DameTodas ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO> vistaDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> vistaENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                vistaDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO>();


                                vistaENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN>();
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);
                                vistaENs = vistaCEN.DameTodas (0, -1);
                                if (vistaENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN item in vistaENs) {
                                                vistaDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VistaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return vistaDTOs;
}




[OperationContract]

public void PersonalHome_Vista_AsignarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                vistaCEN.AsignarEstancia (p_Vista_OID, p_estancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Vista_QuitarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                vistaCEN.QuitarEstancia (p_Vista_OID, p_estancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Vista_AsignarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                vistaCEN.AsignarInmueble (p_Vista_OID, p_inmueble_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Vista_QuitarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN vistaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD _IvistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IvistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                vistaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.VistaCEN (_IvistaCAD);

                                vistaCEN.QuitarInmueble (p_Vista_OID, p_inmueble_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO> PersonalHome_Vista_GetAllEstanciaOfVista (int idVista)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD vistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                vistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                en = vistaCAD.GetAllEstanciaOfVista_PersonalHome (idVista);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.EstanciaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}




[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO> PersonalHome_Vista_GetAllInmuebleOfVista (int idVista)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IVistaCAD vistaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                vistaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.VistaCAD (session);
                                en = vistaCAD.GetAllInmuebleOfVista_PersonalHome (idVista);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.InmuebleAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]

public void PersonalHome_Inmueble_Eliminar (int p_Inmueble_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);

                                inmuebleCEN.Eliminar (p_Inmueble_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO PersonalHome_Inmueble_DamePorID (int p_Inmueble_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO inmuebleDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN inmuebleEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                inmuebleDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO ();

                                inmuebleEN = new PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN ();
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);
                                inmuebleEN = inmuebleCEN.DamePorID (p_Inmueble_OID);
                                inmuebleDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.InmuebleAdapter.Convert (inmuebleEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return inmuebleDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO> PersonalHome_Inmueble_DameTodos ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO> inmuebleDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN> inmuebleENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                inmuebleDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.InmuebleDTO>();


                                inmuebleENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN>();
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);
                                inmuebleENs = inmuebleCEN.DameTodos (0, -1);
                                if (inmuebleENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.InmuebleEN item in inmuebleENs) {
                                                inmuebleDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.InmuebleAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return inmuebleDTOs;
}




[OperationContract]

public void PersonalHome_Inmueble_AsignarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);

                                inmuebleCEN.AsignarVista (p_Inmueble_OID, p_vista_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Inmueble_QuitarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);

                                inmuebleCEN.QuitarVista (p_Inmueble_OID, p_vista_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]
public int PersonalHome_Inmueble_Crear (String p_nombre, double p_superficie, int p_dormitorios, int p_aseos, double p_importeDesde, double p_iva, String p_imagen, String p_plano, bool p_recomendado)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);

                                returnValue = inmuebleCEN.Crear (p_nombre, p_superficie, p_dormitorios, p_aseos, p_importeDesde, p_iva, p_imagen, p_plano, p_recomendado);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Inmueble_Modificar (int p_Inmueble_OID, String p_nombre, double p_superficie, int p_dormitorios, int p_aseos, double p_importeDesde, double p_iva, String p_imagen, String p_plano, bool p_recomendado)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN inmuebleCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD _IinmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IinmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                inmuebleCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.InmuebleCEN (_IinmuebleCAD);

                                inmuebleCEN.Modificar (p_Inmueble_OID, p_nombre, p_superficie, p_dormitorios, p_aseos, p_importeDesde, p_iva, p_imagen, p_plano, p_recomendado);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO> PersonalHome_Inmueble_GetAllVistaOfInmueble (int idInmueble)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IInmuebleCAD inmuebleCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                inmuebleCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.InmuebleCAD (session);
                                en = inmuebleCAD.GetAllVistaOfInmueble_PersonalHome (idInmueble);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.VistaDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.VistaEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.VistaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_TipoEstancia_Crear (String p_nombre, String p_descripcion, String p_imagen)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                returnValue = tipoEstanciaCEN.Crear (p_nombre, p_descripcion, p_imagen);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_TipoEstancia_Modificar (int p_TipoEstancia_OID, String p_nombre, String p_descripcion, String p_imagen)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                tipoEstanciaCEN.Modificar (p_TipoEstancia_OID, p_nombre, p_descripcion, p_imagen);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_TipoEstancia_Eliminar (int p_TipoEstancia_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                tipoEstanciaCEN.Eliminar (p_TipoEstancia_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO PersonalHome_TipoEstancia_DamePorID (int p_TipoEstancia_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO tipoEstanciaDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN tipoEstanciaEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                tipoEstanciaDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO ();

                                tipoEstanciaEN = new PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN ();
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);
                                tipoEstanciaEN = tipoEstanciaCEN.DamePorID (p_TipoEstancia_OID);
                                tipoEstanciaDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.TipoEstanciaAdapter.Convert (tipoEstanciaEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return tipoEstanciaDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO> PersonalHome_TipoEstancia_DameTodos ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO> tipoEstanciaDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN> tipoEstanciaENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                tipoEstanciaDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.TipoEstanciaDTO>();


                                tipoEstanciaENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN>();
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);
                                tipoEstanciaENs = tipoEstanciaCEN.DameTodos (0, -1);
                                if (tipoEstanciaENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.TipoEstanciaEN item in tipoEstanciaENs) {
                                                tipoEstanciaDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.TipoEstanciaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return tipoEstanciaDTOs;
}




[OperationContract]

public void PersonalHome_TipoEstancia_AsignarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                tipoEstanciaCEN.AsignarFamiliaPack (p_TipoEstancia_OID, p_familiaPack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_TipoEstancia_QuitarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                tipoEstanciaCEN.QuitarFamiliaPack (p_TipoEstancia_OID, p_familiaPack_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_TipoEstancia_AsignarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                tipoEstanciaCEN.AsignarEstancia (p_TipoEstancia_OID, p_estancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_TipoEstancia_QuitarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN tipoEstanciaCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD _ItipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _ItipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                tipoEstanciaCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.TipoEstanciaCEN (_ItipoEstanciaCAD);

                                tipoEstanciaCEN.QuitarEstancia (p_TipoEstancia_OID, p_estancia_OIDs);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}



[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO> PersonalHome_TipoEstancia_GetAllFamiliaPackOfTipoEstancia (int idTipoEstancia)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD tipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                tipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                en = tipoEstanciaCAD.GetAllFamiliaPackOfTipoEstancia_PersonalHome (idTipoEstancia);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.FamiliaPackDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.FamiliaPackEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.FamiliaPackAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}




[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO> PersonalHome_TipoEstancia_GetAllEstanciaOfTipoEstancia (int idTipoEstancia)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.ITipoEstanciaCAD tipoEstanciaCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                tipoEstanciaCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.TipoEstanciaCAD (session);
                                en = tipoEstanciaCAD.GetAllEstanciaOfTipoEstancia_PersonalHome (idTipoEstancia);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.EstanciaDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.EstanciaEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.EstanciaAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_Usuario_Crear (String p_nombre, String p_email, String p_telefono, String p_passwd)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD (session);
                                usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN (_IusuarioCAD);

                                returnValue = usuarioCEN.Crear (p_nombre, p_email, p_telefono, p_passwd);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Usuario_Modificar (int p_Usuario_OID, String p_nombre, String p_email, String p_telefono, String p_passwd)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD (session);
                                usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN (_IusuarioCAD);

                                usuarioCEN.Modificar (p_Usuario_OID, p_nombre, p_email, p_telefono, p_passwd);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Usuario_Eliminar (int p_Usuario_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD (session);
                                usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN (_IusuarioCAD);

                                usuarioCEN.Eliminar (p_Usuario_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO PersonalHome_Usuario_DamePorID (int p_Usuario_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO usuarioDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN usuarioEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                usuarioDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO ();

                                usuarioEN = new PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN ();
                                _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD (session);
                                usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN (_IusuarioCAD);
                                usuarioEN = usuarioCEN.DamePorID (p_Usuario_OID);
                                usuarioDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.UsuarioAdapter.Convert (usuarioEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return usuarioDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO> PersonalHome_Usuario_DameTodos ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO> usuarioDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN> usuarioENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN usuarioCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD _IusuarioCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                usuarioDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO>();


                                usuarioENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN>();
                                _IusuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD (session);
                                usuarioCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.UsuarioCEN (_IusuarioCAD);
                                usuarioENs = usuarioCEN.DameTodos (0, -1);
                                if (usuarioENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN item in usuarioENs) {
                                                usuarioDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.UsuarioAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return usuarioDTOs;
}





[OperationContract]
public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO> PersonalHome_Usuario_GetAllProyectoOfUsuario (int idUsuario)
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO> dto = null;
        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IUsuarioCAD usuarioCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                usuarioCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.UsuarioCAD (session);
                                en = usuarioCAD.GetAllProyectoOfUsuario_PersonalHome (idUsuario);
                                if (en != null) {
                                        dto = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO>();
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN item in en) {
                                                dto.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.ProyectoAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}





[OperationContract]
public int PersonalHome_Proyecto_Crear (String p_variables, int p_usuario)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN proyectoCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD _IproyectoCAD = null;
        int returnValue = -1;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IproyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD (session);
                                proyectoCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN (_IproyectoCAD);

                                returnValue = proyectoCEN.Crear (p_variables, p_usuario);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return returnValue;
}



[OperationContract]

public void PersonalHome_Proyecto_Modificar (int p_Proyecto_OID, String p_variables)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN proyectoCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD _IproyectoCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IproyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD (session);
                                proyectoCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN (_IproyectoCAD);

                                proyectoCEN.Modificar (p_Proyecto_OID, p_variables);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public void PersonalHome_Proyecto_Eliminar (int p_Proyecto_OID)
{
        PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN proyectoCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD _IproyectoCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                _IproyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD (session);
                                proyectoCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN (_IproyectoCAD);

                                proyectoCEN.Eliminar (p_Proyecto_OID);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }
}


[OperationContract]

public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO PersonalHome_Proyecto_DamePorID (int p_Proyecto_OID)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO proyectoDTO = null;

        PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN proyectoEN = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN proyectoCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD _IproyectoCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                proyectoDTO = new PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO ();

                                proyectoEN = new PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN ();
                                _IproyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD (session);
                                proyectoCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN (_IproyectoCAD);
                                proyectoEN = proyectoCEN.DamePorID (p_Proyecto_OID);
                                proyectoDTO = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.ProyectoAdapter.Convert (proyectoEN);
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return proyectoDTO;
}



[OperationContract]

public System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO> PersonalHome_Proyecto_DameTodos ()
{
        System.Collections.Generic.IList<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO> proyectoDTOs = null;


        System.Collections.Generic.IList<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN> proyectoENs = null;

        PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN proyectoCEN = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD _IproyectoCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                proyectoDTOs = new System.Collections.Generic.List<PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.ProyectoDTO>();


                                proyectoENs = new System.Collections.Generic.List<PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN>();
                                _IproyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD (session);
                                proyectoCEN = new PersonalHomeGenNHibernate.CEN.PersonalHome.ProyectoCEN (_IproyectoCAD);
                                proyectoENs = proyectoCEN.DameTodos (0, -1);
                                if (proyectoENs != null) {
                                        foreach (PersonalHomeGenNHibernate.EN.PersonalHome.ProyectoEN item in proyectoENs) {
                                                proyectoDTOs.Add (PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.ProyectoAdapter.Convert (item));
                                        }
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return proyectoDTOs;
}





[OperationContract]
public PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO PersonalHome_Proyecto_GetUsuarioOfProyecto (int idProyecto)
{
        PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome.UsuarioDTO dto = null;
        PersonalHomeGenNHibernate.EN.PersonalHome.UsuarioEN en = null;
        PersonalHomeGenNHibernate.CAD.PersonalHome.IProyectoCAD proyectoCAD = null;
        try
        {
                using (ISession session = NHibernateHelper.OpenSession ())
                        using (ITransaction tx = session.BeginTransaction ())
                        {
                                proyectoCAD = new PersonalHomeGenNHibernate.CAD.PersonalHome.ProyectoCAD (session);
                                en = proyectoCAD.GetUsuarioOfProyecto_PersonalHome (idProyecto);
                                if (en != null) {
                                        dto = PersonalHomeGen_PersonalHomeWCF.Adapters.PersonalHome.UsuarioAdapter.Convert (en);
                                }
                                tx.Commit ();
                        }
        }

        catch (Exception ex)
        {
                throw ex;
        }

        return dto;
}
}
}
