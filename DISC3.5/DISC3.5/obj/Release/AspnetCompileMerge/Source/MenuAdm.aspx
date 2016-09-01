<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuAdm.aspx.cs" Inherits="DISC3._5.MenuAdm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Menu de Administrador</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</head>
<body>
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">WebSiteName</a>
            </div>
            <div>
                <ul class="nav navbar-nav">                    
                    <li><a href="ConUsuario.aspx">Control de Usuarios</a></li>
                    <li><a href="Informe.aspx">Resultados</a></li>
                    <li><a href="login.aspx">Salir</a></li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="container">
        <div class="col-lg-12">
            <img alt="" class="center-block" src="img/disc.png" />

        </div>
        
    </div>



    <div class="container footerM">
        <div class="row">
            <div class="col-lg-12 text-center ">
                <img class="img-responsive img-center" src="img/footer.png" alt=""/>
            </div>
        </div>
    </div>

</body>
</html>
