
(function () {
    'use strict';

    require.config({
        paths: {
            jquery: 'libs/jquery-2.1.1',
            handlebars: 'libs/handlebars-v1.3.0',
        }
    });

    require([ 'Modules/Data', 'Modules/ComboBox', 'handlebars','jquery'], function (data, ComboBox) {

        var people = data;
        var source = $('#source').html();       
        var template = Handlebars.compile(source);
        var result = template({
            people:people
        });
        $('#result').html(result);        
        $('#result').ComboBox();
        
    });
}());