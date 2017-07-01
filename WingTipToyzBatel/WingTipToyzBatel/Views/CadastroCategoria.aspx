<%@ Page Title="Cadastro de Categoria" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroCategoria.aspx.cs" Inherits="WingTipToysBatel.Views.CadastroCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center"><%:Title %></h1>
    <div class="form-horizontal" style="padding:3%">
        <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="lblCategoria" for="txtNome">Nome da Categoria</asp:Label>
            <div class="form-inline">
                <asp:TextBox runat="server" CssClass="form-control" id="txtNome" style="width:30%" placeholder="Categoria"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqNome" runat="server" 
                    ErrorMessage="Campo Obrigatório"
                     ControlToValidate="txtNome" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group" style="padding:10px; margin-left:15%">
            <div class="input-group">
                <asp:button runat="server" ID="btnLimpar" text="Limpar" CssClass="btn btn-default" style="border-radius:5px" OnClick="btnLimpar_Click" />
                <asp:button runat="server" ID="btnGravar" text="Salvar" CssClass="btn btn-primary" style="border-radius:5px" OnClick="btnGravar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
