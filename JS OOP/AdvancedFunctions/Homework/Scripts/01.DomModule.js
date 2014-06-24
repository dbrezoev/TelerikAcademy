var DomModule = (function () {

    var fragmentBuffer = {},
        MAX_IN_BUFFER = 3;
    
    function addElement(parent, element) {
        var parents = document.querySelectorAll(parent);
        var newElement = document.createElement(element);
        for (var i = 0; i < parents.length; i++) {
            var clonedElement = newElement.cloneNode(true);
            parents[i].appendChild(clonedElement);
        }
    }

    function removeElement(selector) {
        var elementsToRemove = document.querySelectorAll(selector);
        for (var i = 0; i < elementsToRemove.length; i++) {
            elementsToRemove[i].parentNode.removeChild(elementsToRemove[i]);
        }
    }

    function attachEvent(selector, eventType, eventHandler) {
        var elementsToAttach = document.querySelectorAll(selector);
        for (var i = 0; i < elementsToAttach.length; i++) {
            elementsToAttach[i].addEventListener(eventType, eventHandler);
        }
    }

    function bufferAdd(parent, element) {
        if (!fragmentBuffer[element]) {
            fragmentBuffer[element] = document.createDocumentFragment();
        }

        var newElement = document.createElement(element);
        fragmentBuffer[element].appendChild(newElement);
        if (fragmentBuffer[element].childNodes.length === MAX_IN_BUFFER) {
            var parents = document.querySelectorAll(parent);
            for (var i = 0; i < parents.length; i++) {
                parents[i].appendChild(fragmentBuffer[element]);
            }

            fragmentBuffer[element] = null;
        }
    }

    //To work with CSS we have to import JQuery, or write parser
    function getElement(selector) {        
        var element = document.querySelector(selector);
        return element;
    }

    function getElements(selector) {
        var elements = document.querySelectorAll(selector);
        return elements;
    }

    return {
        addElement: addElement,
        removeElement: removeElement,
        attachEvent: attachEvent,
        bufferAdd: bufferAdd,
        getElement: getElement,
        getElements: getElements,
    }
}());