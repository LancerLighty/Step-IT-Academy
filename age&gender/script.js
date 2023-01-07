// var age = Number(prompt("age:"));
// var gender = String(prompt("gender: (male/female)"));
// gender = gender.toLowerCase();

// //-------------------- with if -----------------------------
// console.log(" -------------------- with if -----------------------------");
// if((!(Number.isInteger(age))) || (age <= 0 )){
//     console.log("you should enter age using positive numbers");
// } else if(gender != "female" && gender != "male"){
//     console.log("gender is incorrect : (female/male)");
// } else if(age < 18){
//     console.log("age: teenager");
// } else if(age < 60 ){
//     console.log("age: adult");
// } else if(age < 65 && gender == "male") {
//     console.log("age: adult");
// } else if(age >= 60){
//     console.log("age: pensioner");
// }

//------------------------  with while & if  ---------------------
// console.log(" ---------------------  with while and if  ---------------------");
// while((!(Number.isInteger(age))) || (age <= 0 )){
//     age = Number(prompt("enter age with numbers(not with negative or letters)"));
// }
// while(gender != "female" && gender != "male"){
//     gender = String(prompt("gender is incorrect, please reenter: (female/male)"));
// }
// if(age < 18){
//     console.log("age: teenager");
// } else if(age < 60 ){
//     console.log("age: adult");
// } else if(age < 65 && gender == "male") {
//     console.log("age: adult");
// } else if(age >= 60){
//     console.log("age: pensioner");
// }
// var firstText = String(prompt());
// var secondText = String(prompt());
// if(firstText == secondText){
//     console.log("orive naweri emtxveva ertmanets");
// } else if(firstText.toLowerCase() == secondText.toLowerCase()){
//     console.log("nawilobriv emtxveva");
// } else{
//     console.log("ar emtxveva");
// }
var arr = [5,7,8,10]
if(arr.length%2==1){
    console.log(arr[(arr.length-1)/2]);
} else {
    console.log(arr[arr.length/2 - 1])
    console.log(arr[arr.length/2])
}