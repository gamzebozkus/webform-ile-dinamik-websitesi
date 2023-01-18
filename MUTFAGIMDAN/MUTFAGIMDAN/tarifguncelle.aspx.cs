using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MUTFAGIMDAN
{
    public partial class tarifguncelle : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        string id;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Tarifid"]);
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Session["Uyeid"] = dr["Uyeid"].ToString();
            }

            //int Tarifid = Convert.ToInt32(Request.QueryString["Tarifid"].ToString());
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd1 = new SqlCommand("select * from Tbl_Tarifler where Tarifid=@p1", bgl.baglanti());
                cmd1.Parameters.AddWithValue("@p1", id.ToString());
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    
                    TxtAd.Text = dr1[1].ToString();
                    TxtMalzeme.Text = dr1[2].ToString();
                    TxtYapilis.Text = dr1[3].ToString();

                }
            }
            bgl.baglanti().Close();
            if (Page.IsPostBack == false)
            {
                //KATEGORİ LİSTESİ
                SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                DropDownListKategori.DataTextField = "KategoriIsim";
                DropDownListKategori.DataValueField = "Kategoriid";
                DropDownListKategori.DataSource = dr2;
                DropDownListKategori.DataBind();
            }

        }

        protected void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            TarifFoto.SaveAs(Server.MapPath("/TarifFotograf/" + TarifFoto.FileName));
            int id = Convert.ToInt32(Request.QueryString["Tarifid"]);
            SqlCommand komut = new SqlCommand("update Tbl_Tarifler set TarifIsim=@p1,TarifMalzeme=@p2,TarifYapilis=@p3,kategoriid=@p4,TarifResim=@p6 where Uyeid=@p7 and Tarifid=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMalzeme.Text);
            komut.Parameters.AddWithValue("@p3", TxtYapilis.Text);
            komut.Parameters.AddWithValue("@p4", DropDownListKategori.SelectedValue);
            komut.Parameters.AddWithValue("@p6", "~/TarifFotograf/" + TarifFoto.FileName);

            komut.Parameters.AddWithValue("@p5", id.ToString());
            komut.Parameters.AddWithValue("@p7", Uyeid.ToString());


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}