using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
{

    public class RecolectorBE
    {
        public int IdRecolector { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string TipoVista { get; set; }
        public int Idseccion { get; set; }
        public int IdTipoNoticia { get; set; }
        public DateTime Fecha { get; set; }
        public int Idreportero { get; set; }
        public string Nomreportero { get; set; }
        public int Idvideo { get; set; }
        public int Idimagen { get; set; }
        public int prioridad { get; set; }

    }


    public class NoticiaBE
    {
        public int IdNoticia { get; set; }
        public int IdRecolector { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string TipoVista { get; set; }
        public int Idseccion { get; set; }
        public int IdTipoNoticia { get; set; }
        public DateTime Fecha { get; set; }
        public int Idreportero { get; set; }
        public int Idvideo { get; set; }
        public int Idimagen { get; set; }
        public bool flg_req_mapa { get; set; }
        public bool flg_mapa { get; set; }
        public bool flg_publicado { get; set; }
        public bool flg_twitter { get; set; }
        public int prioridad { get; set; }
        public string estado { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
    }

    public class SeccionBE
    {
        public int Idseccion { get; set; }
        public string Nombre { get; set; }         
    }

    public class ReporteroBE
    {
        public int Idreportero { get; set; }
        public string Nombre { get; set; }
    }

    public class TipoNoticiaBE
    {
        public int IdTipoNoticia { get; set; }
        public string Nombre { get; set; }
    }

    public class RNoticiaBE
    {
        public int IdNoticia { get; set; }
        public int IdRecolector { get; set; }
        public string Titulo { get; set; }
        public string Seccion { get; set; }
        public int TipoNoticia { get; set; }
        public DateTime Fecha { get; set; }
        public string Reportero { get; set; }
        public bool Flg_publicado { get; set; }
        public bool Flg_twitter { get; set; }
        public int Prioridad { get; set; }
        public string Estado { get; set; }
        public string Nom_estado { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
    }

    public class VideoBE
    {
        public int idVideo { get; set; }
        public string link { get; set; }
        public string descripcion { get; set; }
    }

}