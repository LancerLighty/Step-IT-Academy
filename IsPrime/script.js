var number = Number(prompt());
var isPrime = true; //boolean: true/false
if (number == 1){
    console.log("arc martivia da arc shedgenili");
} else if(number > 1){
    for(var i = 2; i <= number/2; i++){ //2, 3, 4, ....., number/2
        if(number % i == 0){
            isPrime = false;
            break;
        }
    }
    if(isPrime){ // isPrime == true
        console.log("ricxvi martivia");
    } else {
        console.log("ricxvi shedgenilia");
    }
}