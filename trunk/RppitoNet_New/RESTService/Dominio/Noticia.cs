using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RESTService.Dominio
{
    [DataContract]
    public class Noticia
    {
        [DataMember]
        public int IdNoticia { get; set; }
        [DataMember]
        public int IdRecolector { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string Contenido { get; set; }
        [DataMember]
        public string TipoVista { get; set; }
        [DataMember]
        public int Idseccion { get; set; }
        [DataMember]
        public int IdTipoNoticia { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public int Idreportero { get; set; }
        [DataMember]
        public int Idvideo { get; set; }
        [DataMember]
        public int Idimagen { get; set; }
        [DataMember]
        public bool flg_req_mapa { get; set; }
        [DataMember]
        public bool flg_mapa { get; set; }
        [DataMember]
        public bool flg_publicado { get; set; }
        [DataMember]
        public bool flg_twitter { get; set; }
        [DataMember]
        public int prioridad { get; set; }
        [DataMember]
        public string estado { get; set; }

    }
}