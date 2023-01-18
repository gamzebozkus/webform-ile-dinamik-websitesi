using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace MUTFAGIMDAN
{
    public partial class UyeProfil : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Session["Uyeid"] = dr["Uyeid"].ToString();
                
            }
        }
    }
}