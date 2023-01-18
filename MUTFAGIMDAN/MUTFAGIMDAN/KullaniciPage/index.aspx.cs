using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class index : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) { 
            if(Session["UyeMail"] != null)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Başarılı', 'Oturum açma başarılı!', 'success')", true);
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Hata!', 'session başarısız!', 'error')", true);
            }
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand komut = new SqlCommand("SELECT * from Tbl_SatilanYemekler  inner join Tbl_Uyelik on Tbl_SatilanYemekler.Uyeid=Tbl_Uyelik.Uyeid  ", bgl.baglanti());
      
            SqlDataReader dr1 = komut.ExecuteReader();
            Repeater1.DataSource = dr1;
            Repeater1.DataBind();


            // int Kategoriid = Convert.ToInt32(Request.QueryString["Kategoriid"].ToString());
            //SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler where Kategoriid=@p1", bgl.baglanti());
            //komut2.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //DropDownList1.DataTextField = "KategoriIsim";
            //DropDownList1.DataValueField = "Kategoriid";
            //DropDownList1.DataSource = dr2;
            //DropDownList1.DataBind();
        }}

        protected void DropDownilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand komut = new SqlCommand("SELECT * from Tbl_SatilanYemekler  inner join ilceler on Tbl_SatilanYemekler.sehirid=ilceler.sehirid inner join Tbl_Uyelik on Tbl_SatilanYemekler.Uyeid=Tbl_Uyelik.Uyeid where ilceler.id=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DropDownilce.SelectedValue);
            SqlDataReader dr1 = komut.ExecuteReader();
            Repeater1.DataSource = dr1;
            Repeater1.DataBind();

          
        }
    }
}