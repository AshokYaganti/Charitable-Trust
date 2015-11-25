<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="purchase.aspx.cs" Inherits="purchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="middle" Runat="Server">
<table style="width:100%">
<tr>
<td style="color: #0000FF; font-size: large;">

    PAYMENT DETAILS</td>
</tr>
</table>
<br />
<br />
    <table style="width: 100%">
        <tr>
            <td align="right" style="width: 329px; color: #FF3300">
                Select Category</td>
            <td style="width: 17px">
                :</td>
            <td align="left">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="0" Text="------select--------"></asp:ListItem>
                <asp:ListItem Value="item" Text="Item Wise"></asp:ListItem>
                <asp:ListItem Value="Student" Text="Student Wise"></asp:ListItem>
    </asp:DropDownList>&nbsp;</td>
        </tr>
    </table>
    
<br />
    
<br />
 <asp:Panel ID="panelContainer" runat="server" Height="500" Width="100%"  ScrollBars="Vertical">
<asp:GridView ID="GridView1"  runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false"
        GridLines="None" Width="100%">
    <AlternatingRowStyle BackColor="White" />
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
     <Columns>
        <asp:TemplateField HeaderText="Item Name">
                 <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("itemname") %>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
      
     <asp:TemplateField HeaderText="Quantity" >
                      <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("quantity") %>'></asp:Label>
               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="Amount">
                     <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("amount") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Year">
                     <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("year") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
    
    
    
    </Columns>
    </asp:GridView>

    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" 
        GridLines="None"  Width="100%">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
         <Columns>
        <asp:TemplateField HeaderText="Student Name">
                 <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("stdname") %>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
      
     <asp:TemplateField HeaderText="Amount" >
                      <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("amount") %>'></asp:Label>
               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="Year">
                     <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("year") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Address">
                     <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("address") %>'></asp:Label>
               </ItemTemplate>          
        </asp:TemplateField>
    
    
    
    </Columns>
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
    <br />
    <br />
</asp:Content>

