<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="listeleme.aspx.cs" Inherits="listeleme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
    <tr><td>Arat:</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
    <td><asp:Button ID="Button1" runat="server" Text="Arat" onclick="Button1_Click" /></td>
        
    </tr>
    
</table>
<table>
<tr><td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
    <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
    <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
    <td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
    </tr>
    </table>
    
</asp:Content>

