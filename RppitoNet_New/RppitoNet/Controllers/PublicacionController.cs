﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RppitoNet.Models;
using System.Messaging;
using System.Threading;

namespace RppitoNet.Controllers
{
    public class PublicacionController : Controller
    {

        NoticiaBL modelo = new NoticiaBL();


        //
        // GET: /Publicacion/

        public ActionResult Index()
        {
            var noticias = modelo.Listado(DateTime.Now.ToString("yyyyMMdd"), "N").ToList();
            return View(noticias);
        }

        [HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Index(string txtFecha)
        {
            string pFecha = txtFecha.Substring(6, 4) + txtFecha.Substring(3, 2) + txtFecha.Substring(0, 2);

            var noticias = modelo.Listado(pFecha, "N").ToList();
            return View(noticias);
        }


        //
        // GET: /Publicacion/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Publicacion/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Publicacion/Create

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
        // GET: /Publicacion/Edit/5
 
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
        // POST: /Publicacion/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, NoticiaBE entity)
        {
            try
            {
                string rutaCola = ".\\private$\\" + "publicaciones" + "in";

                if (!MessageQueue.Exists(rutaCola))
                    MessageQueue.Create(rutaCola);

                MessageQueue colaNeterosIn = new MessageQueue(rutaCola);

                Message mensaje = new Message();
                mensaje.Label = "Publicacion";
                mensaje.Body = entity;

                colaNeterosIn.Send(mensaje);


                ////Thread hilo = new Thread(new ThreadStart(new Lector(@".\private$\" + "publicaciones" + "out").Leer));
                //Thread hilo = new Thread(new ThreadStart(new Lector(@".\private$\" + "publicaciones" + "in").Leer));
                //hilo.Start();

                return RedirectToAction("Index");

                // TODO: Add update logic here

               //if (modelo.Publicacion(entity.IdNoticia))
               // {
               //     return RedirectToAction("Index");
               // }
               // else
               // {
               //     //revisar como refrescar
               //     SeccionBL seccion = new SeccionBL();
               //     ReporteroBL reportero = new ReporteroBL();

               //     var item = modelo.Registro(id);
               //     //ViewBag.Secciones = seccion.Listado().ToList();
               //     ViewData["Secciones"] = seccion.Listado().ToList();
               //     //ViewBag.Reporteros = reportero.Listado().ToList();
               //     ViewData["Reporteros"] = reportero.Listado().ToList();

               //     return View(entity);
               // }
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


        //public class Lector
        //{
        //    private string cola = null;
        //    public Lector(string rutaCola)
        //    {
        //        cola = rutaCola;
        //    }

        //    public void Leer()
        //    {
        //        NoticiaBL modelo = new NoticiaBL();

        //        if (!MessageQueue.Exists(cola))
        //            MessageQueue.Create(cola);

        //        MessageQueue colaOut = new MessageQueue(cola);
        //        colaOut.Formatter = new XmlMessageFormatter(new Type[] { typeof(NoticiaBE) });

        //        Message msg = null;

        //        while (true)
        //        {
        //            //Thread.Sleep(20000);
        //            Thread.Sleep(10000);
        //            msg = colaOut.Receive();

        //            modelo.Publicacion(((NoticiaBE)msg.Body).IdNoticia);

        //        }

        //    }
        //}

        //
        // GET: /Publicacion/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Publicacion/Delete/5

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