using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.Common;
using System.Data;

namespace RppitoNet.Models
{
    public class TipoNoticiaDL
    {

        //public string conexion = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"].ConnectionString;
        //public string provider = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"].ProviderName;
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"];

        public List<TipoNoticiaBE> Listado()
        {
            DbProviderFactory factoriaProveedor = DbProviderFactories.GetFactory(settings.ProviderName);

            DbConnection conexion = factoriaProveedor.CreateConnection();
            DbCommand cmd = factoriaProveedor.CreateCommand();
            //DbDataAdapter da;

            cmd.CommandText = "pa_Listado_TipoNoticia";
            cmd.CommandType = CommandType.StoredProcedure;

            List<TipoNoticiaBE> lista = new List<TipoNoticiaBE>();

            try
            {
                conexion.Open();
                DbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    TipoNoticiaBE item = new TipoNoticiaBE();
                    item.IdTipoNoticia = dr.GetInt32(dr.GetOrdinal("IdTipoNoticia"));
                    item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));

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
}