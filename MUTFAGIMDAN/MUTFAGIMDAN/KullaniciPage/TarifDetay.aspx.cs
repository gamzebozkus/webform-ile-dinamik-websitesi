using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace MUTFAGIMDAN
{
    public partial class TarifDetay : System.Web.UI.Page
    {
        SqlSinif bgl = new SqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());
            int id = Convert.ToInt32(Request.QueryString["Tarifid"]);
            SqlCommand komut = new SqlCommand("SELECT * from Tbl_Tarifler  inner join Tbl_Uyelik on Tbl_Tarifler.Uyeid=Tbl_Uyelik.Uyeid WHERE Tarifid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id.ToString());
            SqlDataReader dr1 = komut.ExecuteReader();
            Repeater1.DataSource = dr1;
            Repeater1.DataBind();

        }
    }
}