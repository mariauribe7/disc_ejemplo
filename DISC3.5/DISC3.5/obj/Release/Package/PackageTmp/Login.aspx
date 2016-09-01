<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DISC3._5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/login.css" rel="stylesheet" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

</head>

<body class="tabla img-responsive">
    <br />
<br />
<br />
    <div class="container">
        <div class="login-container">
            <div class="avatar"></div>
            
                <form runat="server" id="Form1">
                    <div class="form-box">
                    <asp:TextBox ID="txtnombre" placeholder="usuario" runat="server" class="form-control" required=""></asp:TextBox>
                    <asp:TextBox ID="txtcontraseña" placeholder="contraseña" runat="server" class="form-control" required="" TextMode="Password"></asp:TextBox>
                    <br />
                  
                     </div>
                      <asp:Button ID="btningresar" Text="LOGIN" class="btn btn-info btn-block login form-control" runat="server" OnClick="btningresar_Click" />
                    <br />
                    <asp:Label ID="lblmensaje" CssClass="h3 label-warning text-danger" runat="server" Text=""></asp:Label>
                </form>
           
        </div>

    </div>
      <br />
    <br />
   
   <br />

    <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <img class="img-responsive img-center" src="img/footer.png" alt="" style="background-position: bottom"/>
                </div>
            </div>
        </div>
    </footer>

</body>


<script src="js/bootstrap.min.js"></script>
</html>
