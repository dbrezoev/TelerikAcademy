/* Това е допълнителна задачка с която си експериментирах */

(function () {        
        $('#dropdown').css({ display: 'none' });
        var divContainer = $('<div>').addClass('dropdown-list-container');
        var chosen = $('<div id="chosen">').text($('option').first().text());
        chosen.appendTo(divContainer);
        var ul = $('<ul>').addClass('dropdown-list-options');
        var optionsElements = $('option');
        for (var i = 0; i < optionsElements.length; i++) {
            var li = $('<li>');
            li.addClass('dropdown-list-option');
            li.attr('data-value', i);
            var content = $(optionsElements[i]).text();
            li.text(content);
            li.appendTo(ul);
        }
        ul.appendTo(divContainer);
        divContainer.appendTo(document.body);

        $('li').each(function () {
            $(this).on('click', function () {
                chosen.text($(this).text());
                $('ul').hide();
            });
        });

        chosen.on('click', function () {
            $('ul').toggle();
        });
    }
}());