using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RppitoNet.Tests.RESTService
{
    [TestClass]
    public class AccionTest
    {
        [TestMethod]
        public void PublicaNoticia()
        {

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:41460/AccionService.svc/Noticia");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string rptaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            //Alumno alumnoObtenido = js.Deserialize<Alumno>(alumnoJson2);
            bool rptaObtenida = js.Deserialize<bool>(rptaJson);
            Assert.AreEqual("1", rptaObtenida);
            //Assert.AreEqual("Juan", alumnoObtenido.Nombre);

        }
    }
}
