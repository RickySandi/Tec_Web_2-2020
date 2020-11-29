const breweriesList = document.querySelector('.breweries-list'); 
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
//Method: Get 
fetch(url)
    .then(res => res.json())
    .then(data => renderBreweries(data))