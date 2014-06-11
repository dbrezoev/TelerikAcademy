var addOn = (function () {
    'use strict'
    var makeTable = function (array) {
        var thead = $('<thead>');
        var tr = $('<tr>');
        for (var prop in array[0]) {
            var td = $('<td>').html(prop.toUpperCase());
            tr.append(td);
        }        
        thead.append(tr);
        var table = $('<table>').append(thead);

        var tbody = $('<tbody>');
        for (var i = 0; i < array.length; i++) {
            var tableRow = $('<tr>');
            for (var k in array[i]) {
                var tableData = $('<td>');
                tableData.html(array[i][k]);
                tableRow.append(tableData);
            }
            tbody.append(tableRow);
        }
        table.append(tbody);
        $('#content').append(table);
    }
    return {
        makeTable:makeTable
    }
}());