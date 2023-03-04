var h2 = document.querySelector("h2")
var getInfo= {
    email: "",
    password: ""
}
getInfo = JSON.parse(localStorage.getItem("UserInfo"))
var email = document.querySelector(".email")
var pass = document.querySelector(".pass")
var form = document.querySelector("form")
var inc = document.querySelector("#inc")
form.addEventListener("submit", function(e){
    if(email.value != getInfo.email || pass.value != getInfo.password){
        e.preventDefault()
        inc.innerText = "shemoyvanili emaili an paroli arasworia"
        return false;
    } else {
        getInfo.password = pass.value
        console.log(getInfo)
        localStorage.setItem("UserInfo", JSON.stringify(getInfo))
    }
})