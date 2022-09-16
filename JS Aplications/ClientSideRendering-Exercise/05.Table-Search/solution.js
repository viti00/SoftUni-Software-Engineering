import { html, render } from "../node_modules/lit-html/lit-html.js";
import { getStudents } from "./api.js";

const tbdoy = document.querySelector('tbody');


const studentTemplate = (data) => data.map(s => s = html`
   <tr>
      <td>${s[1].firstName} ${s[1].lastName}</td>
      <td>${s[1].email}</td>
      <td>${s[1].course}</td>
   </tr>
`)

function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   loadAllStudents();
   

   function onClick() {
      document.querySelectorAll('tr').forEach(tr=> tr.classList.remove('select'));
      const inputField = document.getElementById('searchField');

      tbdoy.querySelectorAll('td').forEach(td => {
         if(td.textContent.toLowerCase().includes(inputField.value.toLowerCase())){
            let parent = td.parentNode;
            parent.classList.add('select');
         }
      })

      inputField.value = '';
   }
}

async function loadAllStudents() {
   debugger;
   const students = await getStudents();

   const result = studentTemplate(Object.entries(students));

   render(result, tbdoy);
}

solve();
