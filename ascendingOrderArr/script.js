// var x1 = "beka";
// var x2 = "test";
// var savedx1 = x1; // savedx1 = "beka"
// x1 = x2; // x1 = "test"
// x2 = savedx1; // x2 = "beka"
// console.log(x1, x2);
var arr = [2, 5, 10, 3, 5, 50, 4];
var save = 0;
for(var x = 0; x < arr.length - 1; x++){
    var swap = false;
    for(var i = 0; i < arr.length - 1; i++){
        if(arr[i] > arr[i + 1]){
            save = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = save;
            swap = true;
        }
    }
    if(swap == false){
        break;
    }
    console.log(arr)
}

console.log(...arr)
