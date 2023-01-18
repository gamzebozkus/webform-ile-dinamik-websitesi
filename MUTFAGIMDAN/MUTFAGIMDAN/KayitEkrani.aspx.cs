using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class KayitEkrani : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonKayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Uyelik(UyeAd,UyeSoyad,UyeMail,UyeSifre,UteTel) values ('"+TextAd.Text+"', '"+TextSoyad.Text +"', '"+ TextMail.Text +"', '"+TextSifre.Text+ "', '" + TextTel.Text + "')", bgl.baglanti());
            cmd.ExecuteNonQuery();
        }
    }
}