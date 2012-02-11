using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using RESTService.Dominio;

namespace RESTService
{

    [ServiceContract]
    public interface IAccionService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Noticia", ResponseFormat = WebMessageFormat.Json)]
        bool PublicaNoticia();
    }
}
