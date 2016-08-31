<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ComicBookStore.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Hello Welcome to Human Search.</h1>
        <h2>Please Enter The Name of the Human You want to Search.</h2>

        

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
        <!--<input type="text" id ="input_1" value ="human name" /> -->
        <asp:TextBox ID ="input_1" runat= "server" value="human"></asp:TextBox>
        
        <asp:Button ID ="myButton" runat ="server" text="submit" OnClick="button_clicked" />
        <asp:Timer ID ="timer1" runat="server" Interval="5000" OnTick="timer1_Tick"></asp:Timer>

        <br>
        <asp:Label ID ="timerLabel" runat ="server"></asp:Label>
        </ContentTemplate>

        </asp:UpdatePanel>

    </div>
    </form>
</body>
</html>
