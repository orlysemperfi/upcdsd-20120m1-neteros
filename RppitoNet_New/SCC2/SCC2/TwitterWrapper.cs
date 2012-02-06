//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//using System.IO;
//using System.Net;
//using System.Web;
//using System.Xml.Serialization;
//using OAuthTools;
//using TwitterWrapper.Resources;


//namespace SCC2
//{
//    public class Twitter
//    {
//        private const string ConsumerKey = "yourConsumerKey";
//        private const string ConsumerSecret = "yourConsumerSecret";
//        private const string AccessToken = "yourAccessToken";
//        private const string AccessTokenSecret = "yourAccessTokenSecret";

//        public Status UpdateStatus(string status, WebProxy webProxy = null)
//        {
//            var query = string.Format("http://api.twitter.com/1/statuses/update.xml?status={0}", HttpUtility.UrlEncode(status));
//            var request = new OAuth(ConsumerKey, ConsumerSecret, AccessToken, AccessTokenSecret);
//            var result = request.PostResource(query);

//            return Serialize(result);
//        }

//        public Status Serialize(string xml)
//        {
//            var xmlSerializer = new XmlSerializer(typeof(Status));
//            var reader = new StringReader(xml);
//            var status = (Status)xmlSerializer.Deserialize(reader);

//            return status;
//        }
//    }

//    /* POST Requests */
//    public string PostResource(string url)
//    {
//    var uri = new Uri(url);
//    var parameters = GetOAuthParameters(HttpMethod.Post, url, HttpUtility.ParseQueryString(uri.Query), _accessToken, _accessTokenSecret);
//    url = string.Format("{0}://{1}{2}", uri.Scheme, uri.Authority, uri.AbsolutePath);
//    var oAuthRequest = new OAuthRequest(parameters, url, HttpMethod.Post, proxy: _proxy);
//    var queryParameters = HttpUtility.ParseQueryString(uri.Query);
//    var response = oAuthRequest.GetResponse(queryParameters);

//    return response;
//    }

//}