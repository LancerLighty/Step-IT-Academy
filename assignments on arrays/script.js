var arr = [1,802,3,76764,5,-100];
// for(var i of arr) {
//     if(i%2== 0) {
//         console.log(i*i, i);
//     } else {
//         console.log(i*i*i, i);
//     }
// }
// for(var i of arr){
//     if((99 < i && i <= 999) || (9999 < i && i <= 99999) || (-99 > i && i >= -999) || (-9999 > i && i >= -99999)){
//         console.log(i);
//     }
// }
var luwi = 0;
var kenti = 0;
for(var i of arr) {
    if(i%2== 0) {
        luwi++; //luwi = luwi + 1; luwi +=1
    } else {
        kenti++;
    }
}
console.log("kenti:" + kenti);
console.log("luwi:" + luwi);