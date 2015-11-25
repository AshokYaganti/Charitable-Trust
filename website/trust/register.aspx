<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="middle" Runat="Server">

    <table style="width: 100%">
  <tr><td style="width: 100%; color: #66FF33;">&nbsp;</td><marquee><h2><font color="#000099">Membership Registration</font></h2></marquee> </tr>
</table>
    <table style="width: 90%; height: 368px;">
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Full Name</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox1" runat="server" size="25"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Father Name</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox2" runat="server" size="25"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                User ID</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox3" runat="server" size="25"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Password</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox4" runat="server" size="25" TextMode="Password"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Confirm Password</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox5" runat="server" size="25" TextMode="Password"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
           
        </tr>
         <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Qualification</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox9" runat="server" size="25"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Security Question</td>
            <td style="width: 292px">
                <asp:DropDownList ID="DropDownList2" runat="server" ForeColor="Red" Width="175" 
                    style="color: #0000FF">
                    <asp:ListItem Text="-------------select--------------" Value="0"></asp:ListItem>
                    <asp:ListItem Text="your favorite hero name" Value="your favorite hero name"></asp:ListItem>
                    <asp:ListItem Text="mother madien's name" Value="mother madien's name"></asp:ListItem>
                    <asp:ListItem Text="your pet name" Value="your pet name"></asp:ListItem>
                    <asp:ListItem Text="favorite cricketer name" Value="favorite cricketer name"></asp:ListItem>
                    <asp:ListItem Text="your best friend name" Value="your best friend name"></asp:ListItem>
                    <asp:ListItem Text="your favorite channel" Value="your favorite channel"></asp:ListItem>
                    <asp:ListItem Text="your lucky number" Value="your lucky number"></asp:ListItem>
                    <asp:ListItem Text="your favorite game" Value="your favorite game"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Answer Question</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox8" runat="server" size="25" TextMode="Password"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
          <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Phone Number</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox7" runat="server" size="25" MaxLength="10"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px" align="left">
                &nbsp;</td>
            <td class="style5" style="width: 205px; color: #FF3300;" align="left">
                Address</td>
            <td style="width: 292px">
                <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px">
                &nbsp;</td>
            <td class="style5" style="width: 205px">
                &nbsp;</td>
            <td style="width: 292px" align="left">
                <asp:Button ID="Button1" runat="server" OnClick="button_click" Text="Submit" />
            </td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" style="width: 242px">
                &nbsp;</td>
            <td class="style5" style="width: 205px">
                &nbsp;</td>
            <td style="width: 292px">
                &nbsp;</td>
            <td style="width: 49px">
                &nbsp;</td>
            <td class="style5" style="width: 132px">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
