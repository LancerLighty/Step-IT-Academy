var arr = [105, 4, 73, 92, 40];
var pirveli = 0;
var meore = 0;
//-------------pirveli da meore naxevris jami--------------
// ------------ert for loopshi------------
for(var i = 0; i < arr.length+1; i++){
    if(i < arr.length/2 - 1){
        pirveli+=arr[i];
    } else if(i < (arr.length - 1.5)){
        meore+=arr[i + 1]
        console.log(i,meore);
    }
}
// ------------or for loopshi------------
// for(var i = 0; i < arr.length/2 - 1; i++) {
//     pirveli+=arr[i];
// }
// console.log("pirveli: " + pirveli);
// for(var i = arr.length/2 + 0.5; i < arr.length - 0.5; i++) {
//     meore+=arr[i]
//     console.log(arr[i], i,meore);
// }
console.log(pirveli + " " + meore)
//-------------kenti da luwi indeqsebis jami--------------
//pirveli xerxi
// for(var i in arr){
//     if(i%2==0){
//         luwi+=arr[i];
//     } else {
//         kenti+=arr[i];
//     }
// }
// console.log("kenti:" + kenti + " luwi: " + luwi);
// meorenairad
// for(var i = 0; i < arr.length; i++){
//     if(i%2==0){
//         luwi+=arr[i];
//     } else {
//         kenti+=arr[i];
//     }
// }
//mesamenairad
// var index = 0;
// for(var i of arr){
//     if(index%2==0){
//         luwi+=i;
//     } else {
//         kenti+=i;
//     }
//     index++; index+=1;
// }

// --------------luwi ufro metia tu kenti--------------------

// for(var i of arr){
//     if(i%2==0){
//         luwi++;
//     } else{
//         kenti++;
//     }
// }
// if(kenti > luwi){
//     console.log("kenti ufro metia");
// } else if(kenti < luwi){
//     console.log("luwi ufro metia");
// } else {
//     console.log("tolia");
// }