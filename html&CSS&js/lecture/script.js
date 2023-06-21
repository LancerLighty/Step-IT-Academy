// function calculate(num1, num2, operation, callback) {
//     var result; //15
//     if (operation === "add") {
//       result = num1 + num2;
//     } else if (operation === "subtract") {
//       result = num1 - num2;
//     }
//     callback(result);
// }
  
// function displayResult(result) {
//     console.log("The result is:", result);
// }
// calculate(10, 0, "add", displayResult);
// function fullName(fname, lname, age, callback) {
//     var result = fname + " " + lname
//     console.log(age)
//     while(age < 0){
//         age = Number(prompt("Reenter your age:(it should be higher then 0)"))
//         console.log("test")
//     }
//     callback(result, age)
// }
  
// function hello(result, age) {
//     console.log("hello ", result);
//     console.log("your age is: " + age)
// }
// var fname = String(prompt("Enter your fname:"))
// var lname = String(prompt("Enter your lname:"))
// var age = Number(prompt("Enter your age:"))
// fullName(fname, lname, age, hello);

var number1 = 5;
var number2 = 10;
// getResult(number2, number1)
// var result = num1 + num2;
// console.log(resut)
function getResult(num1, num2){
    var result = num1 - num2 //x = 10, y = 5
    console.log(result)
}
function calculator(num1, num2, action){
    var wrongResult = num1 + action + num2
    var rightResult;
    if(action == "+"){
        rightResult = num1 + num2
    } else if (action == "-"){
        rightResult = num1 - num2 
    } else if (action == "*"){
        rightResult = num1 * num2
    } else if (action == "/"){
        rightResult = num1 / num2
    }
    console.log(num1 + action + num2 + "=" + rightResult)
}
calculator(prompt(), prompt(), prompt())
calculator(prompt(), prompt(), prompt())
calculator(prompt(), prompt(), prompt())