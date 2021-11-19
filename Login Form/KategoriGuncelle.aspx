<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="EntityAsp.KategoriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder=" Yeni Kategori Adını Girin.."></asp:TextBox>
           
        </div>
        <br />
          <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder=" Yeni Kategori Adını Girin.."></asp:TextBox>
           
        </div>
         <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-info" OnClick="Button1_Click"  />
        </div>
    </form>





</asp:Content>
