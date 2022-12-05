

var x = document.getElementById("navigation")

 function adicionarClass(){

    if(x.className === "navigation"){

        x.className += " menujs"
        document.getElementById("treeline-icon").innerHTML = "&Cross;"
    }
    else{
        x.className = "navigation"
        document.getElementById("treeline-icon").innerHTML = "&#9776;"
    }

    

 }
