const breweriesList = document.querySelector('.breweries-list');
const addBreweryForm = document.querySelector('.add-brewery-form'); 
const nameValue = document.getElementById('name-value');
const countryValue = document.getElementById('country-value');
let output = ''; 

const renderBreweries = (breweries) => {
    breweries.forEach(brewery =>{
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body" data-id=${brewery.id}>
           <h5 class="card-name">Name: ${brewery.name}</h5>
           <h6 class="card-country">Country: ${brewery.country}</h6>
           <p class="card-text">id: ${brewery.id}</p>
           <a href="#" class="card-link" id="edit-brewery">Edit</a>
           <a href="#" class="card-link" id="delete-brewery">Delete</a>
         </div>
        </div>
        `;
       
    });
    breweriesList.innerHTML= output; 

}

const url= 'http://localhost:5000/api/breweries'

//Get - Read the Breweries 
//Method: GET  
fetch(url)
    .then(res => res.json())
    .then(data => renderBreweries(data))

breweriesList.addEventListener('click', (e) =>{
    e.preventDefault();
    let delButtonIsPressed = e.target.id == 'delete-brewery';
    let editButtonIsPressed = e.target.id == 'edit-brewery';

    let id = e.target.parentElement.dataset.id; 

    //Delete - Remove the existing Brewery 
    //method: DELETE
    if(delButtonIsPressed){
        fetch(`${url}/${id}`,{
         method: 'DELETE', 
        })
          .then(res => res.json())
          .then(data => location.reload())
    }

    if(editButtonIsPressed){
      const parent = e.target.parentElement;
      let  nameContent = parent.querySelector('.card-name').textContent;
      let  countryContent = parent.querySelector('.card-country').textContent;
       
      console.log(nameContent, countryContent);
    }


})


// Create - Insert new Brewery 
//Method: POST 

addBreweryForm.addEventListener('submit', (e) => {
    e.preventDefault(); 
    
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