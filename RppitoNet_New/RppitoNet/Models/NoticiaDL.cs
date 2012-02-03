using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.Common;
using System.Data;

namespace RppitoNet.Models
{
    public class NoticiaDL
    {

        //public string conexion = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"].ConnectionString;
        //public string provider = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"].ProviderName;
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"];

        public bool Publicacion(int pId_noticia)
        {
            DbProviderFactory factoriaProveedor = DbProviderFactories.GetFactory(settings.ProviderName);

            DbConnection conexion = factoriaProveedor.CreateConnection();
            conexion.ConnectionString = settings.ConnectionString;
            conexion.Open();
            //DbCommand cmd = factoriaProveedor.CreateCommand();
            DbCommand cmd = conexion.CreateCommand();
            //DbDataAdapter da;

            cmd.CommandText = "pa_Publica_Noticia";
            cmd.CommandType = CommandType.StoredProcedure;

            //DbParameter param = factoriaProveedor.CreateParameter();
            DbParameter param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pId_noticia;
            param.ParameterName = "IdNoticia";
            cmd.Parameters.Add(param);

            bool resultado = false;

            try
            {
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }

            return resultado;

        }

        public bool Mantenimiento(string pAccion, NoticiaBE pNoticia)
        {
            DbProviderFactory factoriaProveedor = DbProviderFactories.GetFactory(settings.ProviderName);

            DbConnection conexion = factoriaProveedor.CreateConnection();
            conexion.ConnectionString = settings.ConnectionString;
            conexion.Open();
            //DbCommand cmd = factoriaProveedor.CreateCommand();
            DbCommand cmd = conexion.CreateCommand();
            //DbDataAdapter da;

            cmd.CommandText = "pa_Mnt_Noticia";
            cmd.CommandType = CommandType.StoredProcedure;

            //DbParameter param = factoriaProveedor.CreateParameter();
            DbParameter param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pAccion;
            param.ParameterName = "accion";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.IdNoticia;
            param.ParameterName = "IdNoticia";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.IdRecolector;
            param.ParameterName = "IdRecolector";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pNoticia.Titulo;
            param.ParameterName = "Titulo";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pNoticia.Contenido;
            param.ParameterName = "Contenido";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pNoticia.TipoVista;
            param.ParameterName = "TipoVista";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.Idseccion;
            param.ParameterName = "Idseccion";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.IdTipoNoticia;
            param.ParameterName = "IdTipoNoticia";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.DateTime;
            param.Value = pNoticia.Fecha;
            param.ParameterName = "Fecha";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.Idreportero;
            param.ParameterName = "Idreportero";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.Idvideo;
            param.ParameterName = "Idvideo";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.Idimagen;
            param.ParameterName = "Idimagen";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Byte;
            param.Value = pNoticia.flg_req_mapa;
            param.ParameterName = "flg_req_mapa";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Byte;
            param.Value = pNoticia.flg_mapa;
            param.ParameterName = "flg_mapa ";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Byte;
            param.Value = pNoticia.flg_publicado;
            param.ParameterName = "flg_publicado";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter();
            param = cmd.CreateParameter();
            param.DbType = DbType.Byte;
            param.Value = pNoticia.flg_twitter;
            param.ParameterName = "flg_twitter";
            cmd.Parameters.Add(param);

            //param = factoriaProveedor.CreateParameter(); 
            param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pNoticia.prioridad;
            param.ParameterName = "prioridad";
            cmd.Parameters.Add(param);

            bool resultado= false;

            try
            {
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Dispose();
            }

            return resultado;
        }

        public List<RNoticiaBE> Listado(string pFecha)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(settings.ProviderName);

            DbConnection conexion = factory.CreateConnection();
            conexion.ConnectionString = settings.ConnectionString;
            conexion.Open();

            //DbCommand cmd = factory.CreateCommand();
            DbCommand cmd = conexion.CreateCommand();
            //DbDataAdapter da;

            cmd.CommandText = "pa_Listado_Noticia";
            cmd.CommandType = CommandType.StoredProcedure;

