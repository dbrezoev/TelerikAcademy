(function () {
    $.fn.dropdownSelect = function () {
        var $this = $(this);
        $this.hide();
        var $div = $('<div>').addClass('dropdown-list-container');
        var $ul = $('<ul>').addClass('dropdown-list-options');
        var options = $('option');
        var count = options.length;
        for (var i = 0; i < count; i++) {
            var $li = $('<li>').attr({ 'data-value': i + 1 });
            $($li).addClass('dropdown-list-option');
            $($li).text($(options[i]).text());
            $($li).appendTo($ul);
        }

        $($ul).appendTo($div);
        $div.appendTo(document.body);

        var lis = $('li');
        lis.each(function () {
            var $this = $(this);
            $this.on('click', function () {
                $this.toggleClass('current');
                var selector = 'option[value= ' + $this.attr('data-value') + ']';
                if ($(selector).attr('selected') == 'selected') {
                    $(selector).removeAttr('selected')
                }
                else {
                    $(selector).attr('selected', 'selected');
                }

            })
        })

    }
}());