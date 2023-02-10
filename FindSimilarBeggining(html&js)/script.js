var words = ["tekle", "kompiuteri", "sityva", "zita", "teko"];
var searchdoc = document.querySelector('.inp');
var text = document.querySelector('.text');

function search1(){
    var text1 = "";
    for(var i of words){
        var boolean = true;
        // rgrdzeli gza
        for(var y = 0; y< searchdoc.value.length; y++){
            if(i[y] != searchdoc.value[y]){
                boolean = false;
            }
        }
        if(boolean){
            text1 = text1 + i + ", "
        }
        // mokle gza
        // if(i.startsWith(searchdoc.value)){
        //     text1 = text1 + i + ", "
        // }
    }
    text.innerText = text1;
}