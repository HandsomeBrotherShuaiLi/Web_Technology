<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>1553534-李帅-登录界面</title>
    <script type=" text/javascript" language="javascript">
        function LoadForm()
        {
         alert("这是一个装载例子");
        }
        function unLoadForm()
        {               
        alert("这是一个卸载的例子");
        }
    </script>
</head>
<body onload="LoadForm();" onunload="unLoadForm();">
    <form id="form1" runat="server">
        
        <div>
            <a href="t.html">测试</a>
        </div>
    </form>
</body>
</html>