            //DbParameter param = factory.CreateParameter();
            DbParameter param = cmd.CreateParameter();
            param.DbType = DbType.String;
            param.Value = pFecha;
            param.ParameterName = "fecha";
            cmd.Parameters.Add(param);
            
            List<RNoticiaBE> lista = new List<RNoticiaBE>();

            try
            {
                //conexion.Open();
                DbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    RNoticiaBE item = new RNoticiaBE();
                    item.IdNoticia = dr.GetInt32(dr.GetOrdinal("IdNoticia"));
                    item.IdRecolector = dr.GetInt32(dr.GetOrdinal("IdRecolector"));
                    item.Titulo = dr.GetString(dr.GetOrdinal("Titulo"));
                    item.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    item.Prioridad = dr.GetInt32(dr.GetOrdinal("Prioridad"));
                    item.Seccion = dr.GetString(dr.GetOrdinal("Seccion"));
                    item.Reportero = dr.GetString(dr.GetOrdinal("Reportero"));
                    item.Flg_publicado = dr.GetBoolean(dr.GetOrdinal("Flg_publicado"));
                    item.Flg_twitter = dr.GetBoolean(dr.GetOrdinal("Flg_twitter"));

                    lista.Add(item);
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

            return lista;


        }



        public NoticiaBE Registro(Int64 pIdNoticia)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(settings.ProviderName);

            DbConnection conexion = factory.CreateConnection();
            conexion.ConnectionString = settings.ConnectionString;
            conexion.Open();

            //DbCommand cmd = factory.CreateCommand();
            DbCommand cmd = conexion.CreateCommand();
            //DbDataAdapter da;

            cmd.CommandText = "pa_Registro_Noticia";
            cmd.CommandType = CommandType.StoredProcedure;

            //DbParameter param = factory.CreateParameter();
            DbParameter param = cmd.CreateParameter();
            param.DbType = DbType.Int64;
            param.Value = pIdNoticia;
            param.ParameterName = "IdNoticia";
            cmd.Parameters.Add(param);

            NoticiaBE item = new NoticiaBE();

            try
            {

                DbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    item.IdNoticia = dr.GetInt32(dr.GetOrdinal("IdNoticia"));
                    item.IdRecolector = dr.GetInt32(dr.GetOrdinal("IdRecolector"));
                    item.Titulo = dr.GetString(dr.GetOrdinal("Titulo"));
                    item.Contenido = dr.GetString(dr.GetOrdinal("Contenido"));
                    item.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    item.prioridad = dr.GetInt32(dr.GetOrdinal("prioridad"));
                    item.Idseccion = dr.GetInt32(dr.GetOrdinal("Idseccion"));
                    item.IdTipoNoticia = dr.GetInt32(dr.GetOrdinal("IdTipoNoticia"));
                    item.Idreportero = dr.GetInt32(dr.GetOrdinal("Idreportero"));
                    item.Idvideo = dr.GetInt32(dr.GetOrdinal("Idvideo"));
                    item.Idimagen = dr.GetInt32(dr.GetOrdinal("Idimagen"));
                    if (System.Convert.IsDBNull(dr["flg_req_mapa"]))
                        item.flg_req_mapa = false;
                    else
                        item.flg_req_mapa = dr.GetBoolean(dr.GetOrdinal("flg_req_mapa"));

                    if (System.Convert.IsDBNull(dr["flg_mapa"]))
                        item.flg_mapa = false;
                    else
                        item.flg_mapa = dr.GetBoolean(dr.GetOrdinal("flg_mapa"));

                    if (System.Convert.IsDBNull(dr["flg_publicado"]))
                        item.flg_publicado = false;
                    else
                        item.flg_publicado = dr.GetBoolean(dr.GetOrdinal("flg_publicado"));

                    if (System.Convert.IsDBNull(dr["flg_twitter"]))
                        item.flg_twitter = false;
                    else
                        item.flg_twitter = dr.GetBoolean(dr.GetOrdinal("flg_twitter"));
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
}