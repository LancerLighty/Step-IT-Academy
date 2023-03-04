var email = document.querySelector(".email")
var pass = document.querySelector(".pass")
var repeatPass = document.querySelector(".repeatPass")
var errorP = document.querySelector("#errorP")
var form = document.querySelector("form")
form.addEventListener("submit", function(e){
    if(pass.value != repeatPass.value){
        e.preventDefault()
        errorP.innerText = "parolebi ar emtxveva"
        return false;
    } else {
        let user = {
            email: email.value,
            password: pass.value
        }
        localStorage.setItem("UserInfo", JSON.stringify(user))
    }
    // var arr = []
    // if(JSON.parse(localStorage.getItem("text")) != null){
    //     arr = JSON.parse(localStorage.getItem("text"))
    // }
    // arr.push(inp.value)
    // localStorage.setItem("text", JSON.stringify(arr))
})