(function () {

    //const
    var minFont = 20;
    var maxFont = 42;

    var tags = ["cms", "javascript", "js", "ASP.NET MVC",
        ".net", ".net", "css", "wordpress", "xaml", "js",
        "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC",
        "wp", "javascript", "js", "cms", "html", "javascript",
        "http", "http", "CMS", ".net", ".net", ".net", ".net", ".net", ".net", ".net"];

    var objects = {};
    var count = 0;
    for (var i = 0; i < tags.length; i++) {
        var currentWord = tags[i].toLowerCase();
        if (!objects[currentWord]) {
            objects[currentWord] = 1;
            count++;
        }
        else {
            objects[currentWord]++;
        }
    }

    var words = [];
    for (var prop in objects) {
        words.push({
            value: prop,
            count: objects[prop]
        });
    }


    var min = Number.MAX_VALUE;
    var max = Number.MIN_VALUE;
    for (var i = 0; i < words.length; i++) {
        if (words[i].count < min) {
            min = words[i].count;
        }
        if (words[i].count > max) {
            max = words[i].count;
        }
    }

    var docFragment = document.createDocumentFragment();
    var tagCloud = document.getElementById('container');
    for (var i in words) {
        var tag = words[i];
        var size = tag.count == min ? minFont : (tag.count / max) * (maxFont - minFont) + minFont;
        var span = document.createElement('span');
        span.innerHTML = tag.value;
        span.style.fontSize = size + 'px';
        span.style.padding = '5px';
        docFragment.appendChild(span);
    }
    tagCloud.appendChild(docFragment);

}());