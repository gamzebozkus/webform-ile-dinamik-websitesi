using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MUTFAGIMDAN
{
    public partial class ProfilDuzenle : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        int Uyeid;
        protected void Page_Load(object sender, EventArgs e)
        {


            Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("select * from Tbl_Uyelik where Uyeid=@p1 ", bgl.baglanti());
                cmd.Parameters.AddWithValue("@p1", Uyeid.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //session ile uyeid sayesinde bilgiler taşındı
                    Session["UyeMail"] = dr["UyeMail"].ToString();
                    Session["Uyeid"] = dr["Uyeid"].ToString();
                    //dr ile veritabanından okunan veriler profilduzenle.aspx sayfasındaa gösteriliyor
                    TextBoxAd.Text = dr[1].ToString();
                    TextBoxSoyad.Text = dr[2].ToString();
                    TextBoxTel.Text = dr[7].ToString();
                }
                bgl.baglanti().Close();
            }
        }

        protected void ButtonGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false) { 
                  //kullanıcı fotograf ve bilgilerinin alınması gerçekleştirildi.
                    Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
                    string linkpath = @"/UyeResim/" + System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.PostedFile.SaveAs(Server.MapPath(@"~\UyeResim\") + System.IO.Path.GetFileName(FileUpload1.FileName));
                    if (Page.IsPostBack == false)
                    {
                        SqlCommand cmd = new SqlCommand("update Tbl_Uyelik set UyeAd=@p1, UyeSoyad=@p2, UteTel=@p3, UyeResim=@p5 where Uyeid=@p4", bgl.baglanti());
                        cmd.Parameters.AddWithValue("@p1", TextBoxAd.Text);
                        cmd.Parameters.AddWithValue("@p2", TextBoxSoyad.Text);
                        cmd.Parameters.AddWithValue("@p3", TextBoxTel.Text);
                        cmd.Parameters.AddWithValue("@p4", Uyeid.ToString());
                        cmd.Parameters.AddWithValue("@p5", linkpath);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("uyarı");
                    }
                   
                    bgl.baglanti().Close();
                } 
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Başarılı', 'Başarıyla kaydedildi', 'success')", true);
            }
            catch (Exception)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Hata!', 'Geçersiz Mail adresi veya şifre!', 'error')", true);
            }

        }
    }
}