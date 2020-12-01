const beersList = document.querySelector('.beers-list');
const addBeerForm = document.querySelector('.add-beer-form'); 

const nameValue = document.getElementById('name-value');
const typeValue = document.getElementById('type-value');
const alcoholPorcentageValue = document.getElementById('alcoholPorcetage-value');
const priceValue = document.getElementById('price-value');



const btnSubmit = document.querySelector('.btn');
const btnFilter = document.querySelector('.filter');
let output = ''; 

const rednerBeers = (beers) => {
    beers.forEach(beer =>{
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body" data-id=${beer.id}>
           <h5 class="card-name">${beer.name}</h5>
           <h6 class="card-type"> ${beer.type}</h6>
           <h6 class="card-alcoholPorcentage">${beer.alcoholPorcentage}</h6>
           <h6 class="card-price">${beer.price}</h6>
           
           <a href="#" class="card-link" id="edit-brewery">Edit</a>
           <a href="#" class="card-link" id="delete-brewery">Delete</a>
         </div>
        </div>
        `;
       
    });
    beersList.innerHTML= output; 

}

const filteredBeers = (beers) =>{
    beers.forEach(beer =>{
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body" data-id=${beer.id}>
           <h5 class="card-name">${beer.name}</h5>
           <h6 class="card-type"> ${beer.type}</h6>
           <h6 class="card-alcoholPorcentage">${beer.alcoholPorcentage}</h6>
           <h6 class="card-price">${beer.price}</h6>
           
         </div>
        </div>
        `;
       
    });
    beersList.innerHTML= output;

}



const prueba= 'http://localhost:5000/api/beers/2'
const url = 'http://localhost:5000/api/beers'
const notSoldBeers = 'http://localhost:5000/api/beers/2/NotSoldBeers'

//const filterd = false; 

//Get - Read the Breweries  //<p class="card-text">${brewery.id}</p>
//
//Method: GET
let selectedOption = document.getElementById('brewery-value').value;
fetch(`${url}/${selectedOption}`)

    .then(res => res.json())
    .then(data => rednerBeers(data))
    //.then(data => filteredBreweries(data))


btnFilter.addEventListener('click', (e) =>{
    //debugger;
        e.preventDefault();
        let selectedOption = document.getElementById('brewery-value').value;
        console.log(selectedOption);    
       
        //console.log('brewery updated');
        fetch(`${url}/${selectedOption}`)
    
            .then(res => res.json())
            .then(data => filteredBeers(data))
            //.then(() => location.reload())
            //filtereData=beersList.filter(function(element, filter){ return element.country =filter;})
    })


 

//Get - Filter NotSoldBeers
//Method: GET 

 
// btnFilter.addEventListener('click', (e) =>{
//     //debugger;
//         e.preventDefault();
//         let country = e.target.parentElement.dataset.country;
//         console.log(countryValue.value);
//         const filter = countryValue.value; 

//        const query = byCountry+filter; 
       

//         //console.log('brewery updated');
//         fetch(query)
    
//             .then(res => res.json())
//             .then(data => filteredBreweries(data, filter))
//             //.then(() => location.reload())
//             //filtereData=beersList.filter(function(element, filter){ return element.country =filter;})
//     })





beersList.addEventListener('click', (e) =>{
    //debugger;
    e.preventDefault();
    let delButtonIsPressed = e.target.id == 'delete-brewery';
    let editButtonIsPressed = e.target.id == 'edit-brewery';

    let id = e.target.parentElement.dataset.id;
    console.log(id);  

   

    //Delete - Remove the existing Brewery 
    //method: DELETE
    if(delButtonIsPressed){
      fetch(`${url}/${id}`,{
         method: 'DELETE',
         headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            name: nameValue.value,
            type: typeValue.value,
            alcoholPorcentage: alcoholPorcentageValue.value,
            price: priceValue.value
        })  
      })
          .then(res => res.json())
          .then(() => location.reload())
    }
    //debugger; 
    if(editButtonIsPressed){
      const parent = e.target.parentElement;

      //let  valueContent = parent.querySelector('.card-name').textContent;
      //let  idContent = 1; 
      let  nameContent = parent.querySelector('.card-name').textContent;
      let  typeContent = parent.querySelector('.card-type').textContent;
      let  alcoholPorcentageContent = parent.querySelector('.card-alcoholPorcentage').textContent;
      let  priceContent = parent.querySelector('.card-price').textContent;

    //   console.log(nameContent, countryContent); 

      nameValue.value = nameContent;
      typeValue.value = typeContent;
      alcoholPorcentageValue.value = alcoholPorcentageContent;
      priceValue.value = priceContent; 
    
    }

    //Update - update the existing brewery 
    //Method: PATCH
    
   
    btnSubmit.addEventListener('click', (e) =>{
        debugger;

        let id_2 = parseInt(id);
        console.log(id_2);

        // let id_3 = parseInt(id_2);
        // console.log(id_3); 

        e.preventDefault();
        //console.log('brewery updated');

        fetch(`${url}/${id}`,{
            method: 'PUT',
            headers: {
               'Content-Type': 'application/json'
           },
           body: JSON.stringify({ 
               id: id_2, 
               name: nameValue.value,
               type: typeValue.value,
               alcoholPorcentage: alcoholPorcentageValue.value,
               price: priceValue.value
               
            })  
        })
            .then(res => res.json())
            .then(() => location.reload())     
    })
    
}); 


// Create - Insert new Brewery 
//Method: POST 

addBeerForm.addEventListener('submit', (e) => {
    e.preventDefault(); 
    
    fetch(postBeer, {  //url 
        method: 'POST', 
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            name: nameValue.value,
            type: typeValue.value,
            alcoholPorcentage: alcoholPorcentageValue.value,
            price: priceValue.value
        }) 
    })
        .then(res => res.json())
        .then(data => {
          const dataArray =[]; 
          dataArray.push(data);
          rednerBeers(dataArray);  
        })
    // console.log('Form submited'); 
})