<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuUsr.aspx.cs" Inherits="DISC3._5.MenuUsr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Usuario</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/lightbox.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

</head>
<body>
    <nav class="navbar navbar-inverse ">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">WebSiteName</a>
            </div>
            <div>
                <ul class="nav navbar-nav">                    
                    <li><a href="Pregunta1.aspx">Prueba</a></li>
                    <li><a href="login.aspx">Salir</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container">
        <div class="row">
        <br />

        <div class="panel panel-danger">
            <div class="panel-heading text-center">
                <h2>INSTRUCCIONES PRUEBA DISC</h2>
            </div>
            <div class="panel-body">

                <div class="bs-example">
                   

                        <div class="row">
                            <br />
                            <div class="col-lg-4 col-lg-offset-2">

                                <div class="col-sm-6 col-md-3">
                                    <a class="example-image-link col-sm-6 col-md-4" href="img/instruc1.png"
                                        data-lightbox="example-set" data-title="Instrucciones">
                                        <img class="example-image" src="img/instruc12.png" alt="" /></a>
                                </div>
                            </div>
                            <div class="col-lg-4">
                                <div class="col-sm-6 col-md-3">
                                    <a class="example-image-link col-sm-6 col-md-4" href="img/ejemplo.png"
                                        data-lightbox="example-set" data-title="Instrucciones">
                                        <img class="example-image" src="img/ejemplo12.png" alt="" /></a>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <form runat="server">
                            <div class="row col-lg-5 text-center col-lg-offset-3">
                                <asp:Button runat="server"  ID="btnregresar" CssClass="btn btn-primary" Text="Regresar" OnClick="btnregresar_Click" />
                            </div>
                        </form>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <br />
    <br />
    <br />
    <br />
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-1"></div>
                <div class="col-lg-11">
                    <img class="img-responsive" src="img/footer.png" alt="" style="background-position: bottom"/>
                </div>
            </div>
        </div>
    </footer>
    <%--<div class="container footerM">
        <div class="row">
            <div class="col-lg-12 text-center ">
                <img class="img-responsive img-center" src="img/footer.png" alt=""/>
            </div>
        </div>
    </div>--%>
</body>
<script src="js/lightbox-plus-jquery.min.js"></script>
</html>
