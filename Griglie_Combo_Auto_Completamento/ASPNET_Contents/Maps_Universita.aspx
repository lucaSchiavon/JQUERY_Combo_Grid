<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Maps_Universita.aspx.cs" Inherits="Griglie_Combo_Auto_Completamento.ASPNET_Contents.Maps_Universita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</head>
<body onload="initialize()">
    <form id="form1" runat="server">
        <div>
            

          <!--MYMAPS per aggiungere più punti in un iframe-->
             <!--https://www.google.com/maps/d/u/0/-->
             <!--qui il link dei punti universitari:-->
            <!--https://www.google.com/maps/d/u/0/edit?mid=10IEvbkhNoygGLaomW6XF4iMiWtt2NG0I&ll=45.40582876777307%2C10.99349970000003&z=18-->
           <iframe src="https://www.google.com/maps/d/u/0/embed?mid=10IEvbkhNoygGLaomW6XF4iMiWtt2NG0I" width="1880" height="960"></iframe>
        </div>
    </form>
</body>
   
</html>
