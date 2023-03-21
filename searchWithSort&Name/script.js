var input = document.querySelector("input");
var select = document.querySelector("select");
var btn = document.querySelector("button")
var product = document.querySelector(".product")
fetch("http://makeup-api.herokuapp.com/api/v1/products.json?brand=maybelline")
.then(x=>{
  console.log(x)
    return x.json()
})
.then(arr=>{
  for(var i of arr){
    var tb1 =`
    <div class="card" style="">
      <img src="${i.image_link}" class="card-img-top" alt="...">
      <div class="card-body">
        <h5 class="card-title">${i.name}</h5>
        <h5 class="card-title">${i.brand}</h5>
        <h5 class="card-title">id: ${i.id}</h5>
        <p class="card-text">price: ${i.price}</p>
        <p class="card-text">product: <a href="${i.product_link}" class="btn btn-primary">${i.product_link}</a></p>
        <p class="card-text">web link: <a href="${i.website_link}" class="btn btn-primary">${i.website_link}</a></p>
        <p class="card-text">desctiption: ${i.description}</p>
      </div>
    </div>
    `
    product.innerHTML += tb1
  }
  //      <a href="#" class="btn btn-primary">Go somewhere</a>
    btn.addEventListener("click", function(){
        var sort = arr;
        var inpvalue = input.value.toLowerCase();
        if(select.value == "zrdadobit"){
            sort = arr.sort((a,b) => (a.price - b.price));
        } else if (select.value == "klebadobit"){
            sort = arr.sort((a,b) => (b.price - a.price));
        }
        var result = []
        for(var x of sort){
          // var i = x["name"].toLowerCase();
          // var syllables = i.split(" "); // syllables shi inaxeba array sadac ari name romelic aris dayofili sityvebad
          // for (var j = 0; j < syllables.length; j++) { // es loopi gadayveba syllables
          //   if (syllables[j].indexOf(inpvalue) !== -1) { // checks if indexOf returns -1 if it does then it couldn't find what we needed
          //     result.push(i + "; ");
          //     break;
          //   }
          // }
          var i = x.name.toLowerCase();
          if (i.includes(inpvalue)) {
            result.push(x);
          }
        }
        product.innerHTML = ""
        for(var i of result){
           var tb =`
           <div class="card" style="">
           <img src="${i.image_link}" class="card-img-top" alt="...">
           <div class="card-body">
             <h5 class="card-title">${i.name}</h5>
             <h5 class="card-title">${i.brand}</h5>
             <h5 class="card-title">id: ${i.id}</h5>
             <p class="card-text">price: ${i.price}</p>
             <p class="card-text">product: <a href="${i.product_link}" class="btn btn-primary">${i.product_link}</a></p>
             <p class="card-text">web link: <a href="${i.website_link}" class="btn btn-primary">${i.website_link}</a></p>
             <p class="card-text">desctiption: ${i.description}</p>
           </div>
       </div>
           `
           product.innerHTML += tb
        }
    })
    input.addEventListener("keyup", function(){
      var sort = arr;
      var inpvalue = input.value.toLowerCase();
      if(select.value == "zrdadobit"){
          sort = arr.sort((a,b) => (a.price - b.price));
      } else if (select.value == "klebadobit"){
          sort = arr.sort((a,b) => (b.price - a.price));
      }
      var result = []
      for(var x of sort){
        // var i = x["name"].toLowerCase();
        // var syllables = i.split(" "); // syllables shi inaxeba array sadac ari name romelic aris dayofili sityvebad
        // for (var j = 0; j < syllables.length; j++) { // es loopi gadayveba syllables
        //   if (syllables[j].indexOf(inpvalue) !== -1) { // checks if indexOf returns -1 if it does then it couldn't find what we needed
        //     result.push(i + "; ");
        //     break;
        //   }
        // }
        var i = x.name.toLowerCase();
        if (i.includes(inpvalue)) {
          result.push(x);
        }
      }
      // console.clear()
      // console.log(...result)
      product.innerHTML = ""
      for(var i of result){
         var tb =`
         <div class="card" style="">
         <img src="${i.image_link}" class="card-img-top" alt="...">
         <div class="card-body">
           <h5 class="card-title">${i.name}</h5>
           <h5 class="card-title">${i.brand}</h5>
           <h5 class="card-title">id: ${i.id}</h5>
           <p class="card-text">price: ${i.price}</p>
           <p class="card-text">product: <a href="${i.product_link}" class="btn btn-primary">${i.product_link}</a></p>
           <p class="card-text">web link: <a href="${i.website_link}" class="btn btn-primary">${i.website_link}</a></p>
           <p class="card-text">desctiption: ${i.description}</p>
         </div>
     </div>
         `
         product.innerHTML += tb
      }
    })
})