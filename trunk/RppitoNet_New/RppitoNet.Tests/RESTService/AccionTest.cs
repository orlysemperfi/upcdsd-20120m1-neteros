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
            string postdata = "{\"IdNoticia\":\"1001\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest reqP = (HttpWebRequest)WebRequest
            .Create("http://localhost:41460/AccionService.svc/Noticia");
            reqP.Method = "POST";
            reqP.ContentLength = data.Length;
            reqP.ContentType = "application/json";
            var reqStream = reqP.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse resP = (HttpWebResponse)reqP.GetResponse();
            StreamReader readerP = new StreamReader(resP.GetResponseStream());
            string rptaJsonP = readerP.ReadToEnd();
            JavaScriptSerializer jsP = new JavaScriptSerializer();
            bool rptaObtenidaP = jsP.Deserialize<bool>(rptaJsonP);
            Assert.AreEqual(true, rptaObtenidaP);

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:41460/AccionService.svc/Noticia");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string rptaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            bool rptaObtenida = js.Deserialize<bool>(rptaJson);
            Assert.AreEqual(true, rptaObtenida);

        }
    }
}
