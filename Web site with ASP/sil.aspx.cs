using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class sil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection bag = new OleDbConnection();
        bag.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("okul.accdb");
        bag.Open();
        string sorgu="DELETE * From ogrenciler where id="+TextBox1.Text;
        OleDbCommand komut = new OleDbCommand(sorgu, bag);
        komut.ExecuteNonQuery();
        bag.Close();
    }
}