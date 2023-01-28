// var strings = ["idk", "test", "see", "idk", "javaaa"];
// var word = String(prompt());
// var count = 0;
// for(var i of strings){
//     if(i === word){
//         count++;
//     }
// }
// if(count === 0){
//     console.log("same word wasn't found");
// } else {
//     console.log("same word was found. count: " + count);
// }
// var vowel = ["a", "e", "i", "o", "u"];
// for(var i of strings){
//     for(var x of vowel){
//         if(i.charAt(0) === x){ // if(i.charAt(0) === "a") || (i.charAt(0) == "e") ...)
//             console.log(i);
//         }
//     }
// }

var strings = ["idk", "test", "see", "idk", "javaaa"];
var vowel = ["a", "e", "i", "o", "u"];
for(var i of strings){ //sityvebi
    var countvow = 0;
    var countcons = 0;
    for(var y of i){ // sityvebis aso
        var boolean = true;
        for(var x of vowel){ //xmovnebi
            if(y === x){
                boolean = false;
                countvow++;
            }
        }
        if(boolean){
            countcons++;
        }
    }
    if(countvow > countcons){
        console.log(i);
    }
}


for(var i of strings){ //sityvebi
    var countvow = 0;
    var countcons = 0;
    for(var y of i){ // sityvebis aso
        for(var x of vowel){ //xmovnebi
            if(y === x){
                countvow++;
            }
        }
    }
    countcons = i.length - countvow;
    if(countvow > countcons){
        console.log(i);
    }
}
