<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax_chiamate.aspx.cs" Inherits="Griglie_Combo_Auto_Completamento.ASPNET_Contents.Ajax_chiamate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <input type="text" placeholder="inserisci nazione" name="TxtNazione" id="TxtNazione"/><br />
            <div id="DivRichiestaDati">Clicca qui per la richiesta</div>
            <div id="contenitore"></div>
    <input type="button" value="Chiamata con $get" id="BtnGetCall" />
        </div>
    </form>
</body>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
     <script src="../Scripts/App/Ajax_chiamate.js"></script>
         <script type="text/javascript">
        
         $(document).ready(function () {

             $("#DivRichiestaDati").on("click", function () {
               
                 var _Nazione = $("#TxtNazione").val();
                  Ajax_chiamate_Manager.getNazione(_Nazione, function (output) {
                      debugger;
                      $("#contenitore").append("capitale: " + output.capitale + ", abitanti:" + output.Abitanti);
                 });
             
                 $("#contenitore").append("intanto vado avanti con esecuzione codice mentre aspetto");
               //var test=  Ajax_chiamate_Manager.getTest();
             });

             $("#BtnGetCall").click(function () {
                 debugger;
              $.get("http://localhost:8093/api/values", function(data, status){
                
                  alert("Data: " + data + "\nStatus: " + status);
              });
            });
             //$("#DivRichiestaDati").on("click", function () {
             //    //debugger;
             //    var _Nazione = $("#TxtNazione").val();
             //    $.ajax({
             //        type: "POST",
             //        url: "ajax.aspx/getCapitale",
             //        data: JSON.stringify({
             //            Nazione: _Nazione
             //        }),
             //        //data: "NomeUtente=" + NomeUtente ,
             //        contentType: "application/json; charset=utf-8",
             //        dataType: "json",
             //        //dataType: "html",
             //        beforeSend: function () {
             //            $("#contenitore").empty();
             //        },
             //        success: function (msg) {
             //            $("#contenitore").html("capitale: " + msg.d.Capitale + ", abitanti:" + msg.d.Abitanti);
             //        },
             //        //                     error: function (jqXHR, textStatus, errorThrown) {
             //        //                         alert("err refresh " + ucName);
             //        //                     }
             //        error: function (ex) {
             //            alert("Chiamata fallita, si prega di riprovare...");
             //        }

             //    });

          
             //});
         });
       

     </script>
</html>
