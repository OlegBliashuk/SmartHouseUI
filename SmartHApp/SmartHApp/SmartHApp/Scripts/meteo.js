function editMaintemp() {
    $('#temperaturestate').addClass('hidden');
    $('#temperatureedit').removeClass('hidden');
}

function saveMaintemp() {
    $('#temperatureedit').addClass('hidden');
     var a = $('#numberedittemp').val();
     $.when($.post(window.setmaintemp, { temper: a }, function (data, result) {
         if (result == "success") {
             $('#temperature').load(location.href + " #temperature");
             
         }
     })).then(showtemp());
}

function editMainpress() {
    $('#pressstate').addClass('hidden');
    $('#pressedit').removeClass('hidden');
}

function saveMainpress() {
    $('#pressedit').addClass('hidden');
    var a = $('#numbereditpress').val();
    $.when($.post(window.setmainpress, { temper: a }, function (data, result) {
        if (result == "success") {
            $('#press').load((location.href + " #press"));
        }
    })).then(showpress());
}

function showtemp() {
    $('.press').addClass('hidden');
    $('.temperature').removeClass('hidden');
}

function showpress() {
    $('.press').removeClass('hidden');
    $('.temperature').addClass('hidden');
}