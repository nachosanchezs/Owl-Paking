$(document).ready(function () {
    $(".tablaJs").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
        columnDefs: [
            {
                 targets: [0, 1, 2],
                 className: 'mdl-data-table__cell--non-numeric'

            }
        ]

    });
});
