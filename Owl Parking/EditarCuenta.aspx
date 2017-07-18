<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarCuenta.aspx.cs" Inherits="Owl_Parking.EditarCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="white-text">Editar Cuenta</h3>
    <div id="formulario" class="row">
        <div id="correo" class="col s12 m12 l12 xl12 white-text">
            <div class="input-field col s12 m6 l6 xl4">
                <i class="material-icons prefix">email</i>
                <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
                <label for="TxtCorreo">Ingrese Correo electronico</label>
            </div>
            <div class="col s12 m3 m3 xl3">
                <asp:Button ID="BtnVerCorreo" CssClass="waves-effect waves-light btn" runat="server" Text="Ver Cuenta" OnClick="BtnVerCorreo_Click" />
            </div>
        </div>
        <br />
        <hr />
        <div id="datos" class="row card-panel">
            <div class="center">
                <h5>DATOS</h5>
            </div>
            <div class="input-field col s12 m6 l6 xl6">
                <i class="material-icons prefix">account_circle</i>
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                <label for="TxtNombre">Nombre</label>
            </div>
            <div class="input-field col s12 m6 l6 xl6">
                <i class="material-icons prefix">info_outline</i>
                <asp:TextBox ID="TxtPatente" runat="server"></asp:TextBox>
                <label for="TxtNombre">Patente</label>
            </div>
            <div class="input-field col s12 m6 l6 xl6">
                <i class="material-icons prefix">phone</i>
                <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
                <label for="TxtNombre">Telefono</label>
            </div>
            <div class="input-field col s12 m6 l6 xl6">
                <i class="material-icons prefix">store</i>
                <asp:TextBox ID="TxtDepartamento" runat="server"></asp:TextBox>
                <label for="TxtNombre">Departamento</label>
            </div>
            <div class="input-field col s12 m6 l6 xl6">
                <i class="material-icons prefix">lock</i>
                <asp:TextBox ID="TxtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                <label for="TxtNombre">Contraseña</label>
            </div>
            <div class="input-field col s12 m6 l6 xl6">
                <i class="material-icons prefix">lock</i>
                <asp:TextBox ID="TxtConfirmarContraseña" runat="server" TextMode="Password"></asp:TextBox>
                <label for="TxtNombre">ConfirmarContraseña</label>
            </div>
            <div class="input-field col s12 m6 l6 black-text">
                <asp:Label ID="LblTorre" runat="server" Text="Elegir torre"></asp:Label>
                <asp:DropDownList ID="DdlTorre" CssClass="browser-default" runat="server">
                    <asp:ListItem Value="1">Torre 1</asp:ListItem>
                    <asp:ListItem Value="2">Torre 2</asp:ListItem>
                    <asp:ListItem Value="3">Torre 3</asp:ListItem>
                    <asp:ListItem Value="4">Torre 4</asp:ListItem>
                    <asp:ListItem Value="5">Torre 5</asp:ListItem>
                    <asp:ListItem Value="6">Torre 6</asp:ListItem>
                    <asp:ListItem Value="7">Torre 7</asp:ListItem>
                    <asp:ListItem Value="8">Torre 8</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="input-field col s12 m6 l6 black-text">
                <asp:Label ID="LblEstacionamiento" runat="server" Text="Elegir estacionamiento"></asp:Label>
                <asp:DropDownList ID="DdlEstacionamiento" CssClass="browser-default" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Codigo" DataValueField="Estacionamiento_Id">
                </asp:DropDownList>

                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetEstacionamientoParticular" TypeName="Owl_Parking.BLL.EstacionamientoBLL"></asp:ObjectDataSource>
            </div>

            <div class="row">
                <div class="col s12 m6 l4 xl4">
                    <asp:Button ID="BtnEditarCuenta" CssClass="waves-effect waves-light btn" runat="server" Text="Editar Cuenta" OnClick="BtnEditarCuenta_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
