using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Odbc;
namespace SCC2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //

               if (FormView1.CurrentMode == FormViewMode.Insert)  
         {
             TextBox txtTest = FormView1.FindControl("IdvideoTextBox") as TextBox;  
             if (txtTest != null)  
             {
                 string strConnString = ConfigurationManager.ConnectionStrings["Rpp_DbConn"].ConnectionString;

                 System.Data.SqlClient.SqlConnection cnn = new System.Data.SqlClient.SqlConnection(strConnString);
                 System.Data.SqlClient.SqlCommand sqlcomm1 = new System.Data.SqlClient.SqlCommand("SELECT TOP (1) Idvideo AS ultimo FROM NodoVideos ORDER BY ultimo DESC", cnn); //Aqui esta el cambio
                 cnn.Open();
                 System.Data.SqlClient.SqlDataReader dr =  sqlcomm1.ExecuteReader();
                 while (dr.Read()) {
                     txtTest.Text = dr.GetInt32(0).ToString()  ;  
                 }
                 cnn.Close();

             }
             TextBox txtTest2 = FormView1.FindControl("IdtextoTextBox") as TextBox;
             if (txtTest2 != null)
             {
                 string strConnString = ConfigurationManager.ConnectionStrings["Rpp_DbConn"].ConnectionString;

                 System.Data.SqlClient.SqlConnection cnn = new System.Data.SqlClient.SqlConnection(strConnString);
                 System.Data.SqlClient.SqlCommand sqlcomm2 = new System.Data.SqlClient.SqlCommand("SELECT top(1) IdTexto AS ultimo FROM NodoTexto ORDER BY ultimo DESC", cnn); //Aqui esta el cambio
                 cnn.Open();
                 System.Data.SqlClient.SqlDataReader dr = sqlcomm2.ExecuteReader();
                 while (dr.Read())
                 {
                     txtTest2.Text = dr.GetInt32(0).ToString();
                 }
                 cnn.Close();

             }  
         }  
        }
        


    }
}



