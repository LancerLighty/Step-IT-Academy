// var x = prompt(); 
// var arr = ["string", "word", "name", "surname"];
// for(var word of arr){
//     var xclone = x;
//     for(var i of word){
//         for(var j of x){
//             if(i == j){
//                 xclone.replace(j,'');
//                 console.log(xclone, word)
//             }
//         }
//     }
//     if(xclone == ""){
//         console.log(word);
//     }
// }
var kenti = document.querySelector(".kenti");
var luwi = document.querySelector(".luwi");
var kentinum = "";
var luwinum = "";
var numbers = [1,2,3,4,5,6,7,8,9];
for(var num of numbers){
    if(num%2==0){
        luwinum += num +", ";
    } else {
        kentinum += num +", ";
    }
}
luwi.innerText = luwinum;
kenti.innerText = kentinum;