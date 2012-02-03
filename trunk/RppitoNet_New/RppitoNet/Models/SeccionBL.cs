using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
{
    public class SeccionBL:ISeccion
    {
        public List<SeccionBE> Listado()
        {
            SeccionDL seccion = new SeccionDL();
            return seccion.Listado();
        }

        public SeccionBE Registro(int pId_seccion)
        {
            SeccionDL seccion = new SeccionDL();
            return seccion.Registro(pId_seccion);
        }
    }
}