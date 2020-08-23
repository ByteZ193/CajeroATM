// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#monto').on("change", function () {
    var item = $("#monto option: selected").text();

    $.post("/Home/Depositar", {
        data: item
    });
});



var disable = document.getElementById("monto");
disable.onchange = function () {
    if (this.value != "" || this.value.length > 0) {
        document.getElementById("ingresardinero").disabled = true;
        if (this.value == 0)
            document.getElementById("ingresardinero").disabled = false;
    }
    
}

var dis = document.getElementById("ingresardinero");
dis.onchange = function () {
    if (this.value != "" || this.value.length > 0) {
        document.getElementById("monto").disabled = true;
    }
    else {
        document.getElementById("monto").disabled = false;
    }
}

var disa = document.getElementById("retirodinero");
disa.onchange = function () {
    if (this.value != "" || this.value.length > 0) {
        document.getElementById("retiro").disabled = true;
        if (this.value == 0)
            document.getElementById("retiro").disabled = false;
    }

}

var di = document.getElementById("retiro");
di.onchange = function () {
    if (this.value != "" || di.value.length > 0) {
        document.getElementById("retirodinero").disabled = true;
    }
    else {
        document.getElementById("retirodinero").disabled = false;
    }
}


