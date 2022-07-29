using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class listeleme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection bag = new OleDbConnection();
        bag.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Server.MapPath("okul.accdb");
        bag.Open();

        string soru = "SELECT * FROM ogrenciler where adi like '%" + TextBox1.Text + "%'";

        OleDbCommand komut = new OleDbCommand(soru, bag);

        OleDbDataReader oku = komut.ExecuteReader();

        int sira = 1;
        Label1.Text = ""; Label2.Text = ""; Label3.Text = ""; Label4.Text = "";
        while (oku.Read())
        {
           Label1.Text += Convert.ToString(sira) + "<br>";
           Label2.Text += Convert.ToString(oku["tcno"]) + "<br>";
           Label3.Text += Convert.ToString(oku["adi"]) + "<br>";
           Label4.Text += Convert.ToString(oku["adres"]) + "<br>";
            sira = sira + 1;
        }

        bag.Close();
    }
}