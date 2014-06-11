(function () {

    function onClearDivsButtonClick() {
        var elementToErase = document.getElementsByTagName('div');
        while (elementToErase.length > 0) {
            document.body.removeChild(elementToErase[0]);
        }
    }
    function onAddDivButtonClick() {

        //Declare some constants
        var maxDivsToCreate = 3;
        var minWidth = 20;
        var minHeight = 20;
        var maxWidth = 100;
        var maxHeight = 100;
        var maxBorder = 20;

        var docFragment = document.createDocumentFragment();

        function getTopPosition() {
            var maxTop = screen.height - 100;
            return Math.floor(Math.random() * maxTop + 1) + 'px';
        }

        function getRightPosition() {
            var maxRight = screen.width - 100;
            return Math.floor(Math.random() * maxRight + 1) + 'px';
        }

        function getBorder() {
            return Math.floor(Math.random() * maxBorder + 1) + 'px';
        }

        function getWidth() {
            return Math.floor(Math.random() * maxWidth + minWidth) + 'px';
        }

        function getHeight() {
            return Math.floor(Math.random() * maxHeight + minHeight) + 'px';
        }

        function getRandomColor() {
            var red = (Math.random() * 256) | 0;
            var green = (Math.random() * 256) | 0;
            var blue = (Math.random() * 256) | 0;

            return "rgb(" + red + "," + green + "," + blue + ")";
        }

        function getBorderRadius() {
            return Math.floor(Math.random() * 25 + 1) + 'px';
        }

        function makeDivShiny(div) {
            div.innerHTML = 'div';
            div.style.color = getRandomColor();
            div.style.position = 'absolute';
            div.style.top = getTopPosition();
            div.style.right = getRightPosition();
            div.style.border = getBorder();
            div.style.width = getWidth();
            div.style.height = getHeight();
            div.style.borderRadius = getBorderRadius();
            div.style.borderStyle = 'solid';
            div.style.borderColor = getRandomColor();
            div.style.backgroundColor = getRandomColor();
            div.style.fontWeight = 'bold';
        }

        for (var i = 0; i < maxDivsToCreate; i++) {

            var div = document.createElement('div');
            makeDivShiny(div);
            docFragment.appendChild(div);
        }
        document.body.appendChild(docFragment);
    }

    var firstA = document.getElementsByTagName('a')[0];
    firstA.addEventListener('click', onAddDivButtonClick, false);

    var firstA = document.getElementsByTagName('a')[1];
    firstA.addEventListener('click', onClearDivsButtonClick, false);

}())