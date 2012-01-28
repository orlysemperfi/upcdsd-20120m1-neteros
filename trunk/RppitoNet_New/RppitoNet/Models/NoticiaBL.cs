using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class NoticiaBL: INoticia
    {
        public NoticiaBE Registro(int pId_noticia)
        {
            NoticiaDL noticia = new NoticiaDL();
            return noticia.Registro(pId_noticia);
        }

        public bool Mantenimiento(string pAccion, NoticiaBE pNoticiaBE)
        {
            NoticiaDL noticia = new NoticiaDL();
            return noticia.Mantenimiento(pAccion, pNoticiaBE);
        }

        public List<RNoticiaBE> Listado(string pFecha)
        {
            NoticiaDL noticia = new NoticiaDL();
            return noticia.Listado(pFecha);
        }
    }
}