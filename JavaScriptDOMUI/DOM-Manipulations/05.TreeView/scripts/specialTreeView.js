(function () {
    function TreeView(selector) {
        this.parent = document.querySelector(selector);               
        this.childElements = [];
        this.itemList = document.createElement('ul');
    }
    TreeView.prototype = {
        add: function (name) {
            var child = new Item(name);
            this.childElements.push(child);
            return child;
        },
        render: function () {
           
            //remove all from the parent

            //while (this.parent.firstChild) {
            //    this.parent.removeChild(this.parent.firstChild)
            //}
            //this.itemList = document.createElement('ul');

            //but this is a better way
            while (this.itemList.firstChild) {
                this.itemList.removeChild(this.itemList.firstChild)
            }
            
            var len = this.childElements.length;
            for (var i = 0; i < len; i++) {

                var domItem = this.childElements[i].render();
                this.itemList.appendChild(domItem);
                
            }
            this.parent.appendChild(this.itemList);
            return this;
        }
    }

    function Item(name) {
        this.name = name;
        this.childElements = [];
    }
    Item.prototype = {
        add: function (name) {
            var newItem = new Item(name);
            this.childElements.push(newItem);
            return newItem;
        },
        render: function () {
            var li = document.createElement('li');
            li.innerHTML = "<a href='#'>" + this.name + "</a>";

            if (this.childElements.length > 0) {
                var subUl = document.createElement('ul');
                var len = this.childElements.length;
                for (var i = 0; i < len; i++) {
                    var domItemLi = this.childElements[i].render();
                    subUl.appendChild(domItemLi);
                }
                li.appendChild(subUl);
            }
            return li;
        }
    }

    var treeView = new TreeView('#container');

    var webItem = treeView.add("Web");
    var aspnetItem = webItem.add("ASP.NET");
        aspnetItem.add("ASP.NET MVC");
        aspnetItem.add("ASP.NET MVC");
        var a = aspnetItem.add('inner');
        var b = a.add('innnnner');
        b.add('TELERIK ACADEMY');
    var htmlItem = webItem.add("HTML");
        htmlItem.add("v4.1");
        htmlItem.add("v5");

    var mobileItem = treeView.add("Mobile");
        mobileItem.add("Android");
        mobileItem.add("Windows Phone");
        mobileItem.add("iOS");

    var desktopItem = treeView.add("Dekstop");
        desktopItem.add("XAML");
        desktopItem.add("Windows Forms");
        var z = desktopItem.add('World');
    
        treeView.render();

        treeView.parent.addEventListener('click', function (ev) {
            if (!ev) {
                ev = window.event;
            }

            //ev.stopPropagation();
            //ev.preventDefault();

            var clickedItem = ev.target;
            if (!clickedItem instanceof HTMLAnchorElement) {
                return;
            }

            var innerUl = ev.target.parentNode.getElementsByTagName('ul')[0];
            if (!innerUl) {
                return;
            }   
            if (innerUl.style.display !== 'none') {
                innerUl.style.display = 'none';
            }
            else {
                innerUl.style.display = '';
            }
        }, false)        
}());