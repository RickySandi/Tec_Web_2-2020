const petsList = document.querySelector('.pets-list');
const addPetForm = document.querySelector('.submit-form');

const btnCatsForm = document.querySelector('.cats');
const btnDogsForm = document.querySelector('.dogs');
 
const nameValue = document.getElementById('name-value');
const typeValue = document.getElementById('type-value');
const adoptedValue = document.getElementById('adopted-value');

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

// function getCatsOrDogs(petsList, criteria){  //Funcion para guardar en una lista cats o dogs 
    
//     var index;
//     const petsArray =[]; 
    
//     for (index = 0; index < petsList.length; ++index) {
//         if(petsList[index].type == criteria){
//             petsArray.push(petsList[index]);
//         }   
//     }
//     return petsArray; 
// }

const url = 'https://localhost:5001/api/pets'

fetch(url)

    .then(res => res.json())
    .then(data => renderPets(data))
  

{/* <h6 class="card-isadopted">${pet.isadopted}</h6> */}

//console.log(adoptedValue.value);

// Create - Insert new Pet 
//Method: POST 

addPetForm.addEventListener('submit', (e) => {
    e.preventDefault(); 
    alert("New pet added");
    
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
            
    })

btnCatsForm.addEventListener('click', (e) =>{
    //debugger;
        e.preventDefault();
      
        //console.log('brewery updated');
        fetch(url)
    
            .then(res => res.json())
            .then(data => renderPets(data))
         
    })