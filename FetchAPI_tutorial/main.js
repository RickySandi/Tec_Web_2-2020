const breweriesList = document.querySelector('.breweries-list');
const addBreweryForm = document.querySelector('.add-brewery-form'); 
const nameValue = document.getElementById('name-value');
const countryValue = document.getElementById('country-value');
const btnSubmit = document.querySelector('.btn');
const btnFilter = document.querySelector('.filter');
let output = ''; 

const renderBreweries = (breweries) => {
    breweries.forEach(brewery =>{
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body" data-id=${brewery.id}>
           <h5 class="card-name">${brewery.name}</h5>
           <h6 class="card-country">${brewery.country}</h6>
           
           <a href="#" class="card-link" id="edit-brewery">Edit</a>
           <a href="#" class="card-link" id="delete-brewery">Delete</a>
         </div>
        </div>
        `;
       
    });
    breweriesList.innerHTML= output; 

}

const filteredBreweries = (breweries) =>{
    breweries.forEach(brewery =>{
        output+= `
        <div class="card mt-4 col-md-6 bg-ligt">
         <div class="card-body" data-id=${brewery.id}>
           <h5 class="card-name">${brewery.name}</h5>
           <h6 class="card-country">${brewery.country}</h6>
           
           <a href="#" class="card-link" id="edit-brewery">Edit</a>
           <a href="#" class="card-link" id="delete-brewery">Delete</a>
         </div>
        </div>
        `;
       
    });
    breweriesList.innerHTML= output;

}



const url= 'http://localhost:5000/api/breweries'
const byCountry = 'http://localhost:5000/api/breweries/FilterBreweryByCountry?beerCountry='

//const filterd = false; 

//Get - Read the Breweries  //<p class="card-text">${brewery.id}</p>
//
//Method: GET  
fetch(url)

    .then(res => res.json())
    .then(data => renderBreweries(data))
    //.then(data => filteredBreweries(data))
 
//Get - Filter Brewery by Country 
//Method: GET 

 
btnFilter.addEventListener('click', (e) =>{
    //debugger;
        e.preventDefault();
        let country = e.target.parentElement.dataset.country;
        console.log(countryValue.value);
        const filter = countryValue.value; 

       const query = byCountry+filter; 
       

        //console.log('brewery updated');
        fetch(query)
    
            .then(res => res.json())
            .then(data => renderBreweries(data, filter))
            //.then(() => location.reload())
            //filtereData=breweriesList.filter(function(element, filter){ return element.country =filter;})
    })


breweriesList.addEventListener('click', (e) =>{
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
            country: countryValue.value
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
      let  countryContent = parent.querySelector('.card-country').textContent;

    //   console.log(nameContent, countryContent); 

      nameValue.value = nameContent;
      countryValue.value = countryContent; 
    
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
               country: countryValue.value
               
            })  
        })
            .then(res => res.json())
            .then(() => location.reload())     
    })
    
}); 


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