var obj1 ={
    email: "tekle@gmail.com",
    password: "784"
}
var obj2 ={
    email: "vigac@gmail.com",
    password: "00"
}
var obj3 ={
    email: "test@gmail.com",
    password: "17"
}
var arr = [obj1,obj2,obj3]
var form = document.querySelector("form")
var email = document.querySelector(".email")
var password = document.querySelector(".inpPass")
form.addEventListener("submit", function(e){
    var index = arr.findIndex(i=> i.email==email.value)
    arr[index].password = password.value
    console.log(...arr)
})