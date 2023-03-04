var arr = []
getRandomNum(Number(prompt()),Number(prompt()),Number(prompt()));
// var arrLength = document.getSelection(".length");
// var min = document.getSelection(".min");
// var max = document.getSelection(".max");

function getRandomNum(a, min, max){
    while(arr.length != a){
        var rand = Math.floor(Math.random() * (max-min+1)) + min;
        // var rand = parseInt(Math.random()* max)
        // while(rand < min || arr.includes(rand)){
        //     rand = parseInt(Math.random()* max)
        // }
        if(!arr.includes(rand)){
            arr.push(rand);
        }
      
    }
    return console.log(...arr);
}