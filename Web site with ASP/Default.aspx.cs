using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection bag = new OleDbConnection();
        bag.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("okul.accdb");
        bag.Open();
        string soru = "INSERT INTO ogrenciler(tcno,adi,adres) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
        OleDbCommand komut = new OleDbCommand(soru, bag);
        komut.ExecuteNonQuery();
        bag.Close();
    }
}