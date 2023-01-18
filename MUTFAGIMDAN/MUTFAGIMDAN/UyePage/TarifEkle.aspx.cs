using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace MUTFAGIMDAN
{
    public partial class TarifEkle : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        string id;
        
       int Uyeid;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Visible = false;
            //Button1.Visible = false;
            if (Page.IsPostBack==false)
            {
            id = Request.QueryString["Tarifid"];
         
            //KATEGORİ LİSTESİ
            SqlCommand komut2 = new SqlCommand("select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            DropDownListKategori.DataTextField = "KategoriIsim";
            DropDownListKategori.DataValueField = "Kategoriid";
            DropDownListKategori.DataSource = dr2;
            DropDownListKategori.DataBind();

            }
          
           
        }

        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            try
            {
               // string confirmValue = Request.Form["confirm_value"];
            Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
                string linkpath = @"/TarifFotograf/" + System.IO.Path.GetFileName(TarifFoto.PostedFile.FileName);
                TarifFoto.PostedFile.SaveAs(Server.MapPath(@"~\TarifFotograf\") + System.IO.Path.GetFileName(TarifFoto.FileName));
                //yemek ekleme
                SqlCommand komut = new SqlCommand("insert into Tbl_Tarifler(TarifIsim,TarifMalzeme,TarifYapilis,Kategoriid,Uyeid,TarifResim) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMalzeme.Text);
            komut.Parameters.AddWithValue("@p3", TxtYapilis.Text);
            komut.Parameters.AddWithValue("@p4", DropDownListKategori.SelectedValue);
            komut.Parameters.AddWithValue("@p5", Uyeid.ToString());
            komut.Parameters.AddWithValue("@p6", linkpath);
               MessageBox.Show("TARİF BAŞARIYLA EKLENDİ");
               // ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Başarılı', 'Başarıyla eklendi', 'success')", true);
                komut.ExecuteNonQuery();
            bgl.baglanti().Close();
                TxtAd.Text = "";
                TxtMalzeme.Text = "";
                TxtYapilis.Text = "";
                Response.Redirect("/UyePage/Tariflerim.aspx?Uyeid=" + Uyeid.ToString());
               
                
            }           
            catch (Exception)
            {
                throw;
            } 
        }
        //protected void Submit(object sender, EventArgs e)
        //{
        //    Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
        //    SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
        //    cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Session["Uyeid"] = dr["Uyeid"].ToString();

        //    }
        //    string confirmValue = Request.Form["confirm_value"];
        //    if (confirmValue == "Yes")
        //    {
        //        Response.Redirect("/UyePage/Tariflerim.aspx?Uyeid="+ Uyeid.ToString());
        //    }
            //else
            //{
            //    Response.Redirect("~/ViewData.aspx");
            //}
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
        //    SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1", bgl.baglanti());
        //    cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Session["Uyeid"] = dr["Uyeid"].ToString();

        //    }
        //    Response.Redirect("/Uyepage/Tariflerim.aspx?uyeid=" + Uyeid.ToString());
        //}
    }



  