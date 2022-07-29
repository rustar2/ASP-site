<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sil.aspx.cs" Inherits="sil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
                <tr><td>Silincek id</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:Button ID="Button1" runat="server" Text="Sil" onclick="Button1_Click" /></td>
                </tr>
        

    </table>
</asp:Content>

