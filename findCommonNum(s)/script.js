// function idk(word1,word2){
//     var vowel = ["a", "e", "i", "o", "u"];

//     for(var i of word1){
//         var countvow1 = 0;
//         for(var y of i){
//             for(var x of vowel){
//                 if(y === x){
//                     countvow++;
//                 }
//             }
//         }
//     }
//     for(var i of word2){ //sityvebi
//         var countvow2 = 0;
//         for(var y of i){ // sityvebis aso
//             for(var x of vowel){ //xmovnebi
//                 if(y === x){
//                     countvow2++;
//                 }
//             }
//         }
//     }
//     if(countvow1 > countvow2){
//         return word1
//     } else if(countvow1 < countvow2){
//         return word2
//     } else{
//         return word1 + " " + word2
//     }
// }
var arr = [45,1,3,5,2,3]
array(arr)
function array(arr){
    var objcount = {}
    for(var i of arr){
        if(objcount[i]){ // i ari ricxvi
            objcount[i]++;
        } else {
            objcount[i] = 1;
        }
    }
    console.log(objcount)
    var repeat = 0;
    var number = 0;
    for(var i in objcount){
        if(objcount[i] > repeat){
            repeat = objcount[i];
            number = i;
        }
    }
    console.log(repeat + " " + number)
    // var counting = {}
    // for(var i in arr){
    //     var numbers = arr[i]
    //     if(counting[numbers]){
    //         counting[numbers]++;
    //     } else {
    //         counting[numbers] = 1;
    //     }
    // }
    // console.log(counting)
    // var maxrepeat = 0
    // var maxnumber = 0
    // for(var numbers in counting){//numbers is ricxvebia rac ewera masivshi da ara indexi imitoro 37 xazze davarqvi numbers
    //     if(counting[numbers] > maxrepeat){ // da tan objectia da ara masivi))
    //         maxnumber = numbers;
    //         maxrepeat = counting[numbers];
    //     }
    // }
    // var arrmore =[];
    // var obj = {
    //     maxnumber: maxnumber,
    //     maxrepeat: maxrepeat
    // }
    // arrmore.push(obj)
    // for(var numbers in counting){
    //     if(counting[numbers] == maxrepeat && numbers != maxnumber){
    //         var obj = {
    //             maxnumber: numbers,
    //             maxrepeat: counting[numbers]
    //         }
    //         arrmore.push(obj)
    //     }
    // }
    // console.log(...arrmore)
 }
//  var obj ={
//     fname: "tekle",
//     lname: "mamporia"
//  }
//  console.log(obj["fname"]);
// var obj = {
//     5: 3,
//     6: 4
// }
// console.log(obj[6])