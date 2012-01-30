using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RppitoNet.Models
{
    public class ReporteroBL: IReportero
    {
        public List<ReporteroBE> Listado()
        {
            ReporteroDL reportero = new ReporteroDL();
            return reportero.Listado();
        }
    }
}