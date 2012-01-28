using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public interface IReportero
    {
        List<ReporteroBE> Listado();
    }

    public interface ISeccion
    {
         List<SeccionBE> Listado();
    }

    public interface ITipoNoticia
    {
        List<TipoNoticiaBE> Listado();
    }

    public interface INoticia
    {
         NoticiaBE Registro(int pId_noticia);
         bool Mantenimiento(string pAccion, NoticiaBE pNoticiaBE);
         List<RNoticiaBE> Listado(string pFecha);
    }

}