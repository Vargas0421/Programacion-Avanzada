
let table = new DataTable('#tablaInventario');
$(document).ready(function () {
    $('#miPrimerAlerta').on('click', function () {

        Swal.fire({
            title: "Mi primer hello world!",
            text: "este es mi rimer hola muno !",
            icon: "success"
        });

    });

});