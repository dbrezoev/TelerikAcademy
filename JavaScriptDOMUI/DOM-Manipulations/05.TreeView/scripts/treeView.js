(function () {

    var maxLiCount = 5;
    var minLiCount = 1;
    
    function onButtonClick() {

        clearDom();
        var docFragment = document.createDocumentFragment();
        var ul = constructUlHierarchy();
        docFragment.appendChild(ul);
        var div = document.getElementById('content');
        div.appendChild(docFragment);

        //attach events to all LIs        
        var lis = document.getElementsByTagName('li');
        var length = lis.length;
        for (var i = 0; i < length; i++) {
            lis[i].addEventListener('click', onLiClicked, false);
        }
    }

    function constructUlHierarchy() {

        var ul = document.createElement('ul');

        var lisToCreate = getRandomNumber(minLiCount, maxLiCount);

        for (var i = 0; i < lisToCreate; i++) {

            var li = document.createElement('li');
            li.innerHTML = 'Item ' + i;
            var chance = getRandomNumber(0, 2);
            if (chance === 2) {
                var innerUl = document.createElement('ul');
                var innerLis = getRandomNumber(minLiCount, maxLiCount);
                for (var z = 0; z < innerLis; z++) {
                    var innerLi = document.createElement('li');
                    innerLi.innerHTML = 'Sub Item ' + z;
                    var innerChance = getRandomNumber(0, 2);
                    if (innerChance === 2) {
                        var innerInnerUl = document.createElement('ul');
                        var innerInnerLis = getRandomNumber(minLiCount, maxLiCount);
                        for (var k = 0; k < innerInnerLis; k++) {
                            var innerInnerLi = document.createElement('li');
                            innerInnerLi.innerHTML = 'Inside Inner Li'
                            innerInnerUl.appendChild(innerInnerLi);
                        }
                        innerLi.appendChild(innerInnerUl);
                    }
                    innerUl.appendChild(innerLi);
                }
                li.appendChild(innerUl);
            }
            ul.appendChild(li);
        }

        return ul;
    }

    function getRandomNumber(min, max) {
        var random = Math.floor(Math.random() * (max - min + 1)) + min;
        return random;
    }
    
    function onLiClicked(e) {
        e = e || window.event;
        e.preventDefault();
        e.stopPropagation();
        //handle class attribute
        var allLiS = document.getElementsByTagName('li');
        var liCount = allLiS.length;
        for (var i = 0; i < liCount; i++) {
            allLiS[i].setAttribute('class', '');
        }
        //e.cancelBubble = true;
        if (this == e.target) {
            this.setAttribute('class', 'special');
        }
        
        //e.cancelBubble = true;       
        var innerUl = this.getElementsByTagName('ul')[0];
        if (innerUl == undefined) {
            return;
        }
        if (this === e.target && innerUl.style.display !== 'none') {
            innerUl.style.display = 'none';
        }
        else {
            innerUl.style.display = 'block';
        }
       
    }

    function clearDom() {        
        var div = document.getElementsByTagName('div')[0];
        while (div.firstChild) {
            div.removeChild(div.firstChild);
        }        
    }

    var a = document.getElementById('button');
    a.addEventListener('click', onButtonClick, false);
    
}());