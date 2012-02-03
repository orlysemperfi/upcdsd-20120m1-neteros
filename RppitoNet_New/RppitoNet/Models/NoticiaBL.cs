﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
{
    public class NoticiaBL: INoticia
    {
        public NoticiaBE RegistroRec(int pId_recolector)
        {
            NoticiaDL noticia = new NoticiaDL();

            recolector_ws.recolector recolector = new recolector_ws.recolector();

            recolector_ws.RecolectorBE item = new recolector_ws.RecolectorBE();

            item = recolector.RegistroRecolector(pId_recolector);

            NoticiaBE rgto = new NoticiaBE();
            rgto.IdRecolector = item.IdRecolector;
            rgto.Titulo = item.Titulo;
            rgto.Contenido = item.Contenido;
            rgto.Fecha = item.Fecha;
            rgto.prioridad = item.prioridad;
            if (item.Idseccion != 0)
            {
                rgto.Idseccion = item.Idseccion;
            }
            if (item.Idvideo != 0)
            {
                rgto.Idvideo = item.Idvideo;
            }
            if (item.Idimagen != 0)
            {
                rgto.Idimagen = item.Idimagen;
            }

            //rgto.nomReportero = item.Nomreportero;
            rgto.flg_publicado = false;
            rgto.flg_twitter = false;

            return rgto;
        }

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

        public List<RNoticiaBE> Listado(string pFecha, string pTipo)
        {
            NoticiaDL noticia = new NoticiaDL();
            SeccionBL seccion = new SeccionBL();
            List<RNoticiaBE> resultado= new List<RNoticiaBE>();
            resultado= noticia.Listado(pFecha, pTipo);

            if (pTipo == "N")
            {
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
                        rgto.IdRecolector = item.IdRecolector;
                        rgto.Titulo = item.Titulo;
                        rgto.Fecha = item.Fecha;
                        rgto.Prioridad = item.prioridad;
                        rgto.Seccion = seccion.Registro(item.Idseccion).Nombre;
                        rgto.Reportero = item.Nomreportero;
                        rgto.Flg_publicado = false;
                        rgto.Flg_twitter = false;

                        resultado.Add(rgto);
                    }

                }            
            }

            
            return resultado;
        }


        public bool Publicacion(int pId_noticia)
        {
            NoticiaDL noticia = new NoticiaDL();
            return noticia.Publicacion(pId_noticia);
        }
    }
}