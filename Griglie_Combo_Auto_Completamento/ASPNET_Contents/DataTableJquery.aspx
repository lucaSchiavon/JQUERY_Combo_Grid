<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataTableJquery.aspx.cs" Inherits="Griglie_Combo_Auto_Completamento.ASPNET_Contents.DataTableJquery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <link rel="stylesheet" href="../Content/datatables.min.css" />
    <link href="../Content/themes/base/jquery-ui.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 90%; margin: 0 auto">
            <table id="myDatatable">
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last name</th>
                        <th>Email Id</th>
                        <th>City</th>
                        <th>Country</th>

                    </tr>
                </thead>
            </table>
        </div>
    </form>
</body>
<script src="../Scripts/jquery-3.3.1.min.js"></script>
<script src="../Scripts/jquery.validate.min.js"></script>
<script src="../Scripts/jquery-ui-1.12.1.min.js"></script>
<script src="../Scripts/datatables.min.js"></script>


<script>
    $(document).ready(function () {
        var oTable = $('myDatatable').DataTable({
            "ajax": {
                "url": '',
                "type": "get",
                "datatype": "json"
            },
            "columns": [
                { "data:": "FirstName", "autoWidth": true },
                { "data:": "LastName", "autoWidth": true },
                { "data:": "EmailID", "autoWidth": true },
                { "data:": "City", "autoWidth": true },
                { "data:": "Country", "autoWidth": true},
            ]
        })
    })
</script>
</html>
