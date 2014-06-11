(function toDo() {

    var idCounter = 0;

    var addButton = document.getElementsByClassName('add')[0];
    addButton.addEventListener('click', onAddButton);

    var deleteButton = document.getElementsByClassName('delete')[0];
    deleteButton.addEventListener('click', onDeleteButton);

    var showButton = document.getElementsByClassName('show')[0];
    showButton.addEventListener('click', onShowButton);

    var hideButton = document.getElementsByClassName('hide')[0];
    hideButton.addEventListener('click', onHideButton);

    var elements = [];

    function onAddButton() {
        var inputText = document.getElementsByTagName('input')[0];
        var item = inputText.value;
        var container = document.getElementById('container');
        var li = document.createElement('li');
        var label = document.createElement('label');
        var radio = document.createElement('input');
        radio.type = 'radio';
        radio.value = item;
        radio.name = 'ToDo';
        var id = 'id' + idCounter;
        idCounter++;
        radio.id = id;

        label.innerHTML = item;
        label.htmlFor = id;
        li.appendChild(radio);
        li.appendChild(label);
        container.appendChild(li);

        elements.push(radio);
    }
    function onDeleteButton() {
        var ul = document.querySelector('#container');
        var length = elements.length;
        for (var i = 0; i < length; i++) {
            if (elements[i].checked === true) {
                var liToRemove = elements[i].parentNode;
                ul.removeChild(liToRemove);
                elements[i].checked = false;
            }
        }
    }
    function onShowButton() {
        for (var i = 0; i < elements.length; i++) {
            var liToShow = elements[i].parentNode;
            liToShow.style.display = 'block';
        }
    }
    function onHideButton() {
        var ul = document.querySelector('#container');
        var length = elements.length;
        for (var i = 0; i < length; i++) {
            if (elements[i].checked === true) {
                var liToHide = elements[i].parentNode;
                liToHide.style.display = 'none';
            }
        }
    }
}());