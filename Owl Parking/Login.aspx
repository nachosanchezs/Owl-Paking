<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Owl_Parking.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Owl Parking S.A</title>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.js"></script>
    <script type="text/javascript" src="http://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.99.0/js/materialize.min.js"></script>
    <script src="js/jsTabla.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.99.0/css/materialize.min.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.15/css/jquery.dataTables.min.css" />
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link href="estilos/stylo.css" rel="stylesheet" />


    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper" class="row">
            <div class="col s1 m1 l4 xl4">
            </div>
            <div id="formulario" class="card-panel col s12 m10 l4 hoverable">
                <br />
                <br />
                <div class="center">
                    <img src="img/owl.png" />
                </div>
                <br />
                <br />
                <br />
                <br />
                <div class="input-field center">
                    <i class="material-icons prefix">account_circle</i>
                    <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
                    <label for="TxtCorreo">Correo Electronico </label>
                </div>
                <div class="input-field center">
                    <i class="material-icons prefix">vpn_key</i>
                    <asp:TextBox ID="TxtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                    <label for="TxtContraseña">Contraseña</label>
                </div>
                <div class="col s12 m12 l12 center">
                    <asp:Button ID="BtnEntrar" CssClass="waves-effect waves-light btn" runat="server" Text="Ingresar" OnClick="BtnEntrar_Click" />
                </div>
                <br />
                <br />
                <br />
            </div>
            <div class="s1 m4 l1 xl4">

            </div>
        </div>
    </form>
    <script>
        $(document).ready(function () {
            Materialize.updateTextFields();
        });
    </script>
</body>
</html>
