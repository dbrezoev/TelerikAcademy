(function () {
    var divsCount = 3;
    function addDivs() {
        function getRandomNumber(min, max) {
            return Math.floor(Math.random() * (max - min) + min);
        }
        function getRandomColor() {
            var red = (Math.random() * 256) | 0;
            var green = (Math.random() * 256) | 0;
            var blue = (Math.random() * 256) | 0;

            return "rgb(" + red + "," + green + "," + blue + ")";
        }

        function makeDivShiny(div) {
            var height = getRandomNumber(0, screen.height);
            var width = getRandomNumber(0, screen.width);
            var borderWidth = getRandomNumber(0, 15) + 'px';
            var borderRadius = getRandomNumber(0, 5) + 'px';
            var borderColor = getRandomColor();
            div.css({ width: getRandomNumber(15, 50), height: getRandomNumber(15, 50) });
            div.css({ top: height, left: width, position: 'absolute' });
            div.css({ border: borderWidth, 'border-radius': borderRadius, 'border-color': borderColor, 'border-style': 'solid' });
            div.text('text');
            div.css({ color: getRandomColor(), 'background-color': getRandomColor() })
            docFragment.append(div);

        }
        var docFragment = $(document.createDocumentFragment());
        for (var i = 0; i < divsCount; i++) {
            var div = $('<div></div>');
            makeDivShiny(div);
            docFragment.append(div);
        }
        $(document.body).append(docFragment);
    }

    function clearDivs() {
        var elementToErase = $('div');
        for (var i = 0; i < elementToErase.length; i++) {
            elementToErase[i].remove();
        }
    }

    $('#add').on('click', addDivs);
    $('#clear').on('click', clearDivs);
}());