using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace WS_Repositorio
{
    /// <summary>
    /// Summary description for Recolector
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Recolector : System.Web.Services.WebService
    {

        [WebMethod]
        public List<NoticiaBE> ListadoRecolector(string pFecha)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["WS_Repositorio.Properties.Settings.Setting"];

            SqlConnection conexion = new SqlConnection(settings.ConnectionString);
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandText = "pa_Listado_Noticia";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pFecha;
            param.ParameterName = "fecha";
            cmd.Parameters.Add(param);

            List<NoticiaBE> lista = new List<NoticiaBE>();

            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    NoticiaBE item = new NoticiaBE();
                    item.IdRecolector = dr.GetInt32(dr.GetOrdinal("IdRecolector"));
                    item.Titulo = dr.GetString(dr.GetOrdinal("Titulo"));
                    item.Contenido = dr.GetString(dr.GetOrdinal("Contenido"));
                    item.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    item.prioridad = dr.GetInt32(dr.GetOrdinal("Prioridad"));
                    item.Idseccion = dr.GetInt32(dr.GetOrdinal("Idseccion"));
                    item.Idreportero = dr.GetInt32(dr.GetOrdinal("Idreportero"));

                    lista.Add(item);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }

            return lista;
        }
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
        public int prioridad { get; set; }

    }

}
