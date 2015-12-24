function showtoggle() {
    $('.lamps').addClass('hidden');
    $('.toggles').removeClass('hidden');
}

function showlamps() {
    $('.lamps').removeClass('hidden');
    $('.toggles').addClass('hidden');
}

function changeMainlamp() {
    var result = ($('#mainlampswitch').attr('checked'));
    var a;
    if (typeof result != 'undefined') {
        a = false;
    } else { a = true }
    $.when($.post(window.setmainlamp, { temper: a }, function (data, result) {
        if (result == "success") {
            $('#lamps').load((location.href + " #lamps"));
        }
    })).then(showlamps());
}

function changeMainToggle() {
    var result = ($('#maintoggleswitch').attr('checked'));
    var a;
    if (typeof result != 'undefined') {
        a = false;
    } else { a = true }
    $.when($.post(window.setmaintoggle, { temper: a }, function (data, result) {
        if (result == "success") {
            $('#toggles').load((location.href + " #toggles"));
        }
    })).then(showtoggle());
}

function setToggleto(id) {
    var result = ($('#toggleswitch'+(id)).attr('checked'));
    var a;
    if (typeof result != 'undefined') {
        a = false;
    } else { a = true }
    $.when($.post(window.setsensortoggle, { temper: a, id: id }, function (data, result) {
        if (result == "success") {
            $('#toggles').load((location.href + " #toggles"));
        }
    })).then(showtoggle());
}
function setLampto(id) {
    var result = ($('#lampswitch' + (id)).attr('checked'));
    var a;
    if (typeof result != 'undefined') {
        a = false;
    } else { a = true }
    $.when($.post(window.setsensorlamp, { temper: a, id: id }, function (data, result) {
        if (result == "success") {
            $('#lamps').load((location.href + " #lamps"));
        }
    })).then(showlamps());
}