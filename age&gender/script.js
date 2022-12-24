var age = Number(prompt("age:"));
var gender = String(prompt("gender: (male/female)"));
gender = gender.toLowerCase();

//-------------------- with if -----------------------------
console.log(" -------------------- with if -----------------------------");
if((!(Number.isInteger(age))) || (age < 0 )){
    console.log("you should enter age using positive numbers");
} else if(gender != "female" && gender != "male"){
    console.log("gender is incorrect : (female/male)");
} else if(age < 18){
    console.log("age: teenager");
} else if(age < 60 ){
    console.log("age: adult");
} else if(age < 65 && gender == "male") {
    console.log("age: adult");
} else if(age >= 60){
    console.log("age: pensioner");
}

//------------------------  with while & if  ---------------------
console.log(" ---------------------with while and if  ---------------------");
while((!(Number.isInteger(age))) || (age < 0 )){
    age = Number(prompt("enter age with numbers(not with negative or letters)"));
}
while(gender != "female" && gender != "male"){
    gender = String(prompt("gender is incorrect, please reenter: (female/male)"));
}
if(age < 18){
    console.log("age: teenager");
} else if(age < 60 ){
    console.log("age: adult");
} else if(age < 65 && gender == "male") {
    console.log("age: adult");
} else if(age >= 60){
    console.log("age: pensioner");
}
