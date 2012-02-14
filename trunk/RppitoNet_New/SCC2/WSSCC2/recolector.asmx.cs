using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WSSCC2
{
    /// <summary>
    /// Summary description for recolector
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class recolector : System.Web.Services.WebService
    {
        [WebMethod]
        public List<RecolectorBE> ListadoRecolector(string pFecha, int pId_recolector)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["WS_Repositorio.Properties.Settings.Setting"];

            SqlConnection conexion = new SqlConnection(settings.ConnectionString);
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandText = "pa_Listado_Recolector";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pFecha;
            param.ParameterName = "fecha";
            cmd.Parameters.Add(param);

            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pId_recolector;
            param.ParameterName = "idrecolector";
            cmd.Parameters.Add(param);

            List<RecolectorBE> lista = new List<RecolectorBE>();

            try
            {
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    RecolectorBE item = new RecolectorBE();
                    item.IdRecolector = dr.GetInt32(dr.GetOrdinal("IdRecolector"));
                    item.Titulo = dr.GetString(dr.GetOrdinal("Titulo"));
                    item.Contenido = dr.GetString(dr.GetOrdinal("Contenido"));
                    item.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    item.prioridad = dr.GetInt32(dr.GetOrdinal("Prioridad"));
                    item.Idseccion = dr.GetInt32(dr.GetOrdinal("Idseccion"));
                    item.Nomreportero = dr.GetString(dr.GetOrdinal("Nombrereportero"));
                    if (System.Convert.IsDBNull(dr["Idvideo"]))
                    {
                        item.Idvideo = 0;
                    }
                    else
                    {
                        item.Idvideo = dr.GetInt32(dr.GetOrdinal("Idvideo"));
                    }
                    if (System.Convert.IsDBNull(dr["Idimagen"]))
                    {
                        item.Idimagen = 0;
                    }
                    else
                    {
                        item.Idimagen = dr.GetInt32(dr.GetOrdinal("Idimagen"));
                    }

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


        [WebMethod]
        public VideoBE RegistroVideo(int IdVideo)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["WS_Repositorio.Properties.Settings.Setting"];
            SqlConnection conexion = new SqlConnection(settings.ConnectionString);
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandText = "pa_Registro_Video";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = IdVideo;
            param.ParameterName = "IdVideo";
            cmd.Parameters.Add(param);

            VideoBE item = new VideoBE();

            try
            {

                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    item.idVideo = dr.GetInt32(dr.GetOrdinal("idVideo"));
                    item.link = dr.GetString(dr.GetOrdinal("link"));
                    item.descripcion = dr.GetString(dr.GetOrdinal("descripcion"));

                    //if (System.Convert.IsDBNull(dr["Idimagen"]))
                    //{
                    //    item.Idimagen = 0;
                    //}
                    //else
                    //{
                    //    item.Idimagen = dr.GetInt32(dr.GetOrdinal("Idimagen"));
                    //}
                }

                dr.Close();
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

            return item;
        }


    }



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

    public class VideoBE
    {
        public int idVideo { get; set; }
        public string link { get; set; }
        public string descripcion { get; set; }
    }
}
