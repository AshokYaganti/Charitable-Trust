<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="comments.aspx.cs" Inherits="comments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="middle" Runat="Server">
 <table style="width: 100%">
        <tr>
            <td style="width: 122px">
                Comment</td>
            <td style="width: 23px">
                :</td>
            <td>
                &nbsp;<asp:TextBox ID="TextBox1" TextMode="MultiLine" runat="server" Width="500" Height="70"></asp:TextBox></td>
        </tr>
        <tr>
        <td></td><td>&nbsp;</td><td><asp:Button ID="Button1" OnClick="post_click" runat="server" Text="Post" /></td>
        </tr>
    </table>

    <asp:Panel ID="panelContainer" runat="server" Height="500" Width="100%"  ScrollBars="Vertical">
    <asp:GridView ID="GridView1" runat="server" Width="100%" 
            AutoGenerateColumns="False"
            CellPadding="4" 
        ForeColor="#333333" GridLines="None">
    
            <AlternatingRowStyle BackColor="White" />
    
            <columns>           
      
                <asp:BoundField DataField="name" SortExpression="name" />
                <asp:BoundField DataField="comment" 
                    SortExpression="comment" />
                <asp:BoundField DataField="date1" SortExpression="date1" />


         </columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        </asp:Panel>
        <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>


