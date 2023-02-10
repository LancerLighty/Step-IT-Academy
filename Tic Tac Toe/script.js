var tds = document.querySelectorAll('.td');
var winCombinations = [[0,1,2], [3,4,5], [6,7,8], [0,3,6], [1,4,7], [2,5,8], [0,4,8], [2,4,6]]
var winMessage = document.querySelector('.winMessage');
var playerX = true;
for(let i of tds){
    i.addEventListener("click", function(){
        if(playerX){
            i.innerText = "X"
            i.style.color = "rgb(252, 55, 84)"
            playerX = false;
            i.style.pointerEvents ="none"
        } else {
            i.innerText = "O"
            i.style.color = "rgb(57, 119, 252)"
            playerX = true;
            i.style.pointerEvents ="none"
        }
        checkwinner(tds);
    })
}
function checkwinner(tds){
    // if(tds[0].innerText == tds[1].innerText && tds[0].innerText == tds[2].innerText && tds[0].innerText != ""){
    //     console.log("winner")
    // }
    for(var x of winCombinations){
        var booleanX = true;
        var booleanO = true;
        for(var y of x){
                if(tds[y].innerText != "X"){
                    booleanX = false;
                }
                if(tds[y].innerText != "O"){
                    booleanO = false;
                }
        }
        if(booleanX || booleanO){
            winMessage.innerText = "game Won!";
            for(var point of tds){
                point.style.pointerEvents ="none";
            }
        }
    }
}
var retrybutton = Document.querySelector('.retry');
function retry(){
    console.log(00)
    for(let i of tds){
        i.innerText = "";
        i.style.pointerEvents ="all";
    }
    winMessage.innerText = "";
}