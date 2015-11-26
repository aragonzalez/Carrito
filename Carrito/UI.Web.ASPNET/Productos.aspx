<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="UI.Web.ASPNET.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

    <asp:Panel ID="ProductsGridPanel" runat="server">
    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="false" SelectedRowStyle-BackColor="LightSteelBlue"
        SelectedRowStyle-ForeColor="White" DataKeyNames="ProductID" OnSelectedIndexChanged="GridViewProducts_SelectedIndexChanged">
        <Columns>
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            <asp:BoundField HeaderText="Nombre del Producto" DataField="ProductName" />
            <asp:BoundField HeaderText="Precio" DataField="UnitPrice" />
        </Columns>
    </asp:GridView>
    </asp:Panel>

     <asp:Panel ID="ProductPanel" Visible="false" runat="server">
        <asp:Label ID="idProductLabel" runat="server" Text="ID: "></asp:Label>
        <asp:TextBox ID="idProductTextBox" runat="server" Text="" Enabled="false"></asp:TextBox> 
        <br />
        <asp:Label ID="productNameLabel" runat="server" Text="Nombre del Producto: "></asp:Label>
        <asp:TextBox ID="productNameTextBox" runat="server" Text="" Enabled="false"></asp:TextBox>
        <br />
        <asp:Label ID="countLabel" runat="server" Text="Cantidad: "></asp:Label>
        <asp:TextBox ID="countTextBox" runat="server" Text=""></asp:TextBox>
        <br />
    </asp:Panel>

    <asp:Label ID="errorLabel" runat="server" Text="ERROR!! " Visible="false"></asp:Label>
</asp:Content>


  