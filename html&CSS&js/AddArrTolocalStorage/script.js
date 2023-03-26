var inp = document.querySelector("input")
var button = document.querySelector("button")
button.addEventListener("click", function(){
    var arr = JSON.parse(localStorage.getItem("text")) || []
    // if(JSON.parse(localStorage.getItem("text")) != null){
    //     arr = JSON.parse(localStorage.getItem("text"))
    // }
    arr.push(inp.value)
    localStorage.setItem("text", JSON.stringify(arr))
})