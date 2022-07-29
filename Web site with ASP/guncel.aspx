<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="guncel.aspx.cs" Inherits="guncel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table>
        <tr><td>Guncellencek id:</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td><asp:Button ID="Button1" runat="server" Text="Bul" onclick="Button1_Click" 
                    style="height: 26px" /></td>
                    
                    <tr><td>tcno&nbsp;</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
                    <tr><td>adi</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="Button2" runat="server" Text="Deiştir" onclick="Button2_Click" /></td>
                     </tr>
            <tr><td>adres</td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
       
        
       
    </table>
</asp:Content>

