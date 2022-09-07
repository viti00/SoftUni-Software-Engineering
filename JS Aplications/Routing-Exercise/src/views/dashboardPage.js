import { get, getAll } from "../api.js";
import { html } from "../../../node_modules/lit-html/lit-html.js";
import { changeActiveClass, spinner } from "../util.js";


const catalogTemplate = (data) => html`
    <div class="row space-top">
        <div class="col-md-12">
            <h1>Welcome to Furniture System</h1>
            <p>Select furniture from the catalog to view details.</p>
        </div>
    </div>
    <div class="row space-top">
        ${data.map(f => furnitureTemplate(f))}
    </div>
`;

const myFurnitureTemplate = (data) => html`
        <div class="row space-top">
            <div class="col-md-12">
                <h1>My Furniture</h1>
                <p>This is a list of your publications.</p>
            </div>
        </div>
        <div class="row space-top">
            ${data.map(f => furnitureTemplate(f))}
        </div>
`

const furnitureTemplate = (data) => html`
    <div class="col-md-4">
        <div class="card text-white bg-primary">
            <div class="card-body">
                <img src="${data.img}" />
                <p>${data.description}</p>
                <footer>
                    <p>Price: <span>${data.price} $</span></p>
                </footer>
                <div>
                    <a href="/details/${data._id}" class="btn btn-info">Details</a>
                </div>
            </div>
        </div>
    </div>
`

const dashboardElement = document.querySelector('#catalogLink');
const myFurnitureElement = document.querySelector('#profileLink');

export async function dashboardPage(ctx) {

    ctx.render(spinner());

    if (ctx.pathname == '/') {
        changeActiveClass(dashboardElement);
        let furnitures = await getAll();
        ctx.render(catalogTemplate(Object.values(furnitures)));
    }
    else if (ctx.pathname == '/my-furniture') {
        changeActiveClass(myFurnitureElement);
        let furnitures = await get();
        ctx.render(myFurnitureTemplate(furnitures))
    }
}