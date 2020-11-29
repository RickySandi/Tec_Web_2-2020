const breweriesList = document.querySelector('.breweries-list'); 
let output = ''; 

const url= 'http://localhost:5000/api/breweries/'

//Get - Read the Breweries 
//Method: Get 
fetch(url)
    .then(res => res.json())
    .then(data => {
        data.forEach(brewery =>{
            output+= `
            <div class="card mt-4 col-md-6 bg-ligt">
             <div class="card-body">
               <h5 class="card-title">${brewery.name}</h5>
               <h6 class="card-subtitle mb-2 text-muted">Card subtitle</h6>
               <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
               <a href="#" class="card-link">Edit</a>
               <a href="#" class="card-link">Delete</a>
             </div>
            </div>
            `;
           
        });
        breweriesList.innerHTML= output; 
    })
