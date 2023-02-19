let obj = {
    fname: "tekle",
    lname: "mamporia",
    age: "15"
}
let obj1 = {
    fname: "tako",
    lname: "ramegvari",
    age: "13"
}
let obj2 = {
    fname: "sandra",
    lname: "gvari",
    age: "20"
}
var allObj = [obj, obj1, obj2];
var minNum = Number.MAX_VALUE;

var smallestage = "";
for(var i of allObj){
    if(i.age < minNum){
        minNum = i.age
        smallestage = i;
    }
}
console.log(smallestage.fname, smallestage.lname);

// for(var i of allObj){
//     if(i.age < minNum){
//         minNum = i.age
//     }
// }
// for(var i of allObj){
//     if(i.age == minNum){
//         console.log(i)
//     }
// }