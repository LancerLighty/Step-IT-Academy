var p = document.querySelector(".paragraph");
var head = document.querySelector("h2");
var select = document.querySelector("select");
var lStorage = localStorage.getItem("language") || "english"
var geo = {
    head: "რაღაც სათაური",
    p: "ვითომ ამ რაღაცაზე აღწერაა ;)"
}
var eng = {
    head: "some title",
    p: "As if there is a description of this somthing ;)"
}
var rus = {
    head: "какое-то название",
    p: "Как будто здесь есть описание этого чего-то ;)"
}
if(lStorage == "english"){
    head.innerText = eng["head"];
    p.innerText = eng["p"];
} else if(lStorage == "georgian"){
    head.innerText = geo["head"];
    p.innerText = geo["p"];
} else if(lStorage == "russian"){
    head.innerText = rus["head"];
    p.innerText = rus["p"];
}
select.addEventListener("change", function(){
    console.log(select.value);
    if(select.value == "english"){
        head.innerText = eng["head"];
        p.innerText = eng["p"];
        localStorage.setItem("language", "english")
    } else if(select.value == "georgian"){
        head.innerText = geo["head"];
        p.innerText = geo["p"];
        localStorage.setItem("language", "georgian")
    } else if(select.value == "russian"){
        head.innerText = rus["head"];
        p.innerText = rus["p"];
        localStorage.setItem("language", "russian")
    }
})