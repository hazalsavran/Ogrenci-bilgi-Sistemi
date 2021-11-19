<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Musteriler.aspx.cs" Inherits="EntityAsp.Müşteri.Musteriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#modal1">
        Yeni Müşteri Tanımla

    </button>

    <div class="modal" id="modal1">

        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 class="modal-title">Müşteri Ekleme Paneli</h2>
                </div>
                <form runat="server">
                    <div class="modal-body">
                        <label>Müşteri Ad Soyad:</label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>

                        <br />

                        <asp:Button ID="Button2" class="btn btn-info" runat="server" Text="Tanımla" OnClick="Button2_Click" />
                        <asp:Button ID="Button1" data-dismiss="modal" class="btn btn-danger" runat="server" Text="Vazgeç" />
                    </div>
                </form>
            </div>
        </div>

    </div>
    <br />
    <br />
    <table style="margin-top: 20px" class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Ad Soyad</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("MusteriID") %></td>
                    <td><%# Eval("MusteriAdSoyad") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>



    </table>

</asp:Content>
