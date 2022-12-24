// var age = Number(prompt());
// if (age < 0) {
//     console.log("tqveni asaki ver iqneba uaryofiti")
// } else if(age < 18){
//     console.log("teenager");
// } else if(age < 60){
//     console.log("adult");
// } else if(age >= 60) {
//     console.log("pensioner");
// } else{
//     console.log("asaki unda shemoiyvanot cifrebit");
// }
var dayOfWeek = String(prompt());
dayOfWeek = dayOfWeek.toLowerCase();
if(dayOfWeek == "saturday" || dayOfWeek == "sunday"){
    console.log("dasvenebis dge");
} else if(dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday"){
    console.log("ar aris dasvenebis dge");
} else {
    console.log("ar aris kviris dge");
}