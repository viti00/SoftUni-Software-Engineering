import { html, render } from "../node_modules/lit-html/lit-html.js";
import { cats } from "./catSeeder.js";

const allCats = document.getElementById('allCats');
const catTemplate = (data) => html`
    <ul>
        ${data.map(c=> c = html`
        <li>
                <img src="./images/${c.imageLocation}.jpg" width="250" height="250" alt="Card image cap">
                <div class="info">
                    <button class="showBtn" @click=${hideShow}>Show status code</button>
                    <div class="status" style="display: none" id="${c.id}">
                        <h4>Status Code: ${c.statusCode}</h4>
                        <p>${c.statusMessage}</p>
                    </div>
                </div>
            </li>
        `)}
    </ul>
`


function loadAllCats(){
    const result = catTemplate(cats);

    render(result, allCats);
}

function hideShow(e){
    const hidenElement = e.target.nextElementSibling;
    
    if(hidenElement.style.display == 'none'){
        hidenElement.style.display = 'block';
        e.target.textContent = 'Hide status code';
    }
    else {
        hidenElement.style.display = 'none';
        e.target.textContent = 'Show status code';
    }
}

loadAllCats();