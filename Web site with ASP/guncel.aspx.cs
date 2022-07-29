using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
public partial class guncel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection bag = new OleDbConnection();
        bag.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Server.MapPath("okul.accdb");
        bag.Open();

        string soru = "SELECT * FROM ogrenciler WHERE İd=" + Convert.ToInt16(TextBox1.Text);

        OleDbCommand komut = new OleDbCommand(soru, bag);

        OleDbDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            TextBox2.Text = Convert.ToString(oku["tcno"]);
            TextBox3.Text = Convert.ToString(oku["adi"]);
            TextBox4.Text = Convert.ToString(oku["adres"]);
        }
        bag.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        OleDbConnection bag = new OleDbConnection();
        bag.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=" + Server.MapPath("okul.accdb");
        bag.Open();
        string soru = "UPDATE ogrenciler set tcno='" + TextBox2.Text + "',adi='" + TextBox3.Text + "',adres='" + TextBox4.Text + "' where İd=" + Convert.ToInt16(TextBox1.Text);

        OleDbCommand komut = new OleDbCommand(soru, bag);

        komut.ExecuteNonQuery();

        bag.Close();
    }
}
