<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memshipcard.aspx.cs" Inherits="memshipcard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CHARITABLE TRUST</title>
  
    <style type="text/css">
        .style1
        {
            width: 550px;
            height: 274px;
        }
        .style2
        {
            height: 61px;
        }
        .style3
        {
            height: 23px;
        }
        .style4
        {
            color: #FF3300;
        }
        .style5
        {
            height: 42px;
        }
        .style6
        {
            color: #000000;
        }
        .style7
        {
            height: 44px;
        }
    </style>
    <script type="text/javascript">
        function printpage() {
            window.print();
        }
    </script>
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
  
        <table class="style1" align="center" frame="border" 
            style="border: medium solid #000080">
            <tr>
                <td align="center" style="font-size: large; color: #0000FF;">
                    MEMBERSHIP CARD</td>
            </tr>
            <tr>
                <td class="style2">
                    <img src="images/id1.jpg" style="width: 550px; height: 62px" align="middle" /></td>
            </tr>
            <tr>
                <td colspan="1" align="left">
                    <span class="style4">Name</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    :&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="Label" style="color: #CC0066"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style4">&nbsp;MEMBERSHIP ID</span> :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Label" style="color: #CC0066"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" align="left">
                    <span class="style4">Father Name&nbsp; </span> 
                    <span class="style6">: </span> 
                    <span class="style4">&nbsp;&nbsp; </span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Label" style="color: #CC0066"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PH.NO&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Label" style="color: #CC0066"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <span 
                        class="style4"> 
                    ADDRESS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;       </span>&nbsp;</td>
            </tr>
            <tr>
                <td class="style5" align="center">
                    <asp:Label ID="Label5" runat="server" Text="Label" style="color: #CC0066"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
           <tr>
           <td align="center" class="style7">&nbsp;<input onclick="printpage()" type="button" value="Print" 
                   style="width: 64px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Button ID="Button1" runat="server" Text="HOME" onclick="Button1_Click" />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               </td>
           </tr>
        </table>
  
   </div>
    </form>
</body>
</html>
