const petsList = document.querySelector('.pets-list');
const addPetForm = document.querySelector('.submit-form');

const btnCatsForm = document.querySelector('.cats');
const btnDogsForm = document.querySelector('.dogs');
 
const nameValue = document.getElementById('name-value');
const typeValue = document.getElementById('type-value');
const adoptedValue = document.getElementById('adopted-value');
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
           <h6 class="card-isadopted">${pet.isAdopted}</h6>
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

//console.log(adoptedValue.value);

// Create - Insert new Pet 
//Method: POST 

addPetForm.addEventListener('submit', (e) => {
    e.preventDefault(); 
    
    fetch(url, {
        method: 'POST', 
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            name: nameValue.value,
            type: typeValue.value
            //isAdopted: adoptedValue.value
        }) 
    })
        .then(res => res.json())
        .then(data => {
          const dataArray =[]; 
          dataArray.push(data);
          renderPets(dataArray);  
        })
    // console.log('Form submited'); 
})

btnCatsForm.addEventListener('click', (e) =>{
    //debugger;
        e.preventDefault();
      
        //console.log('brewery updated');
        fetch(url)
    
            .then(res => res.json())
            .then(data => renderPets(data))
            //.then(() => location.reload())
            //filtereData=beersList.filter(function(element, filter){ return element.country =filter;})
    })

btnCatsForm.addEventListener('click', (e) =>{
    //debugger;
        e.preventDefault();
      
        //console.log('brewery updated');
        fetch(url)
    
            .then(res => res.json())
            .then(data => renderPets(data))
            //.then(() => location.reload())
            //filtereData=beersList.filter(function(element, filter){ return element.country =filter;})
    })