(function () {
    var items = [{
        value: 1,
        text: 'One'
    }, {
        value: 2,
        text: 'Two'
    }, {
        value: 3,
        text: 'Three'
    }, {
        value: 4,
        text: 'Four'
    }, {
        value: 5,
        text: 'Five'
    }];

    var source = document.getElementById('source').innerHTML;
    var template = Handlebars.compile(source);
    document.getElementById('result').innerHTML = template({
        items: items,
    });
}());