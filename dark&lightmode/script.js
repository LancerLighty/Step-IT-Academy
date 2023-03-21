var light = document.querySelector(".light")
var dark = document.querySelector(".dark")
var body = document.querySelector("body")
var mode = localStorage.getItem("mode") || "white"
if(mode == "white"){
    body.style.backgroundColor = "white"
    body.style.color = "black"
} else {
    body.style.backgroundColor = "black"
    body.style.color = "white"
}
light.addEventListener("click",function(){
    body.style.backgroundColor = "white"
    body.style.color = "black"
    localStorage.setItem("mode", "white")
})
dark.addEventListener("click",function(){
    body.style.backgroundColor = "black"
    body.style.color = "white"
    localStorage.setItem("mode", "black")
})