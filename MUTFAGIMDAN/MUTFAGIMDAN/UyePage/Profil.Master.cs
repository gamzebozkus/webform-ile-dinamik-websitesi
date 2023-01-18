using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class Profil : System.Web.UI.MasterPage
    {
        SqlSinif bgl = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
            //Uyeid = (string)cmd.ExecuteScalar().ToString();->veri tabanındaki ilk id ye sahip uyenin bilgilerini getirir.
            cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Giriş yapan üyenin tıkladığı sayfalara uye ile alakalı bilgiler taşınıyor.
                Session["UyeMail"] = dr["UyeMail"].ToString();
                Session["Uyeid"] = dr["Uyeid"].ToString();
                kullanici.Attributes["href"] = "/UyePage/UyeProfil.aspx?Uyeid=" + Uyeid.ToString();
                Anasayfa1.HRef = "/KullaniciPage/index.aspx?Uyeid=" + Uyeid.ToString();
                Tarifler.HRef= "/KullaniciPage/Tarifler.aspx?Uyeid=" + Uyeid.ToString(); 
                Anasayfa.HRef = "/KullaniciPage/index.aspx?Uyeid=" + Uyeid.ToString();
                profilduzenle.HRef= "/UyePage/ProfilDuzenle.aspx?Uyeid=" + Uyeid.ToString();  
                tarifekle.HRef= "/UyePage/TarifEkle.aspx?Uyeid=" + Uyeid.ToString();
                Tariflerim.HRef = "/UyePage/Tariflerim.aspx?Uyeid=" + Uyeid.ToString();
                YapSat.HRef = "/UyePage/YapSat.aspx?Uyeid=" + Uyeid.ToString();
                SatistakiYemeklerim.HRef = "/SatistakiYemeklerim.aspx?Uyeid=" + Uyeid.ToString();
            }
        }
    }
}
