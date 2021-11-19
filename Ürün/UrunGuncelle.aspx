<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAsp.Ürün.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server">
                    <div >
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

                        <asp:Button ID="Button1"  class="btn btn-info" runat="server" Text="Ürünü Güncelle" OnClick="Button1_Click"  />
                    </div>
                </form>

</asp:Content>
