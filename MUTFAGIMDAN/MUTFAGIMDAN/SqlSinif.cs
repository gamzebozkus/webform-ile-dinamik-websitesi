using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace MUTFAGIMDAN
{
    public class SqlSinif
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-6R8RGVI7\SQLEXPRESS;Initial Catalog=Mutfagimdan;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        public DataTable TabloCek(string sqlcumle)
        {
            SqlConnection baglan = this.baglanti();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcumle, baglan);
            DataTable tbl = new DataTable();
            try
            {
                adapter.Fill(tbl);
            }
            catch (SqlException ex)
            {

                throw new Exception((ex.Message) + "(" + sqlcumle + ")");
            }
            adapter.Dispose();
            baglan.Close();
            baglan.Dispose();
            return tbl;
        }
    }

}