var pr1 = String(prompt());
var pr2 = String(prompt());
var p =document.querySelector(".similar");
if(pr1 == pr2){
    p.innerText = "ori shemotanili sityva identuria";
    p.style.color = "rgb(0, 189, 102)"
} else if(pr1.toLowerCase() == pr2.toLowerCase()){
    p.innerText = "ori shemotanili sityva nawilobriv identuria";
    p.style.color = "blue"
} else {
    p.innerText = "ori shemotanili sityva ar aris identuri";
    p.style.color = "red"
}
