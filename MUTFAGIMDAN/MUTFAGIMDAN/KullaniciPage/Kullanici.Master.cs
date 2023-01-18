using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class Kullanici : System.Web.UI.MasterPage
    {
        SqlSinif bgl = new SqlSinif();

        protected void Page_Load(object sender, EventArgs e)
        {
            //string Uyeid;
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
           
            //Uyeid = (string)cmd.ExecuteScalar().ToString();
            cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {//giriş yapan uyenin 
                Session["UyeMail"] = dr["UyeMail"].ToString();
                Session["Uyeid"] = dr["Uyeid"].ToString();
                kullanici.Attributes["href"] = "/UyePage/UyeProfil.aspx?Uyeid=" + Uyeid.ToString();
                Anasayfa.HRef = "/KullaniciPage/index.aspx?Uyeid=" + Uyeid.ToString();
                Tarifler.HRef = "/KullaniciPage/Tarifler.aspx?Uyeid=" + Uyeid.ToString();
                Anasayfa1.HRef = "/KullaniciPage/index.aspx?Uyeid=" + Uyeid.ToString();

            }
        }
    }
}