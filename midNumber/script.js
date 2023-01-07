firstNum = Number(prompt("enter first Number:"));
secondNum = Number(prompt("enter second Number:"));
thirdNum = Number(prompt("enter third Number:"));
console.log(firstNum + ", " + secondNum + ", " + thirdNum);
if((firstNum < secondNum && secondNum < thirdNum) || (firstNum > secondNum && secondNum > thirdNum)){
    console.log("second number(" +  secondNum + ") is middle Number.");
} else if((secondNum < firstNum && firstNum < thirdNum) || (secondNum > firstNum && firstNum > thirdNum)) {
    console.log("first number(" +  firstNum + ") is middle Number.");
} else if((secondNum < thirdNum && thirdNum < firstNum) || (secondNum > thirdNum && thirdNum > firstNum)){
    console.log("third number(" +  thirdNum + ") is middle Number.");
} else {
    console.log("middle number wasn't found.");
}