using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace MUTFAGIMDAN
{
    public partial class YapSatDuzenle : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Yemekid"]); //formlar arası geçişi sağlıuor
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Session["Uyeid"] = dr["Uyeid"].ToString();
            }

            // int Yemekid = Convert.ToInt32(Request.QueryString["Tarifid"].ToString());
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd1 = new SqlCommand("select * from Tbl_SatilanYemekler where Yemekid=@p1", bgl.baglanti());
                cmd1.Parameters.AddWithValue("@p1", id.ToString());

                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    TextBox1.Text = dr1[1].ToString();
                    TextBox2.Text = dr1[5].ToString();
                    TextBox3.Text = dr1[4].ToString();

                }
            }
            bgl.baglanti().Close();
            if (Page.IsPostBack == false)
            {
                //KATEGORİ LİSTESİ
                SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriIsim";
                DropDownList1.DataValueField = "Kategoriid";
                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
            }
        }

        protected void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            //TarifFoto.SaveAs(Server.MapPath("/TarifFotograf/" + TarifFoto.FileName));
            int id = Convert.ToInt32(Request.QueryString["Yemekid"]);
            SqlCommand komut = new SqlCommand("update Tbl_SatilanYemekler set yemekIsim=@p1,yemekAciklama=@p2,yemekFiyat=@p3,kategoriid=@p4 where uyeid=@p7 and yemekid=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
           // komut.Parameters.AddWithValue("@p6", "~/TarifFotograf/" + TarifFoto.FileName);

            komut.Parameters.AddWithValue("@p5", id.ToString());
            komut.Parameters.AddWithValue("@p7", Uyeid.ToString());

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}