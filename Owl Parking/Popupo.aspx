<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Popupo.aspx.cs" Inherits="Owl_Parking.Popupo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Owl Parking S.A</title>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="js/materialize.js"></script>
    <script type="text/javascript" src="http://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.99.0/js/materialize.min.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.99.0/css/materialize.min.css" />
    <link rel="stylesheet" href="https://cdn.datatables.net/1.10.15/css/jquery.dataTables.min.css" />
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <script src="js/jsTabla.js"></script>
    <link href="estilos/stylo.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="white-text light-blue darken-4 center">

            <div>
                <div class="row">
                    <div class="col s12 m12 l12 xl12">
                        <asp:Label ID="LblComentario" runat="server" Text="Text"></asp:Label>
                    </div>
                    <div class="input-field col s12 m12 l12 xl12">
                        <i class="material-icons prefix">mode_edit</i>
                        <asp:TextBox ID="TxtComentario" runat="server" />
                        <label for="TxtComentario">Comentario</label>
                    </div>
                </div>
            </div>
            <asp:Button ID="BtnAgregarComentario" CssClass="waves-effect waves-light btn" runat="server" Text="Agregar Comentario" OnClick="BtnAgregarComentario_Click" />
        </div>

    </form>
</body>
</html>
