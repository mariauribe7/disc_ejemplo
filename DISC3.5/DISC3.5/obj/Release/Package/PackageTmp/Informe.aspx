<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informe.aspx.cs" Inherits="DISC3._5.Informe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Informe</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link href="css/business-casual.css" rel="stylesheet" />
    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css" />
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
</head>
<body>
    <br />
    <br />
    <br />
    <div class="container">
        <div class="box" style="border-radius: 10px;">
            <form role="form" runat="server">
                <div class="row ">
                    <hr />
                    <h1 class="text-center">Informe</h1>
                    <hr />
                    <br />
                    <div class="form-group col-lg-offset-1">
                        <div class="input-group col-lg-4">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
                            <asp:TextBox ID="TextBox1" CssClass="form-control" placeholder="Identificación" runat="server"
                                pattern="[0-9]{4,29}" MaxLength="30"></asp:TextBox>
                        </div>
                        <br />
                        <asp:Label ID="lblmensaje" Text="" CssClass="label-warning h4" runat="server"></asp:Label>
                        <br />
                        <br />
                        <div class="input-group col-lg-4">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-pencil"></i></span>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                        </div>
                    </div>


                    <div class="form-group col-lg-11 col-lg-offset-1">
                        <div class="row">
                            <div class="col-lg-8">
                                <div>
                                    <asp:Button ID="btncolsultar" CssClass="btn btn-primary" runat="server" Text="Consultar" OnClick="btncolsultar_Click" />
                                    |
                                <asp:Button ID="btnregresar" CssClass="btn btn-default" runat="server" Text="Regresar" OnClick="btnregresar_Click" />

                                </div>
                                <br />
                                <div>
                                    <asp:Button ID="btngreporte" CssClass="btn btn-danger" runat="server" Text="Generar Reporte" OnClick="btngreporte_Click" />
                                    <asp:Button ID="btnlimpiar" CssClass="btn btn-default" runat="server" Text="Limpiar" OnClick="btnlimpiar_Click" />
                                </div>

                            </div>
                        </div>

                    </div>
                    </div>
                    <br />
                    <div class="panel-group" id="accordion">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <h4 class="panel-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">Resultados</a>
                                </h4>
                            </div>
                            <div id="collapse1" class="panel-collapse collapse in">
                                <div class="panel-body">

                                        <div class="col-lg-4">
                                            <br />
                                            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-danger" runat="server" Visible="false"
                                                OnClientClick="_blank" OnClick="LinkButton1_Click">Dominante</asp:LinkButton>
                                        </div>

                                        <div class="col-lg-4">
                                            <br />
                                            <asp:LinkButton ID="LinkButton2" CssClass="btn btn-danger" runat="server" Visible="false"
                                                OnClientClick="_blank" OnClick="LinkButton2_Click">Influyente</asp:LinkButton>
                                        </div>
                                        <div class="col-lg-4">
                                            <br />
                                            <asp:LinkButton ID="LinkButton3" CssClass="btn btn-danger" runat="server" Visible="false"
                                                OnClientClick="_blank" OnClick="LinkButton3_Click">Sólido</asp:LinkButton>
                                        </div>
                                        <div class="col-lg-4">
                                            <br />
                                            <asp:LinkButton ID="LinkButton4" CssClass="btn btn-danger" runat="server" Visible="false"
                                                OnClientClick="_blank" OnClick="LinkButton4_Click">Concienzudo</asp:LinkButton>
                                        </div>

                                        <div class="table-responsive col-lg-offset-4 col-lg-8 text-center">

                                            <asp:GridView ID="GridView1" CssClass="table table-striped table-bordered" runat="server"
                                                AutoGenerateColumns="False" AllowPaging="false">
                                                <Columns>
                                                    <asp:BoundField DataField="idsuario" HeaderText="Identificacion" ReadOnly="True" SortExpression="idsuario" />
                                                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                                                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                                                    <asp:BoundField DataField="Empresa" HeaderText="Empresa" SortExpression="Empresa" />

                                                </Columns>
                                            </asp:GridView>
                                            <asp:GridView ID="GridView3" runat="server" CssClass="table table-striped table-bordered text-center" AutoGenerateColumns="False" CellPadding="4"
                                                BackColor="Transparent">
                                                <Columns>
                                                    <asp:BoundField DataField="d1" HeaderText="D 1" SortExpression="d1" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d2" HeaderText="D 2" SortExpression="d2" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d3" HeaderText="D 3" SortExpression="d3" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d4" HeaderText="D 4" SortExpression="d4" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d5" HeaderText="D 5" SortExpression="d5" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d6" HeaderText="D 6" SortExpression="d6" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d7" HeaderText="D 7" SortExpression="d7" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d8" HeaderText="D 8" SortExpression="d8" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d9" HeaderText="D 9" SortExpression="d9" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d10" HeaderText="D 10" SortExpression="d10" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d11" HeaderText="D 11" SortExpression="d11" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="d12" HeaderText="D 12" ItemStyle-CssClass="resultado"
                                                        SortExpression="d12" ItemStyle-Width="40px" ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="SumaD" HeaderText="Resultado D" ReadOnly="True" SortExpression="SumaD"
                                                        ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center" />
                                                </Columns>

                                            </asp:GridView>
                                            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                                CssClass="table table-striped table-bordered">
                                                <Columns>
                                                    <asp:BoundField DataField="i1" HeaderText="I 1" SortExpression="i1" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i2" HeaderText="I 2" SortExpression="i2" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i3" HeaderText="I 3" SortExpression="i3" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i4" HeaderText="I 4" SortExpression="i4" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i5" HeaderText="I 5" SortExpression="i5" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i6" HeaderText="I 6" SortExpression="i6" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i7" HeaderText="I 7" SortExpression="i7" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i8" HeaderText="I 8" SortExpression="i8" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i9" HeaderText="I 9" SortExpression="i9" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i10" HeaderText="I 10" SortExpression="i10" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i11" HeaderText="I 11" SortExpression="i11" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="i12" HeaderText="I 12" SortExpression="i12" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="SumaI" HeaderText="Resultado I" ItemStyle-CssClass="resultado"
                                                        ReadOnly="True" SortExpression="SumaI" ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center" />
                                                </Columns>

                                            </asp:GridView>
                                            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                                CssClass="table table-striped table-bordered">
                                                <Columns>
                                                    <asp:BoundField DataField="s1" HeaderText="S 1" SortExpression="s1" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s2" HeaderText="S 2" SortExpression="s2" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s3" HeaderText="S 3" SortExpression="s3" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s4" HeaderText="S 4" SortExpression="s4" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s5" HeaderText="S 5" SortExpression="s5" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s6" HeaderText="S 6" SortExpression="s6" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s7" HeaderText="S 7" SortExpression="s7" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s8" HeaderText="S 8" SortExpression="s8" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s9" HeaderText="S 9" SortExpression="s9" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s10" HeaderText="S 10" SortExpression="s10" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s11" HeaderText="S 11" SortExpression="s11" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="s12" HeaderText="S 12" SortExpression="s12" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="SumaS" HeaderText="Resultado S" ItemStyle-CssClass="resultado"
                                                        ReadOnly="True" SortExpression="SumaS" ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center" />
                                                </Columns>

                                            </asp:GridView>
                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                                CssClass="table table-striped table-bordered">
                                                <Columns>
                                                    <asp:BoundField DataField="c1" HeaderText="C 1" SortExpression="c1" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c2" HeaderText="C 2" SortExpression="c2" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c3" HeaderText="C 3" SortExpression="c3" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c4" HeaderText="C 4" SortExpression="c4" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c5" HeaderText="C 5" SortExpression="c5" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c6" HeaderText="C 6" SortExpression="c6" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c7" HeaderText="C 7" SortExpression="c7" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c8" HeaderText="C 8" SortExpression="c8" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c9" HeaderText="C 9" SortExpression="c9" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c10" HeaderText="C 10" SortExpression="c10" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c11" HeaderText="C 11" SortExpression="c11" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="c12" HeaderText="C 12" SortExpression="c12" ItemStyle-Width="40px"
                                                        ItemStyle-HorizontalAlign="Center" />
                                                    <asp:BoundField DataField="SumaC" HeaderText="Resultado C" ItemStyle-CssClass="resultado"
                                                        ReadOnly="True" SortExpression="SumaC" ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Center" />
                                                </Columns>

                                            </asp:GridView>
                                        </div>
                                    </div>
                            </div>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse2">Documentos</a>
                                    </h4>
                                </div>
                            </div>
                            <div id="collapse2" class="panel-collapse collapse in">
                                <div class="panel-body">
                                    <div class="col-lg-12 text-center">

                                        <div class="col-lg-3">
                                            <a href="img/dominante.pdf" target="_blank" class="btn btn-warning">Dominante</a>
                                        </div>
                                        <div class="col-lg-3">
                                            <a href="img/influyente.pdf" target="_blank" class="btn btn-warning">Influyente</a>
                                        </div>
                                        <div class="col-lg-3">
                                            <a href="img/solido.pdf" target="_blank" class="btn btn-warning">Solido</a>
                                        </div>
                                        <div class="col-lg-3">
                                            <a href="img/concienzudo.pdf" target="_blank" class="btn btn-warning">Concienzudo</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>


                    </div>
            </form>

        </div>
    </div>

</body>
</html>
