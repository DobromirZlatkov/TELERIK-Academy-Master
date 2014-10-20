(function () {
    var generateBtn;
    //var input = document.getElementById("div-numb-selector"),
    //    numberOfDivs = input | 5,
    //    random = new random(),
    //    generatebtn = document.getElementById("generate-boxes-btn");

    
    function generateNumberOfDivs() {
        var contentDIv = document.getElementById('content'),
            count,
            i,
            div,
            strong;

        contentDIv.innerHTML = '';

        count = (document.getElementById("div-numb-selector").value || 5) | 0;

        for (var i = 0; i < count; i++) {
            div = document.createElement("div");
            strong = document.createElement("strong");
            div.style.backgroundColor = "rgb(" + (Math.floor(Math.random() * 255) + 0).toString() + "," + (Math.floor(Math.random() * 255) + 0).toString() + "," + (Math.floor(Math.random() * 255) + 0).toString() + ")";
            div.style.border = (Math.floor(Math.random() * 20) + 1).toString() + "px solid " + "rgb(" + (Math.floor(Math.random() * 255) + 0).toString() + "," + (Math.floor(Math.random() * 255) + 0).toString() + "," + (Math.floor(Math.random() * 255) + 0).toString() + ")";
            div.style.borderRadius = (Math.floor(Math.random() * 50) + 1).toString() + "px";
            div.style.width = (Math.floor(Math.random() * 100) + 20).toString() + "px" ;
            div.style.height = (Math.floor(Math.random() * 100) + 20).toString() + "px";
            div.style.position = "absolute";
            div.style.marginTop = (Math.floor(Math.random() * 1000) + 1).toString() + "px";
            div.style.marginLeft = (Math.floor(Math.random() * 1000) + 1).toString() + "px";
            div.style.textAlign = "center";
            
            strong.textContent = "div";
            strong.style.color = "rgb(" + (Math.floor(Math.random() * 255) + 0).toString() + "," + (Math.floor(Math.random() * 255) + 0).toString() + "," + (Math.floor(Math.random() * 255) + 0).toString() + ")";
            div.appendChild(strong);
            contentDIv.appendChild(div);
        }

    }

    generateBtn = document.getElementById('generate-boxes-btn');
    generateBtn.addEventListener('click', generateNumberOfDivs);
}());