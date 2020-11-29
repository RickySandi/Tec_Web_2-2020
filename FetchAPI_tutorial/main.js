const breweriesList = document.querySelector('.breweries-list');
const addBreweryForm = document.querySelector('.add-brewery-form'); 
const nameValue = document.getElementById('name-value');
const countryValue = document.getElementById('country-value');
let output = ''; 

const renderBreweries = (breweries) => {
    breweries.forEach(brewery =>{
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body">
           <h5 class="card-title">Name: ${brewery.name}</h5>
           <h6 class="card-subtitle mb-2 text-muted">Country: ${brewery.country}</h6>
           <p class="card-text">id: ${brewery.id}</p>
           <a href="#" class="card-link">Edit</a>
           <a href="#" class="card-link">Delete</a>
         </div>
        </div>
        `;
       
    });
    breweriesList.innerHTML= output; 

}

const url= 'http://localhost:5000/api/breweries/'

//Get - Read the Breweries 
//Method: GET  
fetch(url)
    .then(res => res.json())
    .then(data => renderBreweries(data))

// Create - Insert new Brewery 
//Method: POST 

addBreweryForm.addEventListener('submit', (e) => {
    e.preventDefault(); 
    console.log(nameValue.value);

    fetch(url, {
        method: 'POST', 
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            name: nameValue.value,
            country: countryValue.value
        }) 
    })
        .then(res => res.json())
        .then(data => {
          const dataArray =[]; 
          dataArray.push(data);
          renderBreweries(dataArray);  
        })
    // console.log('Form submited'); 
})