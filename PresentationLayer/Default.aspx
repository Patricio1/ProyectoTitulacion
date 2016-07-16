<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Proyecto Titulación</title>
     <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/bootstrap-theme.min.css" rel="stylesheet"/>
    <link href="css/ie10-viewport-bug-workaround.css" rel="stylesheet"/>
    <link href="theme.css" rel="stylesheet"/>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>

  

    <style type="text/css">
        .auto-style1 {
            width: 49px;
        }
        .ancho {
            width:100%;
        }
        .margen {
        margin-top:10px;
        margin:100px
        }
        table
        {
            border-spacing:5px;
        }
    </style>
    <script>
        function marcar(boton, checkbox) {
            // $("#Button4").text("hola");
            // alert("hola");
            var val1 = document.getElementById(checkbox);
            if (!$(val1).is(":checked")) {
                var elemento = $("[id*='" + boton + "']");
                elemento.removeClass("btn btn-xs btn-success");
                elemento.addClass("btn btn-xs btn-warning");
                elemento.val("Por Verificar");
            }

            else {
                var elemento = $("[id*='" + boton + "']");
                elemento.removeClass("btn btn-xs btn-warning");
                elemento.addClass("btn btn-xs btn-success");
                elemento.val("OK");
            }

            /*var val1 = document.getElementById(identificador);
            val1.value = "OK";

            $("[id*='"+identificador+"']").removeClass("btn btn-xs btn-warning");
            $("[id*='" + identificador + "']").addClass("btn btn-xs btn-success");*/
        }
        function marcarCheckBox() {
            // OnClick = "marcar('Button4','CheckBox2');"
        }
    </script>
  
</head>
<body >

    
     <!-- Inicio Barra de Menu -->
    <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">Proyecto Titulación</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
          <ul class="nav navbar-nav">
            <li class="active"><a href="#">Verificar Requisitos</a></li>
            <li><a href="#">Procesos
                <span class="badge" style="background:red">5</span>
                </a></li>
            <li style="margin-right:100px"><a href="#about">Iniciar Sesión</a></li>
          </ul>
        </div><!--/. Fin Barra de Menu -->
      </div>
    </nav>

    <br /><br /><br /><br />
     <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
    <div class="container theme-showcase"  role="main">

      <!-- Main jumbotron for a primary marketing message or call to action-->
<div class="alert alert-info alert-dismissable">
  <button type="button" class="close" data-dismiss="alert">&times;</button>
  <strong>Informativo</strong> Para habilitar a un estudiante para el  proceso de Titulacion marca cada uno de los requisitos que tiene cumplido.
</div>
     
      <div class="jumbotron">



               <div class="row">
  <div class="col-md-4"><asp:TextBox ID="TextBox10" runat="server" CssClass="form-control" placeholder="Cédula Estudiante.." autofocus></asp:TextBox></div>
  <div class="col-md-4"><asp:Button ID="btnBuscarCedula" runat="server" Text="Buscar" CssClass="btn btn-primary" /></div>
  <div class="col-md-4"><asp:Button ID="btnBusquedaPersonalizada" runat="server" Text="Búsqueda Personalizada" CssClass="btn btn-primary" /></div>
