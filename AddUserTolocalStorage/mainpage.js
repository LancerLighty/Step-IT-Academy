var h2 = document.querySelector("h2")
var getInfo= {
    email: "",
    password: ""
}
getInfo = JSON.parse(localStorage.getItem("UserInfo"))
h2.innerText = getInfo.email;
var pass = document.querySelector(".pass")
var repeatPass = document.querySelector(".repeatPass")
var form = document.querySelector("form")
var inc = document.querySelector("#inc")
form.addEventListener("submit", function(e){
    if(pass.value != repeatPass.value){
        e.preventDefault()
        inc.innerText = "parolebi ar emtxveva"
        return false;
    } else {
        getInfo.password = pass.value
        console.log(getInfo)
        localStorage.setItem("UserInfo", JSON.stringify(getInfo))
    }
})