using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
{
    public interface IReportero
    {
        List<ReporteroBE> Listado();
        int Codigo(string pNombre);
    }


    public interface ISeccion
    {
         List<SeccionBE> Listado();
        SeccionBE Registro(int pId_seccion);
    }

    public interface ITipoNoticia
    {
        List<TipoNoticiaBE> Listado();
    }

    public interface INoticia
    {
         NoticiaBE Registro(int pId_noticia);
         bool Mantenimiento(string pAccion, NoticiaBE pNoticiaBE);
         bool Publicacion(int pId_noticia);
         bool Distribucion(int pId_noticia);
         List<RNoticiaBE> Listado(string pFecha, string pTipo);

         //NoticiaBE RegistroRec(int pId_recolector);
    }

}