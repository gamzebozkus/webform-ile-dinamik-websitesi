using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class Tarifler : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            int id = Convert.ToInt32(Request.QueryString["Tarifid"]);
            SqlCommand komut = new SqlCommand("SELECT * from Tbl_Tarifler  inner join Tbl_Uyelik on Tbl_Uyelik.Uyeid=Tbl_Tarifler.Uyeid", bgl.baglanti());
        
            SqlDataReader dr1 = komut.ExecuteReader();
            Repeater1.DataSource = dr1;
            Repeater1.DataBind();
        }
        protected void DropDownkat_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand komut = new SqlCommand("SELECT * from Tbl_Kategoriler  inner join Tbl_Tarifler on Tbl_Kategoriler.Kategoriid=Tbl_Tarifler.Kategoriid inner join Tbl_Uyelik on Tbl_Tarifler.Uyeid=Tbl_Uyelik.Uyeid where Tbl_Tarifler.Kategoriid=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DropDownkat.SelectedValue);
            SqlDataReader dr1 = komut.ExecuteReader();
            Repeater1.DataSource = dr1;
            Repeater1.DataBind();


        }

      

        //protected void Button1_Click1(object sender, EventArgs e)
        //{
        //    int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
        //    int id = Convert.ToInt32(Request.QueryString["Tarifid"]);
        //    SqlCommand cmd = new SqlCommand("insert into Tbl_Favori(Tarifid) values (@p1)", bgl.baglanti());
        //    SqlDataReader dr1 = cmd.ExecuteReader();
        //    cmd.Parameters.AddWithValue("@p1", id.ToString());
        //}
    }
}