using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RppitoNet.Controllers
{
    [HandleError]
    public class NoticiasController : Controller
    {
        //
        // GET: /Editar/

        public ActionResult Index()
        {
        
            return View();
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
