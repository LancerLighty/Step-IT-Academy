var arr = [105, 4, 73, 92, 3];
var pirveli = 0;
var meore = 0;
for(var i = 0; i < arr.length/2; i++){
    if(arr.length%2==0){
        pirveli+=arr[i]; 
    } else if(i < arr.length/2 - 0.5){
        pirveli+=arr[i];
    }
}
for(var i = arr.length/2; i < arr.length; i++){
    if(arr.length%2==0){
        meore+=arr[i];
    } else if(i < (arr.length - 0.5)){
        meore+=arr[i + 0.5];
    } 
}
console.log(pirveli + " " + meore);
















// for(var i = 0; i < arr.length/2; i++){
//     if(arr.length%2==0){
//         pirveli+=arr[i]; 
//     } else if(i < arr.length/2 - 0.5){
//         pirveli+=arr[i];
//     }
// }
// for(var i = arr.length/2; i < arr.length; i++){
//     if(arr.length%2==0){
//         meore+=arr[i]; 
//         console.log(i, arr[i])
//     } else if(i < (arr.length - 0.5)){
//         console.log(i + 0.5, arr[i + 0.5])
//         meore+=arr[i + 0.5];
//     } 
// }










// for(var i = 0; i)
//-------------pirveli da meore naxevris jami--------------
// ------------ert for loopshi------------
// for(var i = 0; i < arr.length+1; i++){
//     if(i < arr.length/2 - 1){
//         pirveli+=arr[i];
//     } else if(i < (arr.length - 1.5)){
//         meore+=arr[i + 1]
//         console.log(i,meore);
//     }
// }
// ------------or for loopshi------------
// for(var i = 0; i < arr.length/2 - 1; i++) {
//     pirveli+=arr[i];
// }
// console.log("pirveli: " + pirveli);
// for(var i = arr.length/2 + 0.5; i < arr.length - 0.5; i++) {
//     meore+=arr[i]
//     console.log(arr[i], i,meore);
// }