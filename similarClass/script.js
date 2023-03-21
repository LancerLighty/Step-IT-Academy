class Car{
    constructor(model, year, category, wheel, fuel){
        this.model = model;
        this.year = year;
        this.category = category;
        this.wheel = wheel;
        this.fuel = fuel;
    }
}
var model1 = document.querySelector(".model")
var year1 = document.querySelector(".year")
var category1 = document.querySelector("#category")
var wheel1 = document.querySelector("#wheel")
var fuel1 = document.querySelector("#fuel")
var reg = document.querySelector(".reg");
var search = document.querySelector(".search");
var lStorage = JSON.parse(localStorage.getItem("car")) || []
var res = document.querySelector("table")
reg.addEventListener("submit", function(){
    var newcar = new Car(model1.value, year1.value, category1.value, wheel1.value, fuel1.value);
    lStorage.push(newcar);
    localStorage.setItem("car", JSON.stringify(lStorage));
})
var tb =`
<tr>
    <td>model</td>
    <td>year</td>
    <td>category</td>
    <td>wheel</td>
    <td>fuel</td>
</tr>
`
res.innerHTML += tb
for(var i of lStorage){
        var tb =`
        <tr>
            <td>${i.model}</td>
            <td>${i.year}</td>
            <td>${i.category}</td>
            <td>${i.wheel}</td>
            <td>${i.fuel}</td>
        </tr>
    `
    res.innerHTML += tb
}
console.log(lStorage)
var model = document.querySelector(".model2")
var year = document.querySelector(".year2")
var category = document.querySelector("#category2")
var wheel = document.querySelector("#wheel2")
var fuel = document.querySelector("#fuel2")
function updateFormData(x, formData) {
    if (x === model && x.value != "") {
        formData.model = x.value; 
    } else if (x === year && x.value != "") {
      formData.year = x.value; 
    } else if (x === category && x.value != "") {
      formData.category = x.value;
    } else if (x === wheel && x.value != "") {
      formData.wheel = x.value;
    } else if (x === fuel && x.value != "") {
      formData.fuel = x.value;
    }
    // Log the updated form data to the console
  }
function updateFormDataall(formData){
    updateFormData(model, formData)
    updateFormData(year, formData)
    updateFormData(category, formData)
    updateFormData(wheel, formData)
    updateFormData(fuel, formData)
}
search.addEventListener("submit", function(){
    res.innerHTML = ""
    var formData = {};
    updateFormDataall(formData)
    console.log(formData)
    var tb =`
    <tr>
        <td>model</td>
        <td>year</td>
        <td>category</td>
        <td>wheel</td>
        <td>fuel</td>
    </tr>
`
res.innerHTML += tb
    for(var i of lStorage){
        var boolean = true
        for(var x in formData){
            console.log(x + " x")
            console.log(formData[x] + " formData[x]")
            console.log(i[x] + " i[x]")
            if(i[x] != formData[x]){
                boolean = false
            }
        }
        if(boolean){
            var tb =`
                <tr>
                    <td>${i.model}</td>
                    <td>${i.year}</td>
                    <td>${i.category}</td>
                    <td>${i.wheel}</td>
                    <td>${i.fuel}</td>
                </tr>
            `
            res.innerHTML += tb
        }
      }
})