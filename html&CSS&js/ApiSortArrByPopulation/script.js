var cards = document.querySelector(".cards")
var patara = document.querySelector(".a")
var didi = document.querySelector(".b")
fetch('https://datausa.io/api/data?drilldowns=Nation&measures=Population')
.then(x=>{
    return x.json()
})
.then(y=>{
    for(var i of y.data){
        var newCard = `
        <div class="card">
            <h1>Nation: ${i.Nation}</h1>
            <h2>Year: ${i.Year}</h2>
            <h2>Population: ${i.Population}</h2>
        </div>`
        cards.innerHTML += newCard
    }
    console.log(y.data.sort((a, b) => a.Population - b.Population))
    patara.innerHTML = y.data[0].Population
    didi.innerHTML = y.data[y.data.length - 1].Population

})