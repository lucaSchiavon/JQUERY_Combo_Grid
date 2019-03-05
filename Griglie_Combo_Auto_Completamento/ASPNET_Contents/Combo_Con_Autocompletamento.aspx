<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Combo_Con_Autocompletamento.aspx.cs" Inherits="Griglie_Combo_Auto_Completamento.ASPNET_Contents.Combo_Con_Autocompletamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <!--https://stackoverflow.com/questions/37585676/autocomplete-dropdown-in-mvc5-->
    <!--https://www.jqueryscript.net/form/Autocomplete-Dropdown-Bootstrap-jQuery.html-->

    <!--MIGLIORI PLUGIN-->
    <!--https://ourcodeworld.com/articles/read/193/top-10-best-autocomplete-jquery-and-javascript-plugins-->
    <!--https://xdsoft.net/jqplugins/autocomplete/-->
    <!--http://easyautocomplete.com/examples-->
    <form id="form1" runat="server">
        <div>
            prima chiamata a array statico:
           <input type="text" class="form-control" id="auto1" placeholder="enter state" style="width: 300px"><br />
            seconda chiamata ad array di stringhe recuperato con chiamata ajax
            <input type="text" class="form-control" id="remote_auto1" placeholder="enter state" style="width: 300px">
            terza chiamata con recupero di oggetto con id
            <input type="text" class="form-control" id="remote_auto2" placeholder="enter state" style="width: 300px">
            <input type="button" id="BtnLanciaAjax" value="lancia ajax" />
        </div>
    </form>


</body>
<link type="text/css" rel="stylesheet" href="../Content/bootstrap.min.css" />
<link type="text/css" rel="stylesheet" href="../Vendor/jquery.autocomplete.css" />

<script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
<script src="../Vendor/jquery.autocomplete.js"></script>
<script type="text/javascript">
    var states = [
        'Alabama', 'Alaska', 'Arizona', 'Arkansas', 'California',
        'Colorado', 'Connecticut', 'Delaware', 'Florida', 'Georgia', 'Hawaii',
        'Idaho', 'Illinois', 'Indiana', 'Iowa', 'Kansas', 'Kentucky', 'Louisiana',
        'Maine', 'Maryland', 'Massachusetts', 'Michigan', 'Minnesota',
        'Mississippi', 'Missouri', 'Montana', 'Nebraska', 'Nevada', 'New Hampshire',
        'New Jersey', 'New Mexico', 'New York', 'North Carolina', 'North Dakota',
        'Ohio', 'Oklahoma', 'Oregon', 'Pennsylvania', 'Rhode Island',
        'South Carolina', 'South Dakota', 'Tennessee', 'Texas', 'Utah', 'Vermont',
        'Virginia', 'Washington', 'West Virginia', 'Wisconsin', 'Wyoming'
    ];
</script>
<script type="text/javascript">


    //prima chiamata a array statico
    $(function () {
        $("#auto1").autocomplete({
            source: [states]
        });
        //seconda chiamata ad array di stringhe recuperato con chiamata ajaz
        $("#remote_auto1").autocomplete({
            appendMethod: 'replace',
            source: [
                function (q, add) {
                    if (q != '') {
                        $.getJSON("http://localhost:8093/api/GetNations/" + encodeURIComponent(q), function (resp) {
                            //debugger;
                            add(resp)
                        })
                    }

                }
            ]
        });
        //seconda chiamata ad array di stringhe recuperato con chiamata ajaz
        $("#remote_auto2").autocomplete({
            appendMethod: 'replace',
            source: 
                function (q, add) {
                    if (q != '') {
                        $.getJSON("http://localhost:8093/api/GetNationsWithId/" + encodeURIComponent(q), function (resp) {
                            //debugger;
                            add($.map(resp, function (item) {
                                return {
                                    label: item.title,
                                    value: item.id
                                };
                            }))
                        })
                    }

                }
            
        });
        //https://stackoverflow.com/questions/9656523/jquery-autocomplete-with-callback-ajax-json
        //$('#remote_auto2').autocomplete({
        //    valueKey: 'title',
        //    source: [{
        //        url: "http://localhost:8093/api/GetNations/" + encodeURIComponent($('#remote_auto2').val()),
        //        type: 'remote',
        //        getValue: function (item) {
        //            return item.title
        //        },
        //        ajax: {
        //            dataType: 'jsonp'
        //        }
        //    }]
        //});
        //  //terza chiamata con recupero di oggetto con id
        //$('#remote_auto2').autocomplete({
        //    source: [
        //        function (q, add) {
        //            if (q != '')
        //                {
        //                    $.getJSON("http://localhost:8093/api/GetNationsWithId/" + encodeURIComponent(q), function (resp) {
        //                //debugger;
        //                add(resp)
        //            })
        //            }

        //        }
        //    ]
        //}).on('selected.xdsoft', function (e, datum) {
        //    alert(datum.id);
        //    alert(datum.title);
        //});
        ////terza chiamata con recupero di oggetto con id
        //$('#remote_auto2').autocomplete({
        //    source: [{
        //        data: [
        //            { id: 1, title: "alabama" },
        //            { id: 2, title: "alaska" },
        //            { id: 3, title: "georgia" },
        //            { id: 4, title: "texas" },
        //            { id: 6, title: "california" }
        //        ],
        //        getTitle: function (item) {
        //            return item['title']
        //        },
        //        getValue: function (item) {
        //            return item['title']
        //        },
        //    }]
        //}).on('selected.xdsoft', function (e, datum) {
        //    alert(datum.id);
        //    alert(datum.title);
        //});
        //jQuery('#remote_auto1').autocomplete('destroy');
        //$('#remote_auto2').autocomplete({
        //    source: [{
        //        data: [
        //            function (q, add) {
        //                $.getJSON("http://localhost:8093/api/GetNationsWithId/" + encodeURIComponent(q), function (resp) {
        //                    //debugger;
        //                    add(resp)
        //                })
        //            }
        //        ],
        //        getTitle: function (item) {
        //            return item['title']
        //        },
        //        getValue: function (item) {
        //            return item['title']
        //        },
        //    }).on('selected.xdsoft', function (e, datum) {
        //        alert(datum.id);
        //        alert(datum.title);
        //    });

        //$('#BtnLanciaAjax').bind('click', GetStati);

    });



</script>
</html>
