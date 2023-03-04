class Student{
    constructor(fname,lname,faculty){
        this.fname = fname
        this.lname = lname
        this.faculty = faculty
        this.sub = ["georgian","english", "math", "hisory"]
        this.subject1 = parseInt(Math.random()*101)
        this.subject2 = parseInt(Math.random()*101)
        this.subject3 = parseInt(Math.random()*101)
        this.subject4 = parseInt(Math.random()*101)
    }
    
    averageGrade(){
        return (this.subject1 + this.subject2 + this.subject3 + this.subject4)/4
    }
}
function randomNum(){
    return parseInt(Math.random() * 100)
}
var form = document.querySelector("form")
var faculty = document.querySelector(".faculty")
var fName = document.querySelector(".fName")
var lName = document.querySelector(".lName")
var tb = document.querySelector("table")
var td = document.querySelectorAll("td")
var arr = []
var arrcopy =[]
var min = document.querySelector(".min")
var max = document.querySelector(".max")
form.addEventListener("submit", function(e){
    e.preventDefault
    var obj = new Student(fName.value,lName.value,faculty.value);
    // var tmp = `
    // <tr>
    //     <td>${obj.fname + " " + obj.lname}</td>
    //     <td>${obj.faculty}</td>
    //     <td>${obj.subject1}</td>
    //     <td>${obj.subject2}</td>
    //     <td>${obj.subject3}</td>
    //     <td>${obj.subject4}</td>
    //     <td>${obj.averageGrade()}</td>
    // </tr>
    // `
    // tb.innerHTML += tmp
    arr.push(obj)
    arrcopy.push(obj)
    arrcopy = arrcopy.sort(function(a,b){
        return a.averageGrade() - b.averageGrade()
    })
    tb.innerHTML = ""
    var th = `
    <tr>
        <th class="stud">Student</th>
        <th class="fac">Faculty</th>
        <th class="geo">Georgian</th>
        <th class="eng">English</th>
        <th class="math">Math</th>
        <th class="his">History</th>
        <th class="ave">AVG</th>
    </tr>`
    tb.innerHTML += th
    for(var i of arr){
        console.log(...arr)
        console.log(...arrcopy)
        if(arrcopy[0] == i){ 7
            var color = "red"
        }else if (arrcopy[arrcopy.length-1] == i){
            var color = "green"
        } else {
            var color = "black"
        }
        var tmp = `
        <tr>
            <td class="stud" style="color:${color}">${i.fname + " " + i.lname}</td>
            <td class="fac" style="color:${color}">${i.faculty}</td>
            <td class="geo" style="color:${color}">${i.subject1}</td>
            <td class="eng" style="color:${color}">${i.subject2}</td>
            <td class="math" style="color:${color}">${i.subject3}</td>
            <td class="his" style="color:${color}">${i.subject4}</td>
            <td class="ave" style="color:${color}">${i.averageGrade()}</td>
        </tr>
        `
        tb.innerHTML += tmp
    }

    // max.innerText = arr[arr.length - 1].fname + " " + arr[arr.length - 1].lname
    // min.innerText = arr[0].fname + " " + arr[0].lname
    // console.log(...arr)
    // console.log(this)

    // var maxindex = arr[0]
    // for(var i = 1; i < arr.length; i++){
    //     if(maxindex.averageGrade() < arr[i].averageGrade()){
    //         maxindex = arr[i];
    //     }
    // }
    // max.innerText = maxindex.fname + " " + maxindex.lname
    // var minindex = arr[0]
    // for(var i = 1; i < arr.length; i++){
    //     if(minindex.averageGrade() > arr[i-1].averageGrade()){
    //         minindex = arr[i];
    //     }
    // }
})
// form.addEventListener("submit", function(e){
//     e.preventDefault
//     var student = new Student(fName.value,lName.value,faculty.value);
//     console.log(fName.value,lName.value,student.sub[0])
//     var i = 0;
//     while(td[i].innerText != ""){
//         i+=7
//     }
//     td[i].innerText =student.fname + " " + student.lname
//     td[i + 1].innerText =student.faculty
//     for(var j = 0; j < student.grades.length; j++){
//         td[i + 2 + j].innerText = student.grades[j]
//     }
//     td[i + 6].innerText = student.averageGrade()
//     for(var j = i; j <= i + 6; j++){
//         if(td[j].innerText < 60){
//             td[j].style.color = "red"
//         } else if(td[j].innerText >= 60) {
//             td[j].style.color = "green"
//         }
//         td[j].style.padding = "5px"
//         td[j].style.border = "1px solid gray"
//     }
// })
// function generateTable() {
//     // creates a <table> element and a <tbody> element
//     const tbl = document.createElement("table");
//     const tblBody = document.createElement("tbody");
  
//     // creating all cells
//     for (let i = 0; i < 1; i++) {
//       // creates a table row
//       const row = document.createElement("tr");
  
//       for (let j = 0; j < 7; j++) {
//         // Create a <td> element and a text node, make the text
//         // node the contents of the <td>, and put the <td> at
//         // the end of the table row
//         const cell = document.createElement("td");
//         // const cellText = document.createTextNode(`cell in row ${i}, column ${j}`);
//         cell.appendChild(cellText);
//         row.appendChild(cell);
//       }
  
//       // add the row to the end of the table body
//       tblBody.appendChild(row);
//     }
  
//     // put the <tbody> in the <table>
//     tbl.appendChild(tblBody);
//     // appends <table> into <body>
//     document.body.appendChild(tbl);
//     // sets the border attribute of tbl to '2'
//     // tbl.setAttribute("border", "1");
//     tbl.style.border = "1px solid black"
//   }
//   generateTable()