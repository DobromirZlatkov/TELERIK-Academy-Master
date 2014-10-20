var div = document.createElement('div'),
    i,
    currentDiv;

var domModule = (function () {
    'use strict';
    var self,
        buffer = [];
    function appendChild(domElement, parentSelector) {
        var parent = document.querySelector(parentSelector);

        parent.appendChild(domElement);
    }

    function removeChild(parent, child) {
        var parentNode = document.querySelector(parent),
            childToRemove = parentNode.querySelector(child);

        parentNode.removeChild(childToRemove);
    }

    function addHandler(selector, event, func) {
        var selectedElement = document.querySelectorAll(selector),
            i;
        for (i = 0; i < selectedElement.length; i += 1) {
            if (selectedElement[i].addEventListener) {
                selectedElement[i].addEventListener(event, func, false);
            } else {
                selectedElement[i].attachEvent('on' + event, func);
            }
        }
    }

    function appendToBuffer(selector, element) {
        if (buffer[selector]) {
            buffer[selector].push(element);
            if (buffer[selector].length >= 100) {
                var currentElement = document.querySelector(selector),
                    i;
                for (i = 0; i < buffer[selector].length; i += 1) {
                    currentElement.appendChild(buffer[selector][i]);
                }
                buffer[selector] = [];
            }
        } else {
            buffer[selector] = [];
            buffer[selector].push(element);
        }
    }

    self = {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer
    };

    return self;
}());


//append div to wrapper
domModule.appendChild(div, 'div');

//removes li:first-child from ul
domModule.removeChild('ul', 'li:first-child');

//add handle to each a element with class button
domModule.addHandler('a .button', 'click', function () {
    'use strict';

    alert('Clicked');
});

for (i = 0; i <= 100; i += 1) {
    currentDiv = div.cloneNode(true);
    currentDiv.innerHTML = i;
    domModule.appendToBuffer('#wrapper', currentDiv);
}

