<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastrarCategoria.aspx.cs" Inherits="WingTipToyzBatel.Views.CadastrarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row form-group">
            <div class="col-md-6">
                <asp:Label runat="server" ID="lblNome" Text="Nome: *" CssClass="control-label"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqNome" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="txtNome" CssClass="text-danger"> </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-12 text-center">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" OnClick="btnSubmit_Click" Text="Gravar"/>
            </div>
        </div>
</asp:Content>
