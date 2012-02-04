using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace SCC2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //PostTweet("Xpptio2012", "xppito2012", "Desde NET");
            string responseText = String.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://twitter.com/statuses/update.xml");
            request.Method = "POST";
            request.Credentials = new NetworkCredential("@Xpptio2012", "xppito2012");
            request.Headers.Add("status", "Tweeting from ASP.NET MVC C#");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                responseText = sr.ReadToEnd();
            }
            //return responseText;
            lblMensaje.Text = responseText;
        }

        public static void PostTweet(string username, string password, string tweet)
        {
            try
            {
                // encode the username/password
                string user = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(username + ":" + password));
                // determine what we want to upload as a status
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes("status=" + tweet);
                // connect with the update page
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://twitter.com/statuses/update.xml");
                // set the method to POST
                request.Method = "POST";
                request.ServicePoint.Expect100Continue = false; // thanks to argodev for this recent change!
                // set the authorisation levels
                request.Headers.Add("Authorization", "Basic " + user);
                request.ContentType = "application/x-www-form-urlencoded";
                // set the length of the content
                request.ContentLength = bytes.Length;

                // set up the stream
                Stream reqStream = request.GetRequestStream();
                // write to the stream
                reqStream.Write(bytes, 0, bytes.Length);
                // close the stream
                reqStream.Close();
            }
            catch (Exception ex) {/* DO NOTHING */}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string apiurl = "http://twitter.com/statuses/update.xml";
            string username = "@Xpptio2012";
            string pass = "xppito2012";
            string data ;
            byte[] buffer;
            HttpWebRequest request; 
            //HttpWebResponse resp;
            //HttpWebResponse resp = default(HttpWebResponse);

            Stream nStream;
            StreamReader sReader; 
            XElement respuesta;
            string respString;


            string txtMensaje= "Prueba NET";

            dynamic credenciales = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(username + ":" + pass));
            data = "status=" + txtMensaje.Trim();
            buffer = System.Text.Encoding.UTF8.GetBytes(data);
            //request = WebRequest.Create(apiurl);
            request = (HttpWebRequest)WebRequest.Create(apiurl);
            System.Net.ServicePointManager.Expect100Continue = true;
            request.ProtocolVersion = HttpVersion.Version10;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.ContentLength = data.Length;
            request.KeepAlive = false;

            //request.Credentials = New NetworkCredential(Me.username, Me.pass) 
            request.Headers.Add("Authorization", "Basic " + credenciales);

            nStream = request.GetRequestStream();
            nStream.Write(buffer, 0, buffer.Length);
            nStream.Close();

            var resp = (HttpWebResponse)request.GetResponse();
            sReader = new StreamReader(resp.GetResponseStream(), System.Text.Encoding.UTF8);
            respString = sReader.ReadToEnd().ToString();
        //http://logica10mobile.blogspot.com/2009/10/escribiendo-un-cliente-de-twitter-con.html
            if (respString == null)
            {
                //lblMensaje.text = "Error";
                return;
            }
            respuesta = XElement.Parse(respString);

            //txtResponse.Text = respuesta.ToString;
        }
    }
}
