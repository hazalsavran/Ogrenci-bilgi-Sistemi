<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="EntityAsp.Ürün.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <table class="table table-bordered" style="width: 93%">


        <tr>
            <th>Ürün ID</th>
            <th>Ürün ADI</th>
            <th>Marka</th>
            <th>Kategori</th>
            <th>Fiyat</th>
            <th>Stok</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>





        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("UrunID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("UrunMarka") %></td>
                    <td><%#Eval("KategoriAd") %></td>
                    <td><%#Eval("UrunFiyat") %></td>
                    <td><%#Eval("UrunStok") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"~/Ürün/UrunSil.aspx?UrunID="+ Eval("UrunID")%>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"~/Ürün/UrunGuncelle.aspx?UrunID="+ Eval("UrunID")%>' CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                    </td>

                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>

    <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#modal1">
        Yeni Ürün Gir

    </button>
    <div class="modal" id="modal1">

        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 class="modal-title">Yeni Ürün</h2>
                </div>
                <form runat="server">
                    <div class="modal-body">
                        <label>Ürün Adı :</label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>

                        <br />
                        <label>Marka :</label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>

                        <br />
                        <label>Kategori :</label>
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                        <br />
                        <label>Fiyat :</label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>

                        <br />
                        <label>Stok Durumu :</label>
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>

                        <br />

                        <asp:Button ID="Button1"  class="btn btn-info" runat="server" Text="Ürünü Kaydet" OnClick="Button1_Click" />
                    </div>
                </form>
            </div>
        </div>

    </div>

</asp:Content>
