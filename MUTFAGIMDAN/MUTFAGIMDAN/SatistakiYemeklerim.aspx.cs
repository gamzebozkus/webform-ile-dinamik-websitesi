using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows;

namespace MUTFAGIMDAN
{
    public partial class SatistakiYemeklerim : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        string id;
        string islem;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["Yemekid"];
                islem = Request.QueryString["islem"];
                int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
                SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Session["Uyeid"] = dr["Uyeid"].ToString();
                }
                //yemek listeleme
                SqlCommand komut = new SqlCommand("SELECT Uyeid,YemekIsim,Yemekid ,KategoriIsim from Tbl_SatilanYemekler inner join Tbl_Kategoriler on Tbl_SatilanYemekler.Kategoriid=Tbl_Kategoriler.Kategoriid where Uyeid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Uyeid.ToString());
                SqlDataReader dr1 = komut.ExecuteReader();
                DataList1.DataSource = dr1;
                DataList1.DataBind();
                if (islem == "sil")
                {
                    DialogResult dr2 = System.Windows.Forms.MessageBox.Show("Silmek istediğinize eminmisiniz?", "Confirmation", (MessageBoxButtons)MessageBoxButton.YesNo);
                    if (dr2 == DialogResult.Yes)
                    {
                        Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
                        id = Request.QueryString["Yemekid"];
                        SqlCommand komut2 = new SqlCommand("Delete From Tbl_SatilanYemekler where Uyeid=@p2 and Yemekid=@p1", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@p1", id.ToString());
                        komut2.Parameters.AddWithValue("@p2", Uyeid.ToString());
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();
                    }
                    else if (dr2 == DialogResult.No)
                    {
                        Response.Redirect("/SatistakiYemeklerim.aspx?Uyeid=" + Uyeid.ToString());
                    }
                    Response.Redirect("/SatistakiYemeklerim.aspx?Uyeid=" + Uyeid.ToString());

                }
            }
        }
    }
}