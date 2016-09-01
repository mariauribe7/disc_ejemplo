<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConUsuario.aspx.cs" Inherits="DISC3._5.ConUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <script src="../js/jquery.quicksearch.js" type="text/javascript"></script>
    <title>Control De Usaurio</title>
</head>
<body>
    <br />
    <div class="container">
        <div class="box" style="border-radius: 10px;">
            <form role="form" runat="server">
                <div class="row ">
                    <div class="form-group col-lg-4">
                        <label>
                            Identificacion</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
                            <asp:TextBox ID="txtid" CssClass="form-control" placeholder="Identificación" runat="server"
                                pattern="[0-9]{4,29}" MaxLength="30"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group col-lg-4">
                        <label>
                            Nombre</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox ID="txtnom" CssClass="form-control" placeholder="Nombre" runat="server"
                                pattern="[a-zA-Z\s]+" required="" MaxLength="30"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group col-lg-4">
                        <label>
                            Direccion</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-plane"></i></span>
                            <asp:TextBox ID="txtdir" CssClass="form-control" placeholder="Dirección"
                                runat="server" required="" pattern="[a-zA-Z0-9\s]+" MaxLength="255"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group col-lg-4">
                        <label>
                            Telefono</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-earphone"></i></span>
                            <asp:TextBox ID="txttel" CssClass="form-control" placeholder="Teléfono" runat="server"
                                pattern="[0-9]{7,10}" required="" MaxLength="10"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group col-lg-4">
                        <label>
                            Empresa</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-briefcase"></i></span>
                            <asp:TextBox ID="txtempresa" CssClass="form-control" placeholder="Empresa" runat="server"
                                pattern="[a-zA-Z0-9\s]+" required="" MaxLength="30"></asp:TextBox>

                        </div>
                    </div>

                    <div class="form-group col-lg-4">
                        <label>
                            Cargo</label>
                        <div class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-briefcase"></i></span>
                            <asp:TextBox ID="txtcargo" CssClass="form-control" placeholder="Cargo" runat="server"
                                pattern="[a-zA-Z0-9\s]+" required="" MaxLength="30"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group col-lg-4">
                        <label>
                            Tipo de Usuario</label>
                        <div class="dropdown">
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>

                        </div>
                    </div>
                    <div class="col-lg-12 text-center">
                        <div class="col-lg-3">
                            <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="GUARDAR" OnClick="btnguardar_Click" />
                        </div>

                        <div class="col-lg-3">
                            <asp:Button ID="btnconind" CssClass="btn btn-primary" runat="server" Text="CONSULTAR" OnClick="btnconind_Click" />
                        </div>
                        <div class="col-lg-3">
                            <asp:Button ID="btnlimpiar" CssClass="btn btn-default" runat="server"
                                Text="LIMPIAR" OnClick="btnlimpiar_Click" />
                        </div>
                        <div class="col-lg-3">
                            <asp:Button ID="btncancelar" CssClass="btn btn-default" runat="server"
                                Text="REGRESAR" OnClick="btncancelar_Click" />
                        </div>
                        <br />
                        <div class="col-lg-12 text-center">
                            
                        <br />
                        <asp:Label ID="lblmensaje" Text="" CssClass="label-warning h4" runat="server"></asp:Label>
                            </div>
                    </div>
                </div>

                <div class="row">
                    <hr />
                    <h2 class="intro-text text-center">Consulta General De <strong>Usuarios</strong>
                    </h2>
                    <hr />

                    <div class="panel-group" id="accordion">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">Usuarios</a>
                                </h4>
                            </div>
                            <div id="collapse1" class="panel-collapse collapse">
                                <div class="panel-body">
                                    <br />
                                    <div class="col-lg-4">

                                        <asp:TextBox ID="txtfiltro1" CssClass="form-control f1" runat="server" placeholder="Filtro"></asp:TextBox>
                                    </div>
                                    <div class="table-responsive col-lg-12" style="height: 400px; overflow: scroll;">
                                        <br />
                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DISC3._5.DataSet1TableAdapters.sp_consulta_general_clientesTableAdapter"></asp:ObjectDataSource>
                                        <asp:GridView ID="GridView1" CssClass="table table-striped table-bordered" runat="server"
                                            AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                                            <Columns>
                                                <asp:BoundField DataField="idsuario" HeaderText="Identificacion" ReadOnly="True" SortExpression="idsuario" />
                                                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                                                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                                                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                                                <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />
                                                <asp:BoundField DataField="Rol_empresa" HeaderText="Rol de la Empresa" SortExpression="Rol_empresa" />
                                                <asp:BoundField DataField="Rol_Login" HeaderText="Rol de Login" SortExpression="Rol_Login" />

                                            </Columns>
                                        </asp:GridView>
                                        <br />
                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </form>
        </div>
    </div>
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

</body>
<script type="text/javascript">
    $(document).ready(function () {
        var txtFiltro = '#' + '<%=txtfiltro1.ClientID %>';
            var grillaJedis = '#' + '<%=GridView1.ClientID %>';
            $(txtFiltro).quicksearch(grillaJedis + ' tbody tr');
        });
</script>
</html>
