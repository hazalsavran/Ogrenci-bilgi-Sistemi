<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="EntityAsp.Anasayfa" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v21.1, Version=21.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 125px
        }

        .auto-style6 {
            width: 86px;
        }

        .auto-style7 {
            width: 224px
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <table class="table table-bordered" style="width: 93%">


        <tr>
            <th>Kategori ID</th>
            <th>Kategori ADI</th>
            <th>İşlemler</th>
            <th>Güncelle</th>
        </tr>





        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KategoriID") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/KategoriSil.aspx?KategoriID="+ Eval("KategoriID")%>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/KategoriGuncelle.aspx?KategoriID="+ Eval("KategoriID")%>' CssClass="btn btn-info" runat="server">Güncelle</asp:HyperLink>
                    </td>

                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>
    <a href="KategoriEkle.aspx" class="btn btn-warning">Yeni Kayıt</a>
</asp:Content>
