import {html, render} from "../node_modules/lit-html/lit-html.js";
import {towns} from "./towns.js";

const divTowns = document.getElementById('towns');
const searchBtn = document.querySelector('button');

searchBtn.addEventListener('click', search)

const townTemplate = (data) => html`
   <ul>
      ${data.map(t=> t = html`
         <li>${t}</li>
      `)}
   </ul>
`

function loadAllTowns(){
   const result = townTemplate(towns);
   render(result, divTowns);
}

function search() {
   const inputField = document.getElementById('searchText');
   document.querySelectorAll('li').forEach(li => {
      if(li.textContent.toLowerCase().includes(inputField.value.toLowerCase())){
         li.setAttribute('class', 'active');
      }
      else{
         li.classList.remove('active');
      }
   })
}


loadAllTowns();