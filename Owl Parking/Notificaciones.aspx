<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Notificaciones.aspx.cs" Inherits="Owl_Parking.Notificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Notificaciones</h2>
    <asp:DropDownList ID="DdlEstacionamientos" CssClass="browser-default" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Codigo" DataValueField="Estacionamiento_Id" AutoPostBack="True"></asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original" SelectMethod="GetEstacionamientoParticular" TypeName="Owl_Parking.BLL.EstacionamientoBLL"></asp:ObjectDataSource>
    <div class="card-panel">
        <asp:GridView ID="GvNotificaciones" CssClass="display tablaJs striped responsive-table" runat="server" DataSourceID="ObjectDataSource3">
        </asp:GridView>

        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="getNotificacionesPorEstacionamiento" TypeName="Owl_Parking.BLL.NotificacionBLL">
            <SelectParameters>
                <asp:ControlParameter ControlID="DdlEstacionamientos" DefaultValue="1" Name="Estacionamiento_Id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </div>
</asp:Content>
