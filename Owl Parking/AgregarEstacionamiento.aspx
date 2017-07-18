<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AgregarEstacionamiento.aspx.cs" Inherits="Owl_Parking.AgregarEstacionamiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="white-text">Agregar Estacionamiento</h2>
    <div class="row">
        <div class=" row white-text centered">
            <div class="input-field col s12  black-text">
                <asp:DropDownList ID="DdlTipo" CssClass="browser-default" runat="server">
                    <asp:ListItem Value="null">Elegir Tipo</asp:ListItem>
                    <asp:ListItem Value="Particular">Particular</asp:ListItem>
                    <asp:ListItem Value="Visita">Visita</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="input-field col s12 m6 l6">
                <i class="material-icons prefix">email</i>
                <asp:TextBox ID="TxtEmail" CssClass="validate" runat="server"></asp:TextBox>
                <label for="TxtEmail">Email</label>
            </div>
            <div class="input-field col s12 m6 l6">
                <i class="material-icons prefix">email</i>
                <asp:TextBox ID="TxtConfimarEmail" Enabled="true" CssClass="validate" runat="server"></asp:TextBox>
                <label for="TxtConfirmarEmail" data-error="" data-success=""></label>
                <label for="TxtConfirmarEmail">Confirmar Email</label>
            </div>
            <asp:Button ID="BtnAgregarEstacionamiento" CssClass="waves-effect waves-light btn teal darken-2" runat="server" Text="Agregar Estacionamiento" OnClick="BtnAgregarEstacionamiento_Click" />
        </div>
    </div>

</asp:Content>
