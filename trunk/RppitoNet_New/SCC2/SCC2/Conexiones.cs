//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


//using System.Text;
//using System.Collections.Specialized;
//using System.Net;
//using System.IO;
//using System.Diagnostics;


//namespace SCC2
//{

//    private NameValueCollection GetOAuthParameters(string httpMethod, string url, string requestToken = null, string tokenSecret = null, string verifier = null, string callback = null)  
//    {  
//        var oAuthParameters = new NameValueCollection  
//                                    {  
//                                    {"oauth_timestamp",GetTimeStamp()},  
//                                    {"oauth_nonce",GetNonce()},  
//                                    {"oauth_version", "1.0"},  
//                                    {"oauth_signature_method", "HMAC-SHA1"},  
//                                    {"oauth_consumer_key", _consumerKey},  
//                                    };  
    
//        if (!String.IsNullOrEmpty(requestToken)) oAuthParameters.Add("oauth_token", requestToken);  
//        if (!String.IsNullOrEmpty(verifier)) oAuthParameters.Add("oauth_verifier", verifier);  
//        if (!String.IsNullOrEmpty(callback)) oAuthParameters.Add("oauth_callback", callback);  
//        var signatureBase = GetSignatureBase(httpMethod, NormalizeUrl(url), oAuthParameters);  
//        var signature = GetSignature(_consumerSecret, signatureBase, tokenSecret);  
//        oAuthParameters.Add("oauth_signature", signature);   

//        Debug.WriteLine("oauth_signature {0}", signature);  
//        return oAuthParameters;  

//    } 


//    private static string GetNonce()
//    {  
//        return new Random().Next(Int16.MinValue, Int16.MaxValue).ToString("X");  
//    } 

//    private static string GetTimeStamp()  
//    {
//        return ((long)(DateTime.UtcNow - (new DateTime(1970, 1, 1))).TotalSeconds).ToString();  
//    } 

//    public static string NormalizeUrl(string url)
//    {
//        var uri = new Uri(url);
//        var port = string.Empty;

//        if (uri.Scheme == "http" && uri.Port != 80 ||
//            uri.Scheme == "https" && uri.Port != 443 ||
//            uri.Scheme == "ftp" && uri.Port != 20)
//            port = string.Format(":{0}", uri.Port);

//        return string.Format("{0}://{1}{2}{3}", uri.Scheme, uri.Host, port, uri.AbsolutePath);
//    }

//    private static string GetSignatureBase(string httpMethod, string url, NameValueCollection oAuthParameters)
//    {
//        var parameters = new Dictionary<string, string>();
//        foreach (var key in oAuthParameters.AllKeys)
//            parameters.Add(key, oAuthParameters[key]);

//        var normalizedParameters = NormalizeParameters(parameters);

//        return string.Format("{0}&{1}&{2}", httpMethod, Uri.EscapeDataString(url), Uri.EscapeDataString(normalizedParameters));
//    }

//    private static string GetSignature(string consumerSecret, string signatureBase, string tokenSecret = null)
//    {
//        var hmacsha1 = new HMACSHA1(Encoding.UTF8.GetBytes(string.Concat(consumerSecret, "&", tokenSecret)));

//        var data = Encoding.ASCII.GetBytes(signatureBase);
//        var hashData = hmacsha1.ComputeHash(data);

//        return Uri.EscapeDataString(Convert.ToBase64String(hashData));
//    }


//    public Token GetRequestToken(string url)
//    {
//        var parameters = GetOAuthParameters(HttpMethod.Get, url, callback: "oob");

//        var oAuthRequest = new OAuthRequest(parameters, url, HttpMethod.Get, proxy: _proxy);

//        return RetrieveToken(oAuthRequest.GetResponse());
//    }

//    private static Token RetrieveToken(string result)
//    {
//     var values = HttpUtility.ParseQueryString(result);

//     var tokens = new Token { Value = values.Get("oauth_token"), SecretToken = values.Get("oauth_token_secret") };

//     return tokens;
//    }


//    Process.Start(string.Format(url + "{0}", tokens.Value));

//    public class Conexiones
//    {
//    }


//    public class OAuthRequest
//    {
//        private readonly HttpWebRequest _request;

//        public string GetResponse()
//        {
//            try
//            {
//                Debug.WriteLine("{0}: {1}", _request.Method, _request.RequestUri);

//                using (var response = _request.GetResponse())
//                {
//                    var stream = response.GetResponseStream();
//                    using (var reader = new StreamReader(stream))
//                    {
//                        return reader.ReadToEnd();
//                    }
//                }
//            }
//            catch (WebException ex)
//            {
//                if (ex.Response is HttpWebResponse)
//                {
//                    using (var reader = new StreamReader(ex.Response.GetResponseStream()))
//                    {
//                        var result = reader.ReadToEnd();
//                        return result;
//                    }
//                }

//                throw;
//            }
//        }

//        public OAuthRequest(NameValueCollection parameters, string url, string method, string realm = null, WebProxy proxy = null)
//        {
//            ServicePointManager.Expect100Continue = false;
//            ServicePointManager.UseNagleAlgorithm = false;

//            var header = new StringBuilder();

//            header.Append("OAuth ");

//            if (!string.IsNullOrEmpty(realm)) header.Append("realm=\"" + realm + "\" ");

//            for (var i = 0; i < parameters.Count; i++)
//            {
//                var key = parameters.GetKey(i);
//                header.Append(string.Format("{0}=\"{1}\"", key, parameters[key]));

//                if (i < parameters.Count - 1)
//                    header.Append(",");
//            }

//            _request = CreateRequestByProxy(url, method, proxy);

//            _request.Headers["Authorization"] = header.ToString();

//        }

//        private static HttpWebRequest CreateRequestByProxy(string url, string method, WebProxy proxy = null)
//        {
//            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
//            httpWebRequest.Method = method.ToUpper();

//            if (proxy != null) httpWebRequest.Proxy = proxy;

//            return httpWebRequest;
//        }
//    }


//}