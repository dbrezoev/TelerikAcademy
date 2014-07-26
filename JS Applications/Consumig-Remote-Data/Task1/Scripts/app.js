/// <reference path="Modules/httpRequestModule.js" />
/// <reference path="Libs/q.js" />
(function () {

    var link = 'DATA/persons.js';

    httpRequester.getJSON(link)
        .then(function (data) {
            if (!data) {
                console.log('nqma data');
            }
            var persons = JSON.parse(data);
            console.log(persons[0])
            var ul = $('<ul>');
            for (var i = 0; i < persons.length; i++) {
                var person = persons[i];
                var li = $('<li>').html('NAME: ' + person.firstName + ' ' + person.lastName +
                    '; AGE: ' + person.age + '; MARK: ' + person.mark + ';');
                ul.append(li);
                $("#container").append(ul);
            }
            $("#container").append(ul);
        }, function (err) {
            $("#container").html('BAD THING HAPPENED');
        });

    //var personToSend = {
    //    firstName: 'Slavi',
    //    lastName: 'Trifonov',
    //    age: 25,
    //    mark: 10
    //}

    //httpRequester.postJSON(link, personToSend)
    //.then(function (data) {
    //    if (data) {
    //        $('#container').html('Person sent with name ' + personToSend.firstName)
    //    }
    //    else {
    //        $('#container').html(personToSend.firstName + ' was just sent to DB.');
    //    }
    //}, function (err) {
    //    if (err) {
    //        $('#container').html('ERROR OCCURED.')
    //    }
    //})

}());