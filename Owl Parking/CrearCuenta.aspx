<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="Owl_Parking.CrearCuenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="row col s12 m11 l10">
            <div>
                <div class="input-field col s12 m6 l6">
                    <i class="material-icons prefix">account_circle</i>
                    <asp:TextBox ID="TxtNombre" CssClass="validate" runat="server"></asp:TextBox>
                    <label for="TxtNombre">Nombre</label>
                </div>
                <div class="input-field col s12 m6 l6">
                    <i class="material-icons prefix">email</i>
                    <asp:TextBox ID="TxtEmail" Enabled="true" CssClass="validate" runat="server" type="email"></asp:TextBox>
                    <label for="TxtEmail" data-error="" data-success=""></label>
                    <label for="TxtEmail">Email</label>
                </div>
                <div class="input-field col s12 m6 l6">
                    <i class="material-icons prefix">lock</i>
                    <asp:TextBox ID="TxtContraseña" CssClass="validate" runat="server" TextMode="password"></asp:TextBox>
                    <label for="TxtContraseña">Contraseña</label>
                </div>
                <div class="input-field col s12 m6 l6">
                    <i class="material-icons prefix">lock</i>
                    <asp:TextBox ID="TxtConfirmarContraseña" CssClass="validate" runat="server" TextMode="Password"></asp:TextBox>
                    <label for="TxtConfirmarContraseña">Confirmar Contraseña</label>
                </div>
                <div class="input-field col s12 m4 l4">
                    <i class="material-icons prefix">info_outline</i>
                    <asp:TextBox ID="TxtPatente" placeholder="Patente" CssClass="validate" runat="server" type="Text"></asp:TextBox>
                </div>
                <div class="input-field col s12 m4 l4">
                    <i class="material-icons prefix">phone</i>
                    <asp:TextBox ID="TxtTelefono" placeholder="Telefono" CssClass="validate" runat="server" type="Text"></asp:TextBox>
                </div>
                <div class="input-field col s12 m4 l4">
                    <i class="material-icons prefix">store</i>
                    <asp:TextBox ID="TxtDepartamento" placeholder="Departamento" CssClass="validate" runat="server" type="Text"></asp:TextBox>
                </div>
                <div class="input-field col s12 m6 l6 black-text">
                    <asp:DropDownList ID="DdlTorre" CssClass="browser-default" runat="server">
                        <asp:ListItem Value="null">Elegir torre...</asp:ListItem>
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
                    <asp:DropDownList ID="DdlEstacionamiento" CssClass="browser-default" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Codigo" DataValueField="Estacionamiento_Id">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetEstacionamientoParticular" TypeName="Owl_Parking.BLL.EstacionamientoBLL"></asp:ObjectDataSource>
                </div>
                <div class="row">
                    <div class="input-field col s12 m4 l4 ">
                        <asp:Button ID="BtnAgregarCuenta" CssClass="waves-effect waves-light btn teal darken-2" runat="server" Text="Agregar Cuenta" OnClick="BtnAgregarCuenta_Click" />
                    </div>
                    <div class="input-field col s12 m4 l4 ">
                        <asp:Button ID="BtnLimpiar" CssClass="waves-effect waves-light btn teal darken-2" runat="server" Text="Limpiar" />
                    </div>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
