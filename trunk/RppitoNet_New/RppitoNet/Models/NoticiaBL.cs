using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
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
            List<RNoticiaBE> resultado= new List<RNoticiaBE>();
            resultado= noticia.Listado(pFecha);

            recolector_ws.recolector recolector = new recolector_ws.recolector();

            foreach (recolector_ws.RecolectorBE item in recolector.ListadoRecolector(pFecha))
            {
                    RNoticiaBE result = resultado.Find(
                    delegate(RNoticiaBE bk)
                    {
                        return bk.IdRecolector == item.IdRecolector;
                    }
                    );
                    if (result == null)
                    {
                        RNoticiaBE rgto = new RNoticiaBE();
                        rgto.IdNoticia = item.IdNoticia;
                        rgto.IdRecolector = item.IdRecolector;
                        rgto.Titulo = item.Titulo;
                        rgto.Fecha = item.Fecha;
                        rgto.Prioridad = item.prioridad;
                        rgto.Seccion = "";
                        rgto.Reportero = item.Nomreportero;
                        rgto.Flg_publicado = false;
                        rgto.Flg_twitter = false;

                        resultado.Add(rgto);
                    }

            }

            return resultado;
        }
    }
}