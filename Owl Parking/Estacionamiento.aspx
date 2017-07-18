<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Estacionamiento.aspx.cs" Inherits="Owl_Parking.Estacionamiento1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="white-text">Estacionamiento</h2>
    <div class="card-panel">
        <asp:GridView ID="GvEstacionamientos" CssClass="display tablaJs responsive-table" Width="100%" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original" SelectMethod="GetEstacionamientoPersona" TypeName="Owl_Parking.BLL.Estac_PersonaBLL"></asp:ObjectDataSource>
        <a class="waves-effect waves-light btn" href="AgregarEstacionamiento.aspx">AGREGAR ESTACIONAMIENTO</a>
        <a class="waves-effect red accent-4 btn" href="Notificaciones.aspx">Notificaciones</a>
        <asp:Label ID="LblTest" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
<%--        <asp:TextBox ID="txtUserName" runat="server" >nombre</asp:TextBox>
        <button onclick="ShowCurrentTime">go</button>--%>

    </div>

</asp:Content>
