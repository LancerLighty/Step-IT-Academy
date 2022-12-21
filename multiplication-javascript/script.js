// var firstnum = Number(prompt());
// var secondnum = Number(prompt());
// console.log(firstnum + ' + ' + secondnum + ' = ' + (firstnum+secondnum));
// console.log(firstnum + ' - ' + secondnum + ' = ' + (firstnum-secondnum));
// console.log(firstnum + ' * ' + secondnum, ' = ' + firstnum*secondnum);
// console.log(firstnum + ' / ' + secondnum, ' = ' + firstnum/secondnum)
function add(a,b){
    console.log(a + ' + ' + b + ' = ' + (a+b));
}
function sub(a,b){
    console.log(a + ' - ' + b + ' = ' + (a-b));
}
function mul(a,b){
    console.log(a + ' * ' + b + ' = ' + a*b);
}
function div(a,b){
    console.log(a + ' / ' + b + ' = ' + a/b);
}
function everything(a,b){
    add(a,b);
    sub(a,b);
    mul(a,b);
    div(a,b);
}
var firstnum = Number(prompt());
var secondnum = Number(prompt());
console.log(firstnum, secondnum);
everything(firstnum,  secondnum);