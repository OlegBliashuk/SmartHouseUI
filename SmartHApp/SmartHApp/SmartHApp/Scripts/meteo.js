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

function editsensorpress(id) {
    $('#statesensorpress'+(id)).addClass('hidden');
    $('#editsensorpress'+(id)).removeClass('hidden');
}

function savesensorpress(id) {
    $('#editsensorpress' + (id)).addClass('hidden');
    var a = $('#numbersensorpress'+(id)).val();
    $.when($.post(window.setsensorpress, { temper: a, id: id }, function (data, result) {
        if (result == "success") {
            $('#press').load((location.href + " #press"));
        }
    })).then(showpress());
}

function editsensortemp(id) {
    $('#statesensortemp' + (id)).addClass('hidden');
    $('#editsensortemp' + (id)).removeClass('hidden');
}

function savesensortemp(id) {
    $('#editsensortemp' + (id)).addClass('hidden');
    var a = $('#numbersensortemp' + (id)).val();
    $.when($.post(window.setsensortemp, { temper: a, id: id }, function (data, result) {
        if (result == "success") {
            $('#press').load((location.href + " #press"));
        }
    })).then(showpress());
}