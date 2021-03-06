/* globals $ */


function solve() {
    
    return function (selector) {
        var template = '<table class="items-table"><thead><tr><th>#</th>' +
                        '{{#each headers}}'+
                        '<th>{{this}}'+
                        '{{/each}}</tr></thead><tbody>'+
                        '{{#each items}}'+'<tr>'+
                        '<td>{{@index}}</td>'+
                        '<td>{{col1}}</td>'+
                        '<td>{{col2}}</td>' +
                        '<td>{{col3}}</td>' +
                        '{{/each}}'+
                        '</tr></tbody></table>';
        $(selector).html(template);
    };
};

module.exports = solve;



