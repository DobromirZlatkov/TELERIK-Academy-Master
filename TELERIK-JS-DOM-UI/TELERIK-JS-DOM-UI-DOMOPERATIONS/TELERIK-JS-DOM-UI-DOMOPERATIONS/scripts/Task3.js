(function () {
    var fontColor = document.createElement('input'),
        textArea = document.createElement('textarea'),
        backgroundColor = document.createElement('input');

    fontColor.setAttribute('type', 'color');
    fontColor.setAttribute('id', 'font-color');

    backgroundColor.setAttribute('type', 'color');
    backgroundColor.setAttribute('id', 'background-color');
   
    fontColor.onchange = function () { textArea.style.color = fontColor.value; };
    backgroundColor.onchange = function () {
        textArea.style.backgroundColor = backgroundColor.value;
    }

    function changeColors() {
        textArea.style.color = fontColor.value;
        textArea.style.backgroundColor = backgroundColor.value;
    }

    document.body.appendChild(backgroundColor);
    document.body.appendChild(fontColor);
    document.body.appendChild(textArea);

}());