</div>

 
                 
                  
                  
              



          <hr />
          <table class="nav-justified">
              <tr>
                  <td>
                      <asp:CheckBox ID="CheckBox7" runat="server" Text="Seleccione las casillas para actualizar el estado" /></td>
                  <td><asp:Button ID="Button11" runat="server"  Text="Marcar todos como OK" CssClass="btn btn-xs btn-success"  OnClick="Button11_Click1" /></td>
              </tr>
          </table>

          <hr />
        <div class="container">
                                           
  <div class="table-responsive">          
  
      <table class="nav-justified" style=" border-collapse: separate;border-spacing:5px 15px">
          <tr >
              <td class="auto-style1">
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox1" readonly="true" BackColor="White" placeholder="Nombre Estudiante" runat="server" CssClass="form-control"></asp:TextBox>
              </td>
              <td>
                  <asp:Button ID="Button2" runat="server" Text="OK" CssClass="btn btn-xs btn-success" />
              </td>
          </tr>
         
          <tr >
              <td class="auto-style1">
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox2" readonly="true" BackColor="White" placeholder="Numero de Creditos Aprobados" runat="server" CssClass="form-control"></asp:TextBox>
              </td>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="OK" CssClass="btn btn-xs btn-success" />
              </td>
          </tr>
       
          <tr >
              <td class="auto-style1">
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox3" readonly="true" BackColor="White" placeholder="Nombre Carrera" runat="server" CssClass="form-control"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button3" runat="server" Text="OK" CssClass="btn btn-xs btn-success" />
              </td>
          </tr>

           <tr >
              <td class="auto-style1">
                  <asp:CheckBox ID="CheckBox2" runat="server" OnClick="marcar('Button4','CheckBox2');" />
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox4" BackColor="White" Text="Creditos de la Malla Curricular" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button4" runat="server" Text="Por Verificar" CssClass="btn btn-xs btn-warning" />
              </td>
          </tr>
            <tr >
              <td class="auto-style1">
                  <asp:CheckBox ID="CheckBox1" runat="server" OnClick="marcar('Button5','CheckBox1');" />
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox5" BackColor="White" Text="Idiomas" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button5" runat="server" Text="Por Verificar" CssClass="btn btn-xs btn-warning" />
              </td>
          </tr>
            <tr >
              <td class="auto-style1">
                  <asp:CheckBox ID="CheckBox3" runat="server" OnClick="marcar('Button6','CheckBox3');" />
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox6" BackColor="White" Text="Cultura Fisica" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button6" runat="server" Text="Por Verificar" CssClass="btn btn-xs btn-warning" />
              </td>
          </tr>
            <tr >
              <td class="auto-style1">
                  <asp:CheckBox ID="CheckBox4" runat="server" OnClick="marcar('Button7','CheckBox4');"/>
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox7" BackColor="White" Text="Practicas Pre-profesionales" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button7" runat="server" Text="Por Verificar" CssClass="btn btn-xs btn-warning" />
              </td>
          </tr>
            <tr >
              <td class="auto-style1">
                  <asp:CheckBox ID="CheckBox5" runat="server" OnClick="marcar('Button8','CheckBox5');" />
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox8" BackColor="White" Text="Vinculacion" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button8" runat="server" Text="Por Verificar" CssClass="btn btn-xs btn-warning" />
              </td>
          </tr>
            <tr >
              <td class="auto-style1">
                  <asp:CheckBox ID="CheckBox6" runat="server" OnClick="marcar('Button9','CheckBox6');"/>
              </td>
              <td style="width:600px">
                  <asp:TextBox ID="TextBox9" BackColor="White" Text="Valores Adeudados" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
              </td>
              <td>
                 <asp:Button ID="Button9"  runat="server" Text="Por Verificar" CssClass="btn btn-xs btn-warning" />
              </td>
          </tr>
          <tr >
              <td class="auto-style1">
               
              </td>
              <td style="width:600px;vertical-align:bottom">
   <asp:Button ID="Button10" runat="server" Text="Guardar" CssClass="btn btn-primary" />
              </td>
              <td>              
              </td>
          </tr>

              
      </table>
  
  </div>

     

    </div> <!-- /container -->

      </div>
        </div>


   
    <div>
    
    </div>
       
         </ContentTemplate>
        <Triggers>
                 <asp:AsyncPostBackTrigger ControlID="Button11" EventName="Click">
                 </asp:AsyncPostBackTrigger>
             </Triggers>
    </asp:UpdatePanel> 
        
    </form>
   


     <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="js/jquery.min.js"><\/script>')</script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/docs.min.js"></script>
    <script src="js/ie10-viewport-bug-workaround.js"></script>
     <script type="text/javascript">
         /* $(document).ready(function () {
              $("#CheckBox1").attr('checked', true);
              $("#CheckBox2").attr('checked', true);
              $("#CheckBox3").attr('checked', true);
              $("#CheckBox4").attr('checked', true);
              $("#CheckBox5").attr('checked', true);
              $("#CheckBox6").attr('checked', true);
              for (var i =4; i < 10; i++) {
                  var boton = "Button"+i;               
                      var elemento = $("[id*='" + boton + "']");
                      elemento.removeClass("btn btn-xs btn-warning");
                      elemento.addClass("btn btn-xs btn-success");
                      elemento.val("OK");                
                  }
        });*/
         function checktodo() {

             /*  var elemento = $("[id*=Button12]");
               elemento.removeClass("btn btn-xs btn-warning");
               elemento.addClass("btn btn-xs btn-success");
               elemento.val("OK");*/
             $("#CheckBox1").attr('checked', true);
             $("#CheckBox2").attr('checked', true);
             $("#CheckBox3").attr('checked', true);
             $("#CheckBox4").attr('checked', true);
             $("#CheckBox5").attr('checked', true);
             $("#CheckBox6").attr('checked', true);

         }
    </script>
    
</body>
     
</html>
