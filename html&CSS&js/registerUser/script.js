// var save = document.querySelector(".save")
// var fname = document.querySelector(".flame")
// var lname = document.querySelector(".lname")
// var age = document.querySelector(".age")
// var arr = [];
// save.addEventListener("submit", function(e){
//     e.preventDefault;
//     var obj = {
//         firstname: fname.value,
//         lastrname: lname.value,
//         age: age.value
//     }
//     arr.push(obj)
//     console.log(arr)
// })
var email = document.querySelector(".email")
var pass = document.querySelector(".pass")
var repeat = document.querySelector(".repeatpass")
var save = document.querySelector(".save")
var incorect = document.querySelector(".incorect")
var arr = [];
save.addEventListener("submit", function(){
    if(pass.value != repeat.value){
        incorect.innerText = "parolebi ar emtxveva";
        repeat.style.outline = "1px solid red"
    }else if(pass.value.length <8){
        incorect.innerText = "paroli unda ioyos minimum 8 simbolo";
    }else if(!containsUppercase(pass.value)){
        incorect.innerText = "parols unda hqondes minimum 1 didi aso";
    } else if(checkEmail(email.value, arr)) {
        incorect.innerText = "shemoyvanili emaili ukve daregistrirebulia";
    } else {
        var obj = {
            email: email.value,
            pass: pass.value
        }
        incorect.innerText = "";
        arr.push(obj)
        console.log(...arr)
    }
})
function checkEmail(email, arr){
    for(var i of arr){
        if(i.email == email){
            return true;
        }
    }
    return false;
}

function containsUppercase(a){
    return /[A-Z]/.test(a)
}
// function containsUppercase(a){
//         if(a.includes(A - Z)){
//             console.log("test")
//             return true;
//         }
//     return false
// }

