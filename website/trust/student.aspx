<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="middle" Runat="Server">
    <table style="width:100%">
<tr>
<td style="color: #0000FF; font-size: large;">

    STUDENTS DETAILS</td>
</tr>
    
</table>
<br />
<br />
<table style="width:100%">
<tr>
<td align="right" style="width: 328px; color: #FF3300">Select Year</td>
    <td style="width: 36px">:</td>
    <td align="left">  <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList> </td>
</tr>
</table>
<br />
<br />
 <asp:Panel ID="panelContainer" runat="server" Height="500" Width="100%"  ScrollBars="Vertical">
<asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="false"  
        CellPadding="4" ForeColor="#333333" GridLines="None">
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
       <asp:TemplateField HeaderText="Father Name">
             <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("stdfathername") %>'></asp:Label>
               </ItemTemplate>                  
        </asp:TemplateField>
     <asp:TemplateField HeaderText="DOB(dd-mm-yyyy)">
                  <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("dob") %>'></asp:Label>
               </ItemTemplate>             
        </asp:TemplateField>
     <asp:TemplateField HeaderText="School">
                      <ItemTemplate>
                <asp:Label ID="ID" runat="server" Text='<%#Eval("school") %>'></asp:Label>
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


