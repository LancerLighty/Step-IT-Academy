// var num1 = Number(prompt())
// var num2 = Number(prompt())
// var action = prompt()
// numbers(num1, num2, action)
function numbers(num1, num2, action, callback){
    var result;
    if(action == "+"){
        result = num1 + num2
    } else if (action == "-"){
        result = num1 - num2
    } else if (action == "*"){
        result = num1 * num2
    } else if (action == "/"){
        result = num1 / num2
    } else {
        result = "action must be +,-,* or /"
    }
    callback(result)
}
var arr = [10, 4]
array.forEach(element => {
    
});
function printResult(result){
    console.log("answer is: " + result)
}
numbers(12,4,"+", printResult)
numbers(10,4,"-", printResult)
numbers(11,4,"*", printResult)
numbers(1,56,"/", printResult)
// function caltulator(name){
//     console.log("hello " + name)
// }
// caltulator("tekle")
// caltulator("gocha")
// caltulator("temo")