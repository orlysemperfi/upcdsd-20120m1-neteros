using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
{
    public class NoticiaModel
    {

        public IEnumerable<Noticia> GetNoticias()
        {
            List<Noticia> resultado;
            using (var ctx = new  RppDbDataContext())
            {
                resultado=ctx.Noticias.ToList();

            }
            return resultado;
        }

        public Noticia GetNoticia(string IdNoticia)
        {
            Noticia dd = new Noticia();
            dd.IdNoticia = "0001";
            dd.Titulo = "Accidente en el Dakar: aficionado atropelló a una joven de 14 años";
            dd.Descripcion = "Esta vez fue la imprudencia de los espectadores la que generó un accidente en el Dakar. Un aficionado que iba con su cuatrimoto a ver la prueba atropelló a una joven de 14 años, de iniciales APR, generándole traumatismo abdominal y contusiones en la pierna, mientras que el conductor sufrió golpes en las extremidades superiores, según informó el Ministerio de Salud.";
            dd.Tipo="Noticia";
            dd.Seccion="Dakar";
            return dd;
        }  
    }
}