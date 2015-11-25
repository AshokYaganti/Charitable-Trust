<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="donators.aspx.cs" Inherits="donators" %>

<asp:Content ID="Content1" ContentPlaceHolderID="middle" Runat="Server">

    <table style="width:100%">
<tr>
<td style="color: #0000FF; font-size: large;">

    DONATORS LIST</td>
</tr>
</table>
<br />
 <asp:Panel ID="panelContainer" runat="server" Height="500" Width="100%"  ScrollBars="Vertical">
<asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
    <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:TemplateField HeaderText="Memship ID">
                 <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("memshipid") %>'></asp:Label>
               </ItemTemplate>             
         </asp:TemplateField>
       <asp:TemplateField HeaderText="Name">
             <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("name") %>'></asp:Label>
               </ItemTemplate>                  
        </asp:TemplateField>
     <asp:TemplateField HeaderText="Father Name">
                  <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("fathername") %>'></asp:Label>
               </ItemTemplate>             
        </asp:TemplateField>
     <asp:TemplateField HeaderText="Qualification">
                      <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("qualification") %>'></asp:Label>
               </ItemTemplate>         
        </asp:TemplateField>
     <asp:TemplateField HeaderText="Amount" >
                      <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("amount") %>'></asp:Label>
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
</asp:Content>


