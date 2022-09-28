import { html } from "../../node_modules/lit-html/lit-html.js";

export const catalogTemplate = (data, user) => html`
    <section id="catalogPage">
        <h1>All Albums</h1>
        ${data.length > 0 ? html`
            ${data.map(c=> cardTemplate(c, user))}
        ` : noDataTemplate()}
    </section>
`;

const cardTemplate = (c, user) => html`
    <div class="card-box">
        <img src="${c.imgUrl}">
        <div>
            <div class="text-center">
                <p class="name">Name: ${c.name}</p>
                <p class="artist">Artist: ${c.artist}</p>
                <p class="genre">Genre: ${c.genre}</p>
                <p class="price">Price: $${c.price}</p>
                <p class="date">Release Date: ${c.releaseDate}</p>
            </div>
            ${user !== null? html`
                <div class="btn-group">
                    <a href="/details/${c._id}" id="details">Details</a>
                </div>` : null}
        </div>
    </div>
`;

const noDataTemplate = () => html`
    <p>No Albums in Catalog!</p>
`;