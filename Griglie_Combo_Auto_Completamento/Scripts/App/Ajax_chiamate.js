

var Ajax_chiamate_Manager = (function () {
    var pub = {};

    //qui possiamo mettere i parametri generali ajax
    $.ajaxSetup({
        dataType: 'json',
        contentType: "application/json; charset=utf-8"
    });

  

    //metodi
    var _getNazione = function (nazione,handleData) {
        //funzione con callback per recupero dell'output, l'unico modo per recuperare
        //l'output in un processo asincrono quale è ajax è mediante una callback invocata nell'evento success
        $.ajax({
            type: "POST",
            url: "http://localhost:60819/ASPNET_Contents/Ajax.aspx/getCapitale",
            data: JSON.stringify({
                Nazione: nazione
            }),         
            success: function (msg) {
            
                var GetNazioneResultObj = new GetNazioneResult(msg.d.Capitale, msg.d.Abitanti, false);
                return handleData(GetNazioneResultObj);         
            },
            error: function (ex) {
                var GetNazioneResultObj = new GetNazioneResult(msg.d.Capitale, msg.d.Abitanti, true);
                return handleData(GetNazioneResultObj); 
            }

        });
    };

    //var _getStati = function (stato, handleData) {   
    //    $.ajax({
    //        type: "POST",
    //        url: "http://localhost:8093/api/values",
    //        data: JSON.stringify({
    //            Stato: stato
    //        }),
    //        success: function (msg) {

    //            var GetNazioneResultObj = new GetNazioneResult(msg.d.Capitale, msg.d.Abitanti, false);
    //            return handleData(GetNazioneResultObj);
    //        },
    //        error: function (ex) {
    //            var GetNazioneResultObj = new GetNazioneResult(msg.d.Capitale, msg.d.Abitanti, true);
    //            return handleData(GetNazioneResultObj);
    //        }

    //    });
    //};

    //classi private
    function GetNazioneResult(_capitale, _abitanti, _errore) {
        this.capitale = _capitale;
        this.Abitanti = _abitanti;
        this.Errore = _errore;
    }

    pub.getNazione = _getNazione;
    return pub;
}());