using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RppitoNet.Models;

namespace RppitoNet.Controllers
{
    [HandleError]
    public class NoticiasController : Controller
    {

        NoticiaBL modelo = new NoticiaBL();

        public ActionResult Index()
        {
            var noticias = modelo.Listado(DateTime.Now.ToString("yyyyMMdd"), "T").ToList();
            return View(noticias);
        }

        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Index(string txtFecha)
        {
            string pFecha = txtFecha.Substring(6, 4) + txtFecha.Substring(3, 2) + txtFecha.Substring(0, 2);

            var noticias = modelo.Listado(pFecha, "T").ToList();
            return View(noticias);
        }



        //
        // GET: /Editar/

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
        // POST: /Default1/Edit/5

        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Edit(int id, NoticiaBE entity)
        {
            try
            {
                // TODO: Add update logic here

                //var prod = modelo..Products.FirstOrDefault(p => p.ProductID == id);

                //NoticiaBE noticia = new NoticiaBE();

                //noticia.IdNoticia = Int32.Parse(Request.Form["IdNoticia"]);
                //noticia.IdRecolector = Int32.Parse(Request.Form["IdRecolector"]);
                //noticia.Titulo = Request.Form["Titulo"];
                //noticia.Contenido = Request.Form["Contenido"];
                //noticia.Idseccion = Int32.Parse(Request.Form["Idseccion"]);
                //noticia.Idreportero = Int32.Parse(Request.Form["Idreportero"]);
                //noticia.IdTipoNoticia = Int32.Parse(Request.Form["IdTipoNoticia"]);
                //noticia.Fecha = DateTime.Parse(Request.Form["Fecha"]);
                //noticia.Idvideo = Int32.Parse(Request.Form["Idvideo"]);
                //noticia.Idimagen = Int32.Parse(Request.Form["Idimagen"]);
                //noticia.flg_req_mapa = bool.Parse(Request.Form["flg_req_mapa"]);
                //noticia.flg_mapa = bool.Parse(Request.Form["flg_mapa"]);
                //noticia.flg_publicado = bool.Parse(Request.Form["flg_publicado"]);
                //noticia.flg_twitter = bool.Parse(Request.Form["flg_twitter"]);
                //noticia.prioridad = Int32.Parse(Request.Form["prioridad"]);

                entity.estado = "E";

                if (modelo.Mantenimiento("M", entity))
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
        // GET: /Editar_Recolector/

        public ActionResult Edit_Recolector(int id)
        {
            SeccionBL seccion = new SeccionBL();
            ReporteroBL reportero = new ReporteroBL();

            var item = modelo.RegistroRec(id);
            //ViewBag.Secciones = seccion.Listado().ToList();
            ViewData["Secciones"] = seccion.Listado().ToList();
            //ViewBag.Reporteros = reportero.Listado().ToList();
            ViewData["Reporteros"] = reportero.Listado().ToList();
            return View(item);
        }



        //
        // POST: /Default1/Edit/5

        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Edit_Recolector(int id, NoticiaBE entity)
        {
            try
            {
                // TODO: Add update logic here


                if (modelo.Mantenimiento("N", entity))
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


    }
}
