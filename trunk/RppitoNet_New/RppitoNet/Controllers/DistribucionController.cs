using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RppitoNet.Models;
using System.Configuration;
using System.Net;

namespace RppitoNet.Controllers
{
    public class DistribucionController : Controller
    {

        NoticiaBL modelo = new NoticiaBL();

        //
        // GET: /Distribucion/

        public ActionResult Index()
        {
            var noticias = modelo.Listado(DateTime.Now.ToString("yyyyMMdd"), "D").ToList();
            return View(noticias);
        }

        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Index(string txtFecha)
        {
            string pFecha = txtFecha.Substring(6, 4) + txtFecha.Substring(3, 2) + txtFecha.Substring(0, 2);

            var noticias = modelo.Listado(pFecha, "D").ToList();
            return View(noticias);
        }

        //
        // GET: /Distribucion/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Distribucion/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Distribucion/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Distribucion/Edit/5
 
        public ActionResult Edit(int id)
        {
            SeccionBL seccion = new SeccionBL();
            ReporteroBL reportero = new ReporteroBL();

            var item = modelo.Registro(id);
            //ViewBag.Secciones = seccion.Listado().ToList();
            ViewData["Secciones"] = seccion.Listado().ToList();
            //ViewBag.Reporteros = reportero.Listado().ToList();
            ViewData["Reporteros"] = reportero.Listado().ToList();
            return View(item);

        }

        //
        // POST: /Distribucion/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, NoticiaBE entity)
        {
            try
            {

                //*Twitter************************************
                var oauth = new OAuth.Manager();
                oauth["consumer_key"] = RppitoNet.Properties.Settings.Default.consumer_key;
                oauth["consumer_secret"] = RppitoNet.Properties.Settings.Default.consumer_secret;
                oauth["token"] = RppitoNet.Properties.Settings.Default.token;
                oauth["token_secret"] = RppitoNet.Properties.Settings.Default.token_secret;

                var twitterUpdateUrlBase = "http://api.twitter.com/1/statuses/update.xml?status=";
                var msg = entity.Titulo;
                var url = twitterUpdateUrlBase + OAuth.Manager.UrlEncode(msg);

                var authzHeader = oauth.GenerateAuthzHeader(url, "POST");
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.PreAuthenticate = true;
                request.AllowWriteStreamBuffering = true;
                request.ContentLength = 0;
                request.Headers.Add("Authorization", authzHeader);

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception("Error al publicar nota en Twitter");
                        //lblMensaje.Text = "There's been a problem trying to tweet:" +
                        //                Environment.NewLine +
                        //                response.StatusDescription +
                        //                Environment.NewLine +
                        //                Environment.NewLine +
                        //                "You will have to tweet manually." +
                        //                Environment.NewLine;
                } 


                //*Twitter************************************

                // TODO: Add update logic here

                if (modelo.Distribucion(entity.IdNoticia))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    //revisar como refrescar
                    SeccionBL seccion = new SeccionBL();
                    ReporteroBL reportero = new ReporteroBL();

                    var item = modelo.Registro(id);
                    //ViewBag.Secciones = seccion.Listado().ToList();
                    ViewData["Secciones"] = seccion.Listado().ToList();
                    //ViewBag.Reporteros = reportero.Listado().ToList();
                    ViewData["Reporteros"] = reportero.Listado().ToList();

                    return View(entity);
                }
            }
            catch
            {

                //revisar como refrescar
                SeccionBL seccion = new SeccionBL();
                ReporteroBL reportero = new ReporteroBL();

                var item = modelo.Registro(id);
                //ViewBag.Secciones = seccion.Listado().ToList();
                ViewData["Secciones"] = seccion.Listado().ToList();
                //ViewBag.Reporteros = reportero.Listado().ToList();
                ViewData["Reporteros"] = reportero.Listado().ToList();


                return View(entity);
            }
        }

        //
        // GET: /Distribucion/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Distribucion/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
