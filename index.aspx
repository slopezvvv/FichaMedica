<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FichaMedica.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblIdPaciente" runat="server"></asp:Label><asp:TextBox ID="TxtIdPaciente" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblPNombre" runat="server"></asp:Label><asp:TextBox ID="TxtPNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblSNombre" runat="server"></asp:Label><asp:TextBox ID="TxtSNombre" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblPApellido" runat="server"></asp:Label><asp:TextBox ID="TxtPApellido" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblSApellido" runat="server"></asp:Label><asp:TextBox ID="TxtSApellido" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblEdad" runat="server"></asp:Label><asp:TextBox ID="TxtEdad" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblTipoSangre" runat="server"></asp:Label><asp:DropDownList ID="DrpTipoSangre" runat="server"></asp:DropDownList><br />
            <asp:Button ID="BtnRegistrarFicha" runat="server" />
        </div>
        <div>
            
        </div>
    </form>
</body>
</html>
