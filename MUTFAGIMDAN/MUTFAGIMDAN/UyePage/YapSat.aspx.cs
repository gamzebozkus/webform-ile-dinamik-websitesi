using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows;
using System.Data;
using System.IO;

namespace MUTFAGIMDAN
{
    public partial class YapSat : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        string id;
        int Uyeid;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["Yemekid"];

                //KATEGORİ LİSTESİ
                SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
                SqlDataReader dr2 = komut2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriIsim";
                DropDownList1.DataValueField = "Kategoriid";
                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
                //Ildoldur();
                //Ilcedoldur()
                bgl.baglanti().Close();
            }

        }

        protected void ButtonGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
                // string linkpath = @"/TarifFotograf/" + Path.GetFileName(TarifFoto.PostedFile.FileName);
                //string klasor = Server.MapPath("~/TarifFotograf/");
                //if (Directory.Exists(klasor) == false)
                //{
                //    Directory.CreateDirectory(klasor);
                //}
                //TarifFoto.SaveAs(Server.MapPath(@"~\TarifFotograf\")+linkpath+"\\"+ Path.GetFileName(TarifFoto.FileName));


                //yemek ekleme
                SqlCommand komut = new SqlCommand("insert into Tbl_SatilanYemekler(YemekIsim,YemekAciklama,YemekFiyat,Kategoriid,Uyeid,sehirid,id) values (@p1,@p2,@p3,@p4,@p5,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TextBox1.Text);
                komut.Parameters.AddWithValue("@p2", TextBox2.Text);
                komut.Parameters.AddWithValue("@p3", TextBox3.Text);
                komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                komut.Parameters.AddWithValue("@p5", Uyeid.ToString());
                //  komut.Parameters.AddWithValue("@p6", linkpath);
                komut.Parameters.AddWithValue("@p7", DropDownil.SelectedValue);
                komut.Parameters.AddWithValue("@p8", DropDownilce.SelectedValue);


                // ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Başarılı', 'Başarıyla eklendi', 'success')", true);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("YEMEK BAŞARIYLA EKLENDİ");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";

                //Response.Redirect("/UyePage/.aspx?Uyeid=" + Uyeid.ToString());


            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}