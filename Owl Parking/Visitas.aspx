<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Visitas.aspx.cs" Inherits="Owl_Parking.Visitas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="white-text">Visitas</h2>
    <div class="card-panel">
        <asp:GridView ID="GvVisitas" DataKeyNames="Visita_Id" CssClass="display tablaJs responsive-table" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Visita_Id" HeaderText="Visita_Id" Visible="False" />
                <asp:BoundField DataField="Codigo" HeaderText="Código" ReadOnly="True" />
                <asp:BoundField DataField="Patente" HeaderText="Patente" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Torre" HeaderText="Torre" />
                <asp:BoundField DataField="Departamento" HeaderText="Departamento" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                <asp:BoundField DataField="Hora" HeaderText="Hora" ReadOnly="True" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" EditText="Agregar" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="{0}" SelectMethod="GetVisitas" TypeName="Owl_Parking.BLL.VisitasBLL" DeleteMethod="EliminarVisita" UpdateMethod="EditarVisita">
            <DeleteParameters>
                <asp:Parameter Name="Visita_Id" Type="Int32" />
                <asp:Parameter Name="Codigo" Type="String" />
                <asp:Parameter Name="Patente" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Torre" Type="String" />
                <asp:Parameter Name="Departamento" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="Hora" Type="DateTime" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Visita_Id" Type="Int32" />
                <asp:Parameter Name="Codigo" Type="String" />
                <asp:Parameter Name="Patente" Type="String" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Torre" Type="String" />
                <asp:Parameter Name="Departamento" Type="String" />
                <asp:Parameter Name="Telefono" Type="String" />
                <asp:Parameter Name="Hora" Type="DateTime" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </div>

</asp:Content>
