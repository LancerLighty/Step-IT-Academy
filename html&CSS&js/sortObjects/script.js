let obj1 = {
    fname: "tekle",
    lname: "mamporia",
    age: 56
}
let obj2 = {
    fname: "firstName",
    lname: "lastName",
    age: 7
}
let obj3 = {
    fname: "sandro",
    lname: "mamporia",
    age: 6
}
var arr = [obj1,obj2,obj3];
let save = {
    fname: "",
    lname: "",
    age: 0
}
// for(var x = 0; x < arr.length - 1; x++){
//     var swap = false;
//     for(var i = 0; i < arr.length - 1; i++){
//         if(arr[i].age > arr[(i + 1)].age){
//             save = arr[i];
//             arr[i] = arr[i + 1];
//             arr[i + 1] = save;
//             swap = true;
//         }
//     }
//     if(swap == false){
//         break;
//     }
// }
// console.log(...arr)
arr.sort(function(a,b){
    return a.age - b.age;
})
console.log(...arr)