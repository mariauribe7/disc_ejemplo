<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalUsr.aspx.cs" Inherits="DISC3._5.FinalUsr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Resultado</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</head>
<body class="tabla">
    <br />
    <div class="container">
        <div class="box">
            <form runat="server">
                <div class="row ">
                    <div class="col-lg-12 text-center img-responsive" style="border-radius: 10px;">
                        <img src="img/agradecimiento.png" class=" img-responsive img-thumbnail col-lg-12" alt="" />

                    </div>

                </div>
                <div class="text-center">

                    <h3 class="text-center text-danger alert-danger">Descarga tu Prueba</h3>

                </div>
                <%--<div class="row container">

                    <br />
                    <div class=" col-md-2 ">
                        <asp:LinkButton ID="LinkButton1" runat="server" Visible="false"
                            OnClientClick="_blank" OnClick="LinkButton1_Click"><img src="img/btn-dominante.png"  alt="" /></asp:LinkButton>

                    </div>

                    <div class="col-md-offset-1 col-md-2">
                        <asp:LinkButton ID="LinkButton2" runat="server" Visible="false"
                            OnClientClick="_blank" OnClick="LinkButton2_Click"><img src="img/btn-influyente.png"  alt="" /></asp:LinkButton>
                    </div>

                    <div class=" col-md-2 col-lg-offset-1">
                        <asp:LinkButton ID="LinkButton3" runat="server" Visible="false"
                            OnClientClick="_blank" OnClick="LinkButton3_Click"><img src="img/btn-solido.png"  alt="" /></asp:LinkButton>
                    </div>
                    <div class="col-md-offset-1 col-md-2">
                        <asp:LinkButton ID="LinkButton4" runat="server" Visible="false"
                            OnClientClick="_blank" OnClick="LinkButton4_Click"><img src="img/btn-concienzudo.png"  alt="" /></asp:LinkButton>
                    </div>
                </div>--%>
                <br />
                <div class="row ">
                    <div class="col-lg-6 col-sm-offset-4">
                        <asp:Button ID="btnsalir" runat="server" CssClass="btn btn-primary col-sm-offset-2 col-lg-4 " Text="Salir" OnClick="btnsalir_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>

</body>
</html>
