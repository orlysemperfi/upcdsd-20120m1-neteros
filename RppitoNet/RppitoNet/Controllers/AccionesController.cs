using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RppitoNet.Controllers
{
    [HandleError]
    public class AccionesController : Controller
    {
        //
        // GET: /Editar/

        public ActionResult EditarLista()
        {
            var Noticias = new Models.NoticiaModel().GetNoticias();
            return View(Noticias);
        }


        // GET: /Plantilla/Edit/5

        public ActionResult EditarDetalle(string  IdNoticia)
        {
            return View(new Models.NoticiaModel().GetNoticia(IdNoticia));
        }

        //
        // POST: /Plantilla/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("EditarLista");
            }
            catch
            {
                return View();
            }
        }

        //




        public ActionResult Publicar()
        {
            return View();
        }

        public ActionResult Priorizar()
        {
            return View();
        }

        public ActionResult Mapear()
        {
            return View();
        }


        public ActionResult Distribuir_Lista()
        {
            return View();
        }

        //public ActionResult Distribuir_Detalle(int IdNoticia)
        public ActionResult Distribuir_Detalle()
        {
            return View();
        }

    }
}
