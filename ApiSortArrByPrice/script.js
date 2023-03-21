fetch("https://data.binance.com/api/v3/ticker/24hr")
.then(x=>{
    // console.log(x.json())
    return x.json();
})
.then(arr=>{
    var sortedArray = arr.sort((a, b) => (a.highPrice < b.highPrice ? 1 : -1));
    // console.log(sortedArray)
    for(var i = 0; i < 10; i++){
        console.log(sortedArray[i])
    }
    // for(var i of arr){
    //     if(i.highPrice > findhighPrice){
    //         findhighPrice = i.highPrice;
    //         findName = i.symbol
    //     }
    // }
    // console.log(findName + " " + findhighPrice)
})