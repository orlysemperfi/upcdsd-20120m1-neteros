using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class SeccionBL:ISeccion
    {
        public List<SeccionBE> Listado()
        {
            SeccionDL seccion = new SeccionDL();
            return seccion.Listado();
        }
    }
}