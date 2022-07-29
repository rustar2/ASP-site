<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     <table class="centers">
            <tr><td colspan="3">ogrenci kayıt formu</td></tr>
            <tr><td>Ogrenci TC NO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
            <tr><td>Ogrenci Adi Soyadi</td><td colspan="3"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
            <tr><td>Ogrencinin Adresi&nbsp;&nbsp;&nbsp; </td><td><asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox></td></tr>
            <tr><td colspan="3"><asp:Button ID="Button1" runat="server" Text="Button" 
                    onclick="Button1_Click" /></td></tr>
            
        </table>
</asp:Content>

