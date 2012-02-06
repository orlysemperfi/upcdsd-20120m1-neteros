using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RppitoNet.Models;


namespace RppitoNet.Controllers
{
    public class InfografiaController : Controller
    {

        NoticiaBL modelo = new NoticiaBL();

        //
        // GET: /Infografia/

        public ActionResult Index()
        {
            var noticias = modelo.Listado(DateTime.Now.ToString("yyyyMMdd"), "").ToList();
            return View(noticias);
        }

        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Index(string txtFecha)
        {
            string pFecha = txtFecha.Substring(6, 4) + txtFecha.Substring(3, 2) + txtFecha.Substring(0, 2);

            var noticias = modelo.Listado(pFecha, "").ToList();
            return View(noticias);
        }


        //
        // GET: /Infografia/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Infografia/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Infografia/Create

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
        // GET: /Infografia/Edit/5
 
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
        // POST: /Infografia/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, NoticiaBE entity)
        {
            try
            {
                // TODO: Add update logic here

                if (modelo.Publicacion(entity.IdNoticia))
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
        // GET: /Infografia/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Infografia/Delete/5

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
