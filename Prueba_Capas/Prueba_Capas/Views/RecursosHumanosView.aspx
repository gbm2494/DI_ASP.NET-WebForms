<%@ Page Title="Insertar recurso humano" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecursosHumanosView.aspx.cs" Inherits="Prueba_Capas.Views.RecursosHumanosView" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
       
        function successalert() {
            alert('Persona guardada con éxito');
        }
    </script>


    <h2>Insertar recurso humano</h2>
   
    <div class="row">

        <div class="col-sm-5 col-sm-offset-1">
            <div class="panel-body">
                
                <div class="form-group">
                    <div class="row">
                        <asp:label runat="server" text="Cédula:" CssClass="col-sm-4 col-sm-offset-1 control-label"></asp:label>
                            <div class="col-sm-6 col-sm-offset-1 ">
                            <asp:TextBox runat="server" ID="txtCedula"  CssClass="form-control">  </asp:TextBox>
                        </div>
                        </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <asp:label runat="server" text="Nombre:" CssClass="col-sm-4 col-sm-offset-1 control-label"></asp:label>
                            <div class="col-sm-6 col-sm-offset-1 ">
                            <asp:TextBox runat="server" ID="txtNombre"  CssClass="form-control">  </asp:TextBox>
                        </div>
                        </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <asp:label runat="server" text="Apellido 1:" CssClass="col-sm-4 col-sm-offset-1 control-label"></asp:label>
                            <div class="col-sm-6 col-sm-offset-1">
                            <asp:TextBox runat="server" ID="txtApe1"  CssClass="form-control">  </asp:TextBox>
                        </div>
                        </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <asp:label runat="server" text="Apellido 2:" CssClass="col-sm-4 col-sm-offset-1 control-label"></asp:label>
                            <div class="col-sm-6 col-sm-offset-1 ">
                            <asp:TextBox runat="server" ID="txtApe2"  CssClass="form-control">  </asp:TextBox>
                        </div>
                        </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <asp:label runat="server" text="Teléfono 1:" CssClass="col-sm-4 col-sm-offset-1 control-label"></asp:label>
                            <div class="col-sm-6 col-sm-offset-1 ">
                            <asp:TextBox runat="server" ID="txtTel1"  CssClass="form-control">  </asp:TextBox>
                        </div>
                        </div>
                </div>

                <div class="form-group">
                    <div class="row">
                        <asp:label runat="server" text="Teléfono 2:" CssClass="col-sm-4 col-sm-offset-1 control-label"></asp:label>
                            <div class="col-sm-6 col-sm-offset-1 ">
                            <asp:TextBox runat="server" ID="txtTel2"  CssClass="form-control">  </asp:TextBox>
                        </div>
                        </div>
                </div>

            </div>    
         </div>
    </div>

    
     <div class="row">
        <div class="col-lg-6">

                <div id="btnsBD" style="float: right">
                     <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" onClick="btnAceptar_Click"/>
                </div>
        </div>
    </div>
   
</asp:Content>