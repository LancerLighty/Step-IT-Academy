var words = ["tekle", "kompiuteri", "sityva", "zita", "teko"];
var test = String(prompt());
for(var i of words){
    var boolean = true;
    for(var y = 0; y< test.length; y++){
        if(i.charAt(y) != test.charAt(y)){
            boolean = false;
        }
    }
    if(boolean){
        console.log(i);
    }
}
