using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    
    public class ClienteController : ApiController
    {
        [HttpPost]
        
        public string Cliente (Cliente datos)
        {
            string retorno = "";

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
        public string Test (Cliente datos)
        {
            return "";
        }
    }
}
