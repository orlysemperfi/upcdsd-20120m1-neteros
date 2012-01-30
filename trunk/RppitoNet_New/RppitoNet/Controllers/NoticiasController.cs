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
        //
        // GET: /Editar/
        NoticiaBL modelo = new NoticiaBL();

        public ActionResult Index()
        {
            var noticias = modelo.Listado("20120124").ToList();
            return View(noticias);

        }

        public ActionResult Editar(/*int Idnoticia*/)
        {

            return View();
        }

        public ActionResult Publicar(/*int Idnoticia*/)
        {

            return View();
        }
    }
}
