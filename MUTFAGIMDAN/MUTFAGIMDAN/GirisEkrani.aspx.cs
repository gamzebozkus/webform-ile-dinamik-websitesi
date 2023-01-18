using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class GirisEkrani : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGiris_Click(object sender, EventArgs e)
        {

            string Uyeid;
            SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where UyeMail='" + TextMail.Text + "'and UyeSifre='" + TextSifre.Text + "'", bgl.baglanti());
            Uyeid = (string)cmd.ExecuteScalar().ToString();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Session["UyeMail"] = dr["UyeMail"].ToString();
                Session["Uyeid"] = dr["Uyeid"].ToString();
               

                //Response.Redirect("/UyePage/ProfilDuzenle.aspx?Uyeid=" + Uyeid.ToString());
                Response.Redirect("/UyePage/UyeProfil.aspx?Uyeid=" + Uyeid.ToString());


            }
            else
            {

                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Hata!', 'Geçersiz Mail adresi veya şifre!', 'error')", true);
            }
        }

    }
}