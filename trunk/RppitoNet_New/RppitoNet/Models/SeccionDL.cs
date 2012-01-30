using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.Common;
using System.Data;

namespace RppitoNet.Models
{
    public class SeccionDL
    {
        //public string conexion = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"].ConnectionString;
        //public string provider = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"].ProviderName;
        ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["RppitoNet.Properties.Settings.Setting"];


        public List<SeccionBE> Listado()
        {
            DbProviderFactory factoriaProveedor = DbProviderFactories.GetFactory(settings.ProviderName);

            DbConnection conexion = factoriaProveedor.CreateConnection();
            conexion.ConnectionString = settings.ConnectionString;
            conexion.Open();

            //DbCommand cmd = factoriaProveedor.CreateCommand();
            DbCommand cmd = conexion.CreateCommand();
            //DbDataAdapter da;

            cmd.CommandText = "pa_Listado_Seccion";
            cmd.CommandType = CommandType.StoredProcedure;

            List<SeccionBE> lista = new List<SeccionBE>();

            try
            {
                //conexion.Open();
                DbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    SeccionBE item = new SeccionBE();
                    item.Idseccion = dr.GetInt32(dr.GetOrdinal("Idseccion"));
                    item.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));

                    lista.Add(item);
                }

            }
            catch (Exception ex) {
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