var ranNum = parseInt(Math.random() * 20);
var inpNum = document.querySelector(".inp");
var disableCheck = document.querySelector('#check');
var text = document.querySelector('.text');
var close = document.querySelector('.close');
var guesscount = document.querySelector('.guesscount');
var guessNumCount = 0;
guesscount.innerText = guessNumCount;
console.log(ranNum);
function checkNum(){
    guessNumCount++;
    guesscount.innerText = guessNumCount;
    if(ranNum == inpNum.value){
        disableCheck.disabled = true;
        text.innerText = "sheyvanili ricxvi emtxveva";
        text.style.color = "green";
    } else {
        // var boolean = false;
        // for(var i = ranNum - 3; i <= ranNum + 3; i++){
        //     if(i == ranNum){
        //         boolean = true;
        //     }
        // }
        // if(boolean){
        //     close.innerText = "sheyvanili ricxvi axlosaa randomul cifrtan"
        // } else {
        //     close.innerText = "sheyvanili ricxvi shorsaa randomul cifrtan"
        // }
        if(Math.abs( inpNum.value - ranNum ) <= 3) {
            close.innerText = "sheyvanili ricxvi axlosaa randomul cifrtan"
        } else {
            close.innerText = "sheyvanili ricxvi shorsaa randomul cifrtan"
        }
        text.innerText = "sheyvanili ricxvi ar emtxveva";
        text.style.color = "red";
        inpNum.value = "";
    }
}
function restart(){
    ranNum = parseInt(Math.random() * 20);
    guessNumCount = 0;
    guesscount.innerText = guessNumCount;
    inpNum.value = " ";
    disableCheck.disabled = false;
    text.innerText = "";
}