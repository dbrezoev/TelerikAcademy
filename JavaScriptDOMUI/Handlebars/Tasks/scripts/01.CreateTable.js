(function () {
    var lectures = [{
        number: 1,
        title: 'Course Introduction',
        date1: 'Wed 18:00, 28-May-2014',
        date2: 'Thu 14:00, 29-May-2014',
    }, {
        number: 2,
        title: 'Document Object Model',
        date1: 'Wed 18:00, 28-May-2014',
        date2: 'Thu 14:00, 29-May-2014',
    }, {
        number: 3,
        title: 'HTML5 Canvas',
        date1: 'Thu 18:00, 29-May-2014',
        date2: 'Fri 14:00, 30-May-2014',
    }, {
        number: 4,
        title: 'Kinetic JS Overview',
        date1: 'Thu 18:00, 29-May-2014',
        date2: 'Fri 14:00, 30-May-2014',
    }, {
        number: 5,
        title: 'SVG and RaphaelJS',
        date1: 'Wed 18:00, 04-Jun-2014',
        date2: 'Thu 14:00, 05-Jun-2014',
    }, ];      

    var source = document.getElementById('source').innerHTML;
    var template = Handlebars.compile(source);
    var result = template({
        lectures: lectures
    });
    document.getElementById('result').innerHTML = result;
}());