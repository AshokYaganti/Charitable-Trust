<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="right" Runat="Server">

  <div class="lf loginCont">
<div class="topbar" style="height:10px; background-position:0 0;line-height:10px;">&nbsp;</div>

<div style="border-left:3px solid #D9E8EF; border-right:3px solid #D9E8EF; background-color:#F4FBFE; width:285px; padding-left:2px; height: 350px;">

       <div style="padding-top: 19px; padding-left: 10px; color:rgb(0, 0, 255);"><h2>Login With</h2></div>
  


<!-- error message div -->
<%--<div style="width:98%; display:none;" id="errDiv_out">
	<div style="float:left;width:25px">
		
	</div>
	<div style="float:left;font:normal 10px verdana,arial; color:#FF0000;width:90%" id="errDiv_in">
	</div>
</div>
--%>
<%--<form method="post" action="" onsubmit="return validateForm()" name="login" style="margin:0;padding:0;">--%>
<input type="hidden" name="formSubmitted" value="0">
<input type="hidden" name="URL" value="http%3A%2F%2Fmy.naukri.com">
<input type="hidden" name="remember_me" value="1">
<div style="padding:5px 10px;">

<div class="t12 cls" style="padding-top:15px; !padding-top:5px; _padding-top:5px;">Email ID:</div>
<input name="USERNAME" type="text" maxlength="100" id="username" style="width:210px; padding:2px;margin-top:5px;"  />

<div class="t12 cls" style="padding-top:15px; !padding-top:5px; _padding-top:5px;">Password:</div>
<input name="PASSWORD" type="password" maxlength="40" id="password" style="width:210px; padding:2px;margin-top:5px;" />


<div style="padding-top:10px;" class="cls"><input id="Submit1" name="Login" value="Login" onserverclick="login_click" runat="server"  class="button1"   type="submit" style="width:65px; height:30px"  /></div>
<div class="t12b" style="padding-top:5px;">
      <br />
      <a href="forgot.aspx" style="font-weight:normal;">Forgot Login Details?</a></div>
</div>
<div class="t12b" style="padding-top:5px;"> 
      <br />
    <asp:ImageButton ID="ImageButton1" ImageUrl="images/up.jpg" OnClick="register_click" Width="100" Height="50" runat="server" />
     
</div>
<br />
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

