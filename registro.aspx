<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="prueba_final1.Content.registro" %>

<!DOCTYPE html>
 <html lang="en">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="Content/registro1.css" />
    <title>Registro</title>
</head>
<body>
    <form id="form1" runat="server">
         <section class="forma1">
          <h1>Registrarse
             </h1>
               <br />
                 <asp:Label ID="Label1" runat="server" Text="usuario" CssClass=" letreros"></asp:Label>
         <br />  
            <asp:TextBox ID="usure" runat="server" CssClass="control1" placeholder="usuario"></asp:TextBox>
                 <br />
                 <asp:Label ID="Label2" runat="server" Text="contraseña" CssClass=" letreros"></asp:Label>
             <br />
         <asp:TextBox ID="contrare" runat="server" CssClass="control1" placeholder="contraseña"></asp:TextBox>
                 <br />
                 <asp:Label ID="Label3" runat="server" Text="confirma tu contraseña" CssClass=" letreros"></asp:Label>
                <br />
                <asp:TextBox ID="contrare2" runat="server" CssClass="control1" placeholder="confirmar contraseña"></asp:TextBox>
                 <br />
                 <asp:Label ID="Label4" runat="server" Text="codigo estudiantil" CssClass=" letreros"></asp:Label>
             <br />
         <asp:TextBox ID="codigo_estudiantil" runat="server" CssClass="control1" placeholder="codigo estudiantil"></asp:TextBox>
                 <br />
               
                 <asp:Label ID="Label5" runat="server" Text="¿A que servicio te registras?" CssClass=" letreros"></asp:Label>
             <br />
             <br />
             <br />
             <asp:CheckBox ID="boxcomprador" runat="server" Text="comprador" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:CheckBox ID="boxvendedor" runat="server" Text="vendedor" />
             <br />
             <br />
               
       <asp:Label ID="datoserror" runat="server" Text="Label" CssClass=" letreros"></asp:Label>
              
             <br />
              
    <asp:Button ID="registrar1" runat="server" Text="Registrar" class=" botones1" OnClick="registrar1_Click"/>
       

        
   </section>
    </form>
</body>
</html>
