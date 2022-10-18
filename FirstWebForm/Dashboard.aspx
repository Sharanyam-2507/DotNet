<%@ Page MasterPageFile="~/Site.Master"  Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FirstWebForm.Dashboard" %>
<asp:Content ContentPlaceHolderID="Pages" runat="server">

    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Name" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Email" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View Cookie Data" />
            <br />
            <br />
            <br />
            Data Bounding Item from session<br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                <asp:ListItem Value="K drama">Item 1</asp:ListItem>
                <asp:ListItem Value="C drama">Item 2</asp:ListItem>
                <asp:ListItem Value="K drama and Korean movies">Item 3</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            Data Bounded Manually<br />
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            Working with ViewState and GridView<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="ViewData" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
&nbsp;<br />
            <br />
        </div>
    </form>
</asp:Content>
