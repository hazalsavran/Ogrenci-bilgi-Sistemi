<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="EntityAsp.Satış.Satislar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

      <table class="table table-bordered" style="width: 93%">


        <tr>
            <th>Satış ID</th>
            <th>Ürün Adı </th>
            <th>Personel</th>
            <th>Müşteri</th>
            <th>Fiyat</th>
         
        </tr>


        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("SatışID") %></td>
                    <td><%#Eval("UrunAd") %></td>
                    <td><%#Eval("PersonelAdSoyad") %></td>
                    <td><%#Eval("MusteriAdSoyad") %></td>
                    <td><%#Eval("Fiyat") %></td>
                   
                    

                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>

   <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#modal1">
        Yeni Satış

    </button>

     <div class="modal" id="modal1">

        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 class="modal-title">Yeni Satış</h2>
                </div>
                <form runat="server">
                    <div class="modal-body">
                        <label>Ürün Seçin :</label>
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>

                        <br />
                        <label>Müşteri Seçin :</label>
                        <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server"></asp:DropDownList>

                        <br />
                        <label>Personel Seçin:</label>
                        <asp:DropDownList ID="DropDownList3" CssClass="form-control" runat="server"></asp:DropDownList>
                        <br />
                        <label>Fiyat :</label>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>

                        <br />
                        

                        <asp:Button ID="Button1"  class="btn btn-info" runat="server" Text="Satış Yap" OnClick="Button1_Click" />
                    </div>
                </form>
            </div>
        </div>

    </div>


</asp:Content>
