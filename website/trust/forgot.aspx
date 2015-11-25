<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="forgot.aspx.cs" Inherits="forgot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="middle" Runat="Server">


    <table style="width: 100%">
        <tr>
            <td style="color: #0000FF; font-size: large;">
                FORGOT PASSWORD</td>
        </tr>
    </table>
    <br />
    <br />

    <table style="width: 100%">
        <tr>
            <td style="height: 20px; width: 191px">
            </td>
            <td align="left" style="height: 20px; width: 125px; color: #FF3300">
                Userid</td>
            <td style="width: 53px; height: 20px">
                :</td>
            <td style="height: 20px; width: 149px">
                <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
                    AutoPostBack="True"></asp:TextBox>
            </td>
            <td style="height: 20px">
            </td>
        </tr>
        <tr>
            <td style="width: 191px">
                &nbsp;</td>
            <td align="left" style="width: 125px; color: #FF3300">
                Security Question</td>
            <td style="width: 53px">
                :</td>
            <td style="width: 149px">
                <asp:TextBox ID="TextBox2" readonly="true" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 191px">
                &nbsp;</td>
            <td align="left" style="width: 125px; color: #FF3300">
                Answer</td>
            <td style="width: 53px">
                :</td>
            <td style="width: 149px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 191px; height: 30px">
            </td>
            <td style="width: 125px; height: 30px">
            </td>
            <td style="width: 53px; height: 30px">
                <asp:Button ID="Button1" OnClick="submit_click" runat="server" Text="Submit" />
            </td>
            <td style="width: 149px; height: 30px">
            </td>
            <td style="height: 30px">
            </td>
        </tr>
        <tr>
            <td style="width: 191px">
                &nbsp;</td>
            <td style="width: 125px">
                &nbsp;</td>
            <td style="width: 53px">
                &nbsp;</td>
            <td style="width: 149px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <table style="width: 100%">
        <tr>
            <td style="font-size: medium; color: #0000FF">
                <asp:Label ID="Label2" Visible="false" runat="server" Text="Your Password is  :"></asp:Label>
            </td>
        </tr>
        <tr>
        <td style="height: 0px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="false" Font-Size="X-Large" 
                    style="color: #FF0000"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <br />
     <br />
    <br />
</asp:Content>

