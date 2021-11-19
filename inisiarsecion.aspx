<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inisiarsecion.aspx.cs" Inherits="prueba_final1.inisiarsecion" %>

<!DOCTYPE html>
 <html lang="en">

<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="Content/secion1.css" />
    <title>Iniciar seción</title>
</head>
<body>
    <form id="form1" runat="server">
   <section class="forma">
       <h1>Iniciar sesión vendedor</h1>
  
          <asp:TextBox ID="txtusuaro" runat="server" CssClass="control" placeholder="usuario"></asp:TextBox>
         <asp:TextBox ID="txtcontraseña" runat="server" CssClass="control" placeholder="contraseña"></asp:TextBox>
              
       <asp:Label ID="datos" runat="server" Text=" "></asp:Label>
              
    <asp:Button ID="registrar" runat="server" Text="ingresar" class=" botones" OnClick="Button1_Click"/>
      

     

   </section>
   
    </form>
   
</body>
     
</html>
