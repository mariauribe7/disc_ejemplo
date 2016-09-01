<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pregunta11.aspx.cs" Inherits="DISC3._5.Pregunta11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/login.css" rel="stylesheet" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <title>Pregunta 11</title>
</head>
<body class="pre">
    <div class="login-container">
        <div class="row">
            <form runat="server">
                <div class="form-box">

                    <hr />
                    <h4>Pregunta <strong>11</strong>
                    </h4>
                    <hr />

                    <div class=" form-group">
                        <label class="col-sm-3">Decidido</label>

                        <asp:TextBox ID="txtpre11_r1_d11" pattern="[1-4]{0,1}" runat="server" Style="width: 25%;" required="" MaxLength="1"></asp:TextBox>
                    </div>
                    <div class=" form-group">
                        <label class="col-sm-3">Alegre</label>
                        <asp:TextBox ID="txtpre11_r2_i11" pattern="[1-4]{0,1}" runat="server" Style="width: 25%;" required="" MaxLength="1"></asp:TextBox>
                    </div>

                    <div class=" form-group">
                        <label class="col-sm-3">Leal</label>
                        <asp:TextBox ID="txtpre11_r3_s11" pattern="[1-4]{0,1}" runat="server" Style="width: 25%;" required="" MaxLength="1"></asp:TextBox>
                    </div>

                    <div class=" form-group">
                        <label class="col-sm-3">Serio</label>
                        <asp:TextBox ID="txtpre11_r4_c11" pattern="[1-4]{0,1}" runat="server" Style="width: 25%;" required="" MaxLength="1"></asp:TextBox>
                    </div>

                </div>
                <asp:Button ID="btnenviar" runat="server" OnClientClick="return Validar()" CssClass="btn btn-info btn-block login" Text="Enviar" OnClick="btnenviar_Click" />
                <br />
                <asp:Label runat="server" ID="lblmensaje" CssClass="alert-warning"></asp:Label>

            </form>

        </div>
    </div>
      <br />
    <br />
 
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <img class="img-responsive img-center" src="img/footer.png" alt="" style="background-position: bottom" />
                </div>
            </div>
        </div>
    </footer>

       <script type="text/javascript">
           function Validar() {
               val1 = document.getElementById("txtpre11_r3_s11").value == "" ? "a1111" : document.getElementById("txtpre11_r3_s11").value;
               val2 = document.getElementById("txtpre11_r2_i11").value == "" ? "b1111" : document.getElementById("txtpre11_r2_i11").value;
               val3 = document.getElementById("txtpre11_r4_c11").value == "" ? "c1111" : document.getElementById("txtpre11_r4_c11").value;
               val4 = document.getElementById("txtpre11_r1_d11").value == "" ? "d1111" : document.getElementById("txtpre11_r1_d11").value;


               if (val1 != val2 &&
                       val1 != val3 &&
                       val1 != val4 &&
                       val2 != val3 &&
                       val2 != val4 &&
                       val3 != val4) {
                   return true;
               }
               else {
                   alert("Valores Iguales");
                   return false;
               }

           }


        </script>
</body>
</html>
