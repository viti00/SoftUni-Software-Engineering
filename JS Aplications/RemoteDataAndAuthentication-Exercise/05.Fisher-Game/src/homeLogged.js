let guest = document.getElementById('guest');
guest.style.display = 'none';

let divCatches = document.getElementById('catches');
divCatches.querySelectorAll('div').forEach(div=>div.remove());

let fieladSetElement = document.getElementById('main');
fieladSetElement.children[0].style.display = 'none';

let pElement = document.createElement('p');
pElement.textContent = 'Click to load cathes';

let addBtn = document.querySelector(".add");
addBtn.disabled = false;

fieladSetElement.appendChild(pElement);

let loadBtn = document.querySelector('.load');

loadBtn.addEventListener('click', loadCatches);

async function loadCatches(){
    let response = await fetch('http://localhost:3030/data/catches');
    let result = await response.json();
    if(fieladSetElement.querySelector('p')){
        fieladSetElement.querySelector('p').remove();
    }
    for (const catchResult of result) {
        let c = createCatch(catchResult);
        fieladSetElement.children[0].style.display = 'block';
        divCatches.appendChild(c);
    }
}

function createCatch(c){
    let {angler, weight, species, location, bait, captureTime, _id} = c;
    
    let divElement = document.createElement('div');
    divElement.classList.add('catch');
    divElement.innerHTML = `<label>Angler</label>
     <input type="text" class="angler" value="${angler}">
     <label>Weight</label>
     <input type="text" class="weight" value="${weight}">
     <label>Species</label>
     <input type="text" class="species" value="${species}">
     <label>Location</label>
     <input type="text" class="location" value="${location}">
     <label>Bait</label>
     <input type="text" class="bait" value="${bait}">
     <label>Capture Time</label>
     <input type="number" class="captureTime" value="${captureTime}">`;

     let updateBtn = document.createElement('button');
     updateBtn.classList.add('update');
     updateBtn.dataset.id = _id;
     updateBtn.textContent = 'Update';

     let deleteBtn = document.createElement('button');
     deleteBtn.classList.add('delete');
     deleteBtn.dataset.id = _id;
     deleteBtn.textContent = 'Delete';

     if(localStorage.getItem('token') !== _id){
       updateBtn.disabled = true;
       deleteBtn.disabled = true;
    }

     divElement.appendChild(updateBtn);
     divElement.appendChild(deleteBtn);

     return divElement;
}