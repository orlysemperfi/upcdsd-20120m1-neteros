using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Configuration;

namespace RppitoNet.Tests.Controllers
{
    [TestClass]
    public class DistribucionControllerTest
    {
        [TestMethod]
        public void DistribuirTest()
        {
            var oauth = new OAuth.Manager();

            oauth["consumer_key"] = RppitoNet.Tests.Properties.Settings.Default.consumer_key;
            oauth["consumer_secret"] = RppitoNet.Tests.Properties.Settings.Default.consumer_secret;
            oauth["token"] = RppitoNet.Tests.Properties.Settings.Default.token;
            oauth["token_secret"] = RppitoNet.Tests.Properties.Settings.Default.token_secret;

            var twitterUpdateUrlBase = "http://api.twitter.com/1/statuses/update.xml?status=";
            var msg = "Ejemplo" + DateTime.Today.ToString();
            var url = twitterUpdateUrlBase + OAuth.Manager.UrlEncode(msg);

            var authzHeader = oauth.GenerateAuthzHeader(url, "POST");
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.PreAuthenticate = true;
            request.AllowWriteStreamBuffering = true;
            request.ContentLength = 0;
            request.Headers.Add("Authorization", authzHeader);

            var response = (HttpWebResponse)request.GetResponse();
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);

        }
    }
}
