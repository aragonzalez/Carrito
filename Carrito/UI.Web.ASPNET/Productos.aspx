<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="UI.Web.ASPNET.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="false" SelectedRowStyle-BackColor="LightSteelBlue"
        SelectedRowStyle-ForeColor="White" DataKeyNames="ProductID" OnSelectedIndexChanged="GridViewProducts_SelectedIndexChanged">
        <Columns>
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            <asp:BoundField HeaderText="Nombre del Producto" DataField="ProductName" />
            <asp:BoundField HeaderText="Precio" DataField="UnitPrice" />
        </Columns>
    </asp:GridView>
</asp:Content>


  