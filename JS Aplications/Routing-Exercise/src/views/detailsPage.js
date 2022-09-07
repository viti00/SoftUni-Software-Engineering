import { html } from "../../../node_modules/lit-html/lit-html.js";
import { getFurniture } from "../api.js";
import { getUserId, spinner } from "../util.js";


const detailsTemplate = (data, userId) => html`
    <div class="row space-top">
            <div class="col-md-12">
                <h1>Furniture Details</h1>
            </div>
        </div>
        <div class="row space-top">
            <div class="col-md-4">
                <div class="card text-white bg-primary">
                    <div class="card-body">
                        <img src="${data.img}" />
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <p>Make: <span>${data.make}</span></p>
                <p>Model: <span>${data.model}</span></p>
                <p>Year: <span>${data.year}</span></p>
                <p>Description: <span>${data.description}</span></p>
                <p>Price: <span>${data.price}</span></p>
                <p>Material: <span>${data.material}</span></p>
                ${(userId === data._ownerId) ? 
                html`
                <div>
                    <a href='/edit/${data._id}' data-id ="${data._id}" class="btn btn-info">Edit</a>
                    <a href='/delete' data-id ="${data._id}" class="btn btn-red">Delete</a>
                </div>` : null}
            </div>
        </div>
`

export async function details(ctx){
    debugger;
    let furniture = await getFurniture(ctx.params.id);
    const userId = getUserId();

    ctx.render(spinner());
    ctx.render(detailsTemplate(furniture, userId));
}