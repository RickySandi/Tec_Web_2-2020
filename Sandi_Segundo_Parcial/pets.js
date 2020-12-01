const petsList = document.querySelector('.pets-list');
// const addBreweryForm = document.querySelector('.add-brewery-form'); 
// const nameValue = document.getElementById('name-value');
// const countryValue = document.getElementById('country-value');
// const btnSubmit = document.querySelector('.btn');
// const btnFilter = document.querySelector('.filter');
let output = ''; 

const renderPets = (pets) => {
    pets.forEach(pet =>{
        var result = "false"; 
        if(pet.isadopted){
            result = "true"; 
        }
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body" data-id=${pet.id}>
           <h5 class="card-name">${pet.name}</h5>
           <h6 class="card-isadopted">${pet.isadopted}</h6>
           <h6 class="card-type">${pet.type}</h6>
           
         </div>
        </div>
        `;
       
    });
    petsList.innerHTML= output; 

}

const url = 'https://localhost:5001/api/pets'

fetch(url)

    .then(res => res.json())
    .then(data => renderPets(data))
    //.then(data => filteredBreweries(data))

{/* <h6 class="card-isadopted">${pet.isadopted}</h6> */}