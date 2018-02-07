using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using ApiRestFulPH.Clases;
using PersonalHomeGen_PersonalHomeWCF.DTO.PersonalHome;
using Newtonsoft.Json.Linq;

namespace ApiRestFulPH
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Usuario",
            BodyStyle =WebMessageBodyStyle.Wrapped,
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         Method = "POST")]

        bool Usuario(Usuario data);
    }
}